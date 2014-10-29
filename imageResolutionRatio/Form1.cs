using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageResolutionRatio {
    public partial class Form1 : Form {
        Bitmap bitmap;
        bool copyWidth;
        int numToCopy;
        public Form1 () {
            InitializeComponent();
            bitmap = null;
            copyWidth = false;
            numToCopy = 0;
            Icon = global::imageResolutionRatio.Properties.Resources.imageRatioIcon;
        }

        private void button1_Click ( object sender, EventArgs e ) {
            Environment.Exit( Environment.ExitCode );
        }

        private void button2_Click ( object sender, EventArgs e ) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = GetImageFilter();

            if ( ofd.ShowDialog() == DialogResult.OK ) {
                bitmap = new Bitmap( ofd.FileName );
                lblImageResolution.Text = bitmap.Width + " x " + bitmap.Height;

                calculateImageStuff();

            }

        }

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

        private void calculateImageStuff () {
            int height = 0;
            int width = 0;
            int ratioWidth = 0;
            int ratioHeight = 0;
            float imageRatio = 0;
            float ratio = 0;

            if ( bitmap != null ) {
                ratioWidth = int.Parse( txtRatioWidth.Text );
                ratioHeight = int.Parse( txtRatioHeight.Text );
                ratio = ( float ) ratioWidth / ( float ) ratioHeight;
                imageRatio = ( float ) bitmap.Width / ( float ) bitmap.Height;

                if ( imageRatio < ratio ) {
                    width = ( int ) ( bitmap.Height * ratio );
                    lblNewImageResolution.Text = width + " x " + bitmap.Height;
                    numToCopy = width;
                    copyWidth = true;

                } else {
                    ratio = ( float ) ratioHeight / ( float ) ratioWidth;
                    height = ( int ) ( bitmap.Width * ratio );
                    lblNewImageResolution.Text = bitmap.Width + " x " + height;
                    numToCopy = height;
                    copyWidth = false;

                }

            }

            if ( copyWidth == true ) {
                toolTip1.SetToolTip( lblNewImageResolution, "Click to copy new width to clipboard" );

            } else {
                toolTip1.SetToolTip( lblNewImageResolution, "Click to copy new height to clipboard" );

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

        private void txtRatioHeight_TextChanged ( object sender, EventArgs e ) {
            calculate();
            calculateImageStuff();

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

        


    }
}
