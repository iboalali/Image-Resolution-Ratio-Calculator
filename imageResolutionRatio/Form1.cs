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
        public Form1 () {
            InitializeComponent();
            bitmap = null;
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
            if ( txtHeight.Text == string.Empty && txtWidth.Text == string.Empty ) {
                //MessageBox.Show( "Please input a height or width", "Empty Text Box" );
                return;

            }

            if ( txtRatioHeight.Text == string.Empty || txtRatioWidth.Text == string.Empty ) {
                return;

            }

            if ( txtHeight.Text != string.Empty && txtWidth.Text != string.Empty ) {
                //MessageBox.Show( "Please input only one of them", "Too Many" );
                return;

            }

            int height = 0;
            int width = 0;
            int ratioWidth = 0;
            int ratioHeight = 0;
            float ratio = 0;

            if ( txtHeight.Text != string.Empty ) {
                height = int.Parse( txtHeight.Text );
                ratioWidth = int.Parse( txtRatioWidth.Text );
                ratioHeight = int.Parse( txtRatioHeight.Text );
                ratio = ( float ) ratioWidth / ( float ) ratioHeight;

                width = ( int ) ( height * ratio );
                lblSide.Text = "Width";
                lblSideLength.Text = width.ToString();
            }

            if ( txtWidth.Text != string.Empty ) {
                width = int.Parse( txtWidth.Text );
                ratioWidth = int.Parse( txtRatioWidth.Text );
                ratioHeight = int.Parse( txtRatioHeight.Text );
                ratio = ( float ) ratioHeight / ( float ) ratioWidth;

                height = ( int ) ( width * ratio );
                lblSide.Text = "Height";
                lblSideLength.Text = height.ToString();
            }

        }

        private void calculateImageStuff () {
            int height = 0;
            int width = 0;
            int ratioWidth = 0;
            int ratioHeight = 0;
            float ratio = 0;

            if ( bitmap != null ) {
                if ( bitmap.Height < bitmap.Width ) {
                    ratioWidth = int.Parse( txtRatioWidth.Text );
                    ratioHeight = int.Parse( txtRatioHeight.Text );
                    ratio = ( float ) ratioWidth / ( float ) ratioHeight;

                    width = ( int ) ( bitmap.Height * ratio );
                    lblNewImageResolution.Text = width + " x " + bitmap.Height;

                } else {
                    ratioWidth = int.Parse( txtRatioWidth.Text );
                    ratioHeight = int.Parse( txtRatioHeight.Text );
                    ratio = ( float ) ratioHeight / ( float ) ratioWidth;

                    height = ( int ) ( bitmap.Width * ratio );
                    lblSide.Text = "Height";
                    lblNewImageResolution.Text = bitmap.Width + " x " + height;

                }
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
            Clipboard.SetText( lblSideLength.Text );
        }

        public string GetImageFilter () {
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


    }
}
