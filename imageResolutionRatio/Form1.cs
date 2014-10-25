using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageResolutionRatio {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
            Icon = global::imageResolutionRatio.Properties.Resources.imageRatioIcon;
        }

        private void button1_Click ( object sender, EventArgs e ) {
            Environment.Exit( Environment.ExitCode );
        }

        private void button2_Click ( object sender, EventArgs e ) {
            calculate();
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

    }
}
