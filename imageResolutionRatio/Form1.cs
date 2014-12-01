using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageResolutionRatio {
    public partial class Form1 : Form {
        Bitmap originalImage;
        Bitmap bitmap;
        Bitmap newBitmap;
        Color color;
        bool copyWidth;
        int numToCopy;
        int height;
        int width;
        int ratioWidth;
        int ratioHeight;
        float imageRatio;
        float ratio;
        string fileName_path;

        public Form1 () {
            InitializeComponent();
            bitmap = null;
            originalImage = null;
            newBitmap = null;
            copyWidth = false;
            numToCopy = 0;
            height = 0;
            width = 0;
            ratioWidth = 0;
            ratioHeight = 0;
            imageRatio = 0;
            ratio = 0;
            fileName_path = string.Empty;
            color = Color.White;
            Icon = global::imageResolutionRatio.Properties.Resources.imageRatioIcon;

            // idea: get the screen resolution from the display and put the 
            // value the ratio text boxes


        }

        #region Even Handlers

        private void Form1_Load ( object sender, EventArgs e ) {
            colorDialog1.Color = Color.White;
            Rectangle screen_rec = Screen.PrimaryScreen.Bounds;
            int gcd = getGCD( screen_rec.Width, screen_rec.Height );
            txtRatioWidth.Text = txtImageRatioWidth.Text = ( screen_rec.Width / gcd ).ToString();
            txtRatioHeight.Text = txtImageRatioHeight.Text = ( screen_rec.Height / gcd ).ToString();

        }

        private void btnExit_Click ( object sender, EventArgs e ) {
            Environment.Exit( Environment.ExitCode );
        }

        private void btnOpenImage_Click ( object sender, EventArgs e ) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = GetImageFilter();

            if ( ofd.ShowDialog() == DialogResult.OK ) {
                if ( newBitmap != null ) {
                    newBitmap.Dispose();
                }

                originalImage = new Bitmap( ofd.FileName );
                bitmap = ( Bitmap ) originalImage.Clone();
                originalImage.Dispose();
                fileName_path = ofd.FileName;
                lblImageResolution.Text = bitmap.Width + " x " + bitmap.Height;
                pbPreview.Image = bitmap;
                pbPreview.SizeMode = PictureBoxSizeMode.Zoom;


                calculateImageStuff();

            }

        }

        private void txt_KeyPress ( object sender, KeyPressEventArgs e ) {
            if ( !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar ) ) {
                e.Handled = true;

            }

        }

        private void txt_TextChanged ( object sender, EventArgs e ) {
            calculate();

        }

        private void lblSideLength_Click ( object sender, EventArgs e ) {
            Clipboard.SetText( numToCopy.ToString() );

        }

        private void txtRatioHeight_TextChanged ( object sender, EventArgs e ) {
            calculate();

        }

        private void Form1_DragEnter ( object sender, DragEventArgs e ) {
            if ( e.Data.GetDataPresent( DataFormats.FileDrop ) )
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop ( object sender, DragEventArgs e ) {
            string[] s = ( string[] ) e.Data.GetData( DataFormats.FileDrop, false );

            try {
                bitmap = new Bitmap( s.First() );
                lblImageResolution.Text = bitmap.Width + " x " + bitmap.Height;

                calculateImageStuff();
            } catch {
                MessageBox.Show( "Not supported image format", "Error" );

            }



        }

        private void rbManual_CheckedChanged ( object sender, EventArgs e ) {
            if ( ( sender as RadioButton ).Checked ) {
                btnPickColor.Enabled = true;
            }
            this.pbPreview.Click -= new System.EventHandler( this.pbPreview_Click );
            this.pbPreview.Click -= new System.EventHandler( this.pbPreview_Click );
            calculateImageStuff();
        }

        private void rbAutomatic_CheckedChanged ( object sender, EventArgs e ) {
            if ( ( sender as RadioButton ).Checked ) {
                btnPickColor.Enabled = false;
            }
            this.pbPreview.Click -= new System.EventHandler( this.pbPreview_Click );
            this.pbPreview.Click -= new System.EventHandler( this.pbPreview_Click );
            calculateImageStuff();

        }

        private void rbFromImage_CheckedChanged ( object sender, EventArgs e ) {
            if ( ( sender as RadioButton ).Checked ) {
                btnPickColor.Enabled = false;
            }

            this.pbPreview.Click += new System.EventHandler( this.pbPreview_Click );



        }

        private void btnPickColor_Click ( object sender, EventArgs e ) {

            if ( colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {
                // do something with the color
                lblColorPreview.BackColor = colorDialog1.Color;
                this.color = colorDialog1.Color;
                calculateImageStuff();
            }
        }

        private void pbPreview_Click ( object sender, EventArgs e ) {

            MouseEventArgs me = ( MouseEventArgs ) e;
            Color color = new Color();
            Bitmap original = ( Bitmap ) ( sender as PictureBox ).Image;
            PropertyInfo imageRectangleProperty = typeof( PictureBox ).GetProperty( "ImageRectangle", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance );
            Rectangle rectangle = ( Rectangle ) imageRectangleProperty.GetValue( ( sender as PictureBox ), null );
            if ( rectangle.Contains( me.Location ) ) {
                using ( Bitmap copy = new Bitmap( ( sender as PictureBox ).ClientSize.Width, ( sender as PictureBox ).ClientSize.Height ) ) {
                    using ( Graphics g = Graphics.FromImage( copy ) ) {
                        g.DrawImage( ( sender as PictureBox ).Image, rectangle );

                        color = copy.GetPixel( me.X, me.Y );
                    }
                }

            }

            lblColorPreview.BackColor = color;
            this.color = color;
            calculateImageStuff();
        }

        private void txtRatio_TextChanged ( object sender, EventArgs e ) {
            calculateImageStuff();
        }

        private void saveToolStripMenuItem_Click ( object sender, EventArgs e ) {
            save( fileName_path );

        }

        private void saveAsToolStripMenuItem_Click ( object sender, EventArgs e ) {
            save();
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e ) {
            new AboutForm().Show();
        }



        #endregion

        /// <summary>
        /// Calculate the new image resolution (not the opened image)
        /// </summary>
        private void calculate () {
            if ( txtRatioHeight.Text == string.Empty || txtRatioWidth.Text == string.Empty ) {
                return;

            }

            if ( txtHeight.Text == string.Empty && txtWidth.Text == string.Empty ) {
                lblSide.Text = string.Empty;
                lblSideLength.Text = string.Empty;
                return;

            }

            int height = 0;
            int width = 0;
            int ratioWidth = 0;
            int ratioHeight = 0;
            float imageRatio = 0;
            float ratio = 0;

            ratioWidth = int.Parse( txtRatioWidth.Text );
            ratioHeight = int.Parse( txtRatioHeight.Text );

            if ( txtHeight.Text != string.Empty && txtWidth.Text != string.Empty ) {
                height = int.Parse( txtHeight.Text );
                width = int.Parse( txtWidth.Text );
                imageRatio = ( float ) width / ( float ) height;

                if ( imageRatio < ratio ) {
                    ratio = ( float ) ratioWidth / ( float ) ratioHeight;
                    width = ( int ) ( height * ratio );
                    numToCopy = width;
                    copyWidth = true;

                } else {
                    ratio = ( float ) ratioHeight / ( float ) ratioWidth;
                    height = ( int ) ( width * ratio );
                    numToCopy = height;
                    copyWidth = false;

                }

                lblSide.Text = "Width x Height";
                lblSideLength.Text = width + " x " + height;

            } else if ( txtHeight.Text != string.Empty ) {
                height = int.Parse( txtHeight.Text );
                ratio = ( float ) ratioWidth / ( float ) ratioHeight;
                width = ( int ) ( height * ratio );
                lblSide.Text = "Width";
                lblSideLength.Text = width.ToString();
                numToCopy = width;
                copyWidth = true;

            } else if ( txtWidth.Text != string.Empty ) {
                width = int.Parse( txtWidth.Text );
                ratio = ( float ) ratioHeight / ( float ) ratioWidth;
                height = ( int ) ( width * ratio );
                lblSide.Text = "Height";
                lblSideLength.Text = height.ToString();
                numToCopy = height;
                copyWidth = false;

            }

            if ( copyWidth == true ) {
                toolTip1.SetToolTip( lblSideLength, "Click to copy new width to clipboard" );

            } else {
                toolTip1.SetToolTip( lblSideLength, "Click to copy new height to clipboard" );

            }

        }

        /// <summary>
        /// Calculate the new resolution of the opened image
        /// </summary>
        private void calculateImageStuff () {
            toolStripStatusLabel.Text = "Processing...";

            if ( bitmap == null ) {
                toolStripStatusLabel.Text = "Ready";
                return;
            }

            if ( txtImageRatioWidth.Text == string.Empty || txtImageRatioHeight.Text == string.Empty ) {
                toolStripStatusLabel.Text = "Ready";
                return;
            }

            if ( bitmap != null ) {
                ratioWidth = int.Parse( txtImageRatioWidth.Text );
                ratioHeight = int.Parse( txtImageRatioHeight.Text );
                ratio = ( float ) ratioWidth / ( float ) ratioHeight;
                if ( ratio > 10 ) {
                    toolStripStatusLabel.Text = "Out of Memory. Ratio is too big (" + ratio + ")";
                    System.Media.SystemSounds.Exclamation.Play();
                    return;

                }
                if ( ratio < 0.1 ) {
                    toolStripStatusLabel.Text = "Out of Memory. Ratio is too small (" + ratio + ")";
                    System.Media.SystemSounds.Exclamation.Play();
                    return;

                }


                imageRatio = ( float ) bitmap.Width / ( float ) bitmap.Height;

                if ( imageRatio < ratio ) {
                    width = ( int ) ( bitmap.Height * ratio );
                    lblNewImageResolution.Text = width + " x " + bitmap.Height;
                    numToCopy = width;
                    copyWidth = true;
                    height = bitmap.Height;

                } else {
                    ratio = ( float ) ratioHeight / ( float ) ratioWidth;
                    height = ( int ) ( bitmap.Width * ratio );
                    lblNewImageResolution.Text = bitmap.Width + " x " + height;
                    numToCopy = height;
                    copyWidth = false;
                    width = bitmap.Width;

                }

            }

            if ( copyWidth == true ) {
                toolTip1.SetToolTip( lblNewImageResolution, "Click to copy new width to clipboard" );

            } else {
                toolTip1.SetToolTip( lblNewImageResolution, "Click to copy new height to clipboard" );

            }

            if ( rbAutomatic.Checked ) {
                getColorAutomatic();

            }

            paintImage( width, height );
        }

        /// <summary>
        /// Gets the supported image formats
        /// </summary>
        /// <returns>Returns a string ready for the OpenFileDialog and SaveFileDialog filter with the supported image formats</returns>
        private string GetImageFilter () {
            StringBuilder allImageExtensions = new StringBuilder();
            string separator = "";
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            Dictionary<string, string> images = new Dictionary<string, string>();
            foreach ( ImageCodecInfo codec in codecs ) {
                allImageExtensions.Append( separator );
                allImageExtensions.Append( codec.FilenameExtension );
                separator = ";";
                images.Add( string.Format( "{0} Files: ({1})", codec.FormatDescription, codec.FilenameExtension ),
                           codec.FilenameExtension );
            }
            StringBuilder sb = new StringBuilder();
            if ( allImageExtensions.Length > 0 ) {
                sb.AppendFormat( "{0}|{1}", "All Images", allImageExtensions.ToString() );
            }
            images.Add( "All Files", "*.*" );
            foreach ( KeyValuePair<string, string> image in images ) {
                sb.AppendFormat( "|{0}|{1}", image.Key, image.Value );
            }
            return sb.ToString();
        }

        /// <summary>
        /// Paint the new background color under the image
        /// </summary>
        /// <param name="width">Width of the new Image</param>
        /// <param name="height">Heght of the new image</param>
        private void paintImage ( int width, int height ) {
            newBitmap = new Bitmap( width, height );
            Graphics g = Graphics.FromImage( newBitmap );
            g.Clear( this.color );
            try {
                g.DrawImage( newBitmap, 0, 0, width, height );

            } catch ( OutOfMemoryException ) {
                toolStripStatusLabel.Text = "Out of Memory Exception. the New image is too big " + width + " x " + height;
                return;

            }

            if ( copyWidth == true ) {
                int difference = width - bitmap.Width;
                int half = difference / 2;
                g.DrawImage(
                    bitmap,
                    new Rectangle( half, 0, bitmap.Width, bitmap.Height ),
                    new Rectangle( 0, 0, bitmap.Width, bitmap.Height ),
                    GraphicsUnit.Pixel
                );
            } else {
                int difference = height - bitmap.Height;
                int half = difference / 2;
                g.DrawImage(
                    bitmap,
                    new Rectangle( 0, half, bitmap.Width, bitmap.Height ),
                    new Rectangle( 0, 0, bitmap.Width, bitmap.Height ),
                    GraphicsUnit.Pixel
                );



            }


            pbPreview.Image = newBitmap;
            toolStripStatusLabel.Text = "Ready";

        }

        /// <summary>
        /// Save the new image to a new file or overwrite the old one
        /// </summary>
        /// <param name="FullName"></param>
        private void save ( string FullName = "" ) {
            if ( newBitmap == null ) {
                return;
            }

            if ( FullName == "" ) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = GetImageFilter();

                if ( sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {
                    fileName_path = sfd.FileName;


                } else {
                    return;

                }
            }

            bitmap.Dispose();
            newBitmap.Save( fileName_path );

        }

        /// <summary>
        /// Get the color from the clicked pixel of the image
        /// </summary>
        private void getColorAutomatic () {
            Dictionary<Color?, int> colors = new Dictionary<Color?, int>();
            Color? c = null;
            int count = 0;

            if ( copyWidth == true ) {
                for ( int i = 0; i < bitmap.Height; i++ ) {
                    c = bitmap.GetPixel( 0, i );
                    colors.TryGetValue( c, out count );
                    colors[c] = ++count;

                    c = bitmap.GetPixel( bitmap.Width - 1, i );
                    colors.TryGetValue( c, out count );
                    colors[c] = ++count;
                }



            } else {
                for ( int i = 0; i < bitmap.Width; i++ ) {
                    c = bitmap.GetPixel( i, 0 );
                    colors.TryGetValue( c, out count );
                    colors[c] = ++count;

                    c = bitmap.GetPixel( i, bitmap.Height - 1 );
                    colors.TryGetValue( c, out count );
                    colors[c] = ++count;
                }


            }

            // Gets the biggest value in the dictionary
            this.color = ( Color ) colors.Aggregate( ( l, r ) => l.Value > r.Value ? l : r ).Key;
            lblColorPreview.BackColor = this.color;


        }

        /// <summary>
        /// Get the Greatest Common Devisor (GCD) for two numbers
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Returns the GCD</returns>
        private int getGCD ( int a, int b ) {
            return ( b == 0 ) ? a : getGCD( b, a % b );

        }


    }
}