using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageResolutionRatio {
    public partial class AboutForm : Form {
        public AboutForm () {
            InitializeComponent();
            LinkLabel.Link linkLicense = new LinkLabel.Link();
            linkLicense.LinkData = "http://www.apache.org/licenses/LICENSE-2.0";
            linkLabelLicense.Links.Add( linkLicense );

            LinkLabel.Link linkEmail = new LinkLabel.Link();
            linkEmail.LinkData = "mailto:iboalali@gmail.com";
            linkLabelEmail.Links.Add( linkEmail );

            LinkLabel.Link linkPage = new LinkLabel.Link();
            linkPage.LinkData = "http://iboalali.com";
            linkLabelPage.Links.Add( linkPage );
        }

        private void btnClose_Click ( object sender, EventArgs e ) {
            this.Close();
        }

        private void linkLabel_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e ) {
            Process.Start( e.Link.LinkData as string );
        }

    }
}
