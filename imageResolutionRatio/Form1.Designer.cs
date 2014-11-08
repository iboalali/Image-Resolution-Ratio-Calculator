namespace imageResolutionRatio {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSideLength = new System.Windows.Forms.Label();
            this.txtRatioHeight = new System.Windows.Forms.TextBox();
            this.txtRatioWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblImageResolution = new System.Windows.Forms.Label();
            this.lblNewImageResolution = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImageRatioHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImageRatioWidth = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rbAutomatic = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblColorPreview = new System.Windows.Forms.Label();
            this.rbFromImage = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(502, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImage.Location = new System.Drawing.Point(421, 317);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 10;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(152, 15);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(152, 41);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ratio";
            // 
            // lblSideLength
            // 
            this.lblSideLength.Location = new System.Drawing.Point(149, 93);
            this.lblSideLength.Name = "lblSideLength";
            this.lblSideLength.Size = new System.Drawing.Size(103, 20);
            this.lblSideLength.TabIndex = 10;
            this.lblSideLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblSideLength, "Click to Copy the Number");
            this.lblSideLength.Click += new System.EventHandler(this.lblSideLength_Click);
            // 
            // txtRatioHeight
            // 
            this.txtRatioHeight.Location = new System.Drawing.Point(211, 67);
            this.txtRatioHeight.Name = "txtRatioHeight";
            this.txtRatioHeight.Size = new System.Drawing.Size(41, 20);
            this.txtRatioHeight.TabIndex = 3;
            this.txtRatioHeight.Text = "9";
            this.txtRatioHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRatioHeight.TextChanged += new System.EventHandler(this.txtRatioHeight_TextChanged);
            this.txtRatioHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtRatioWidth
            // 
            this.txtRatioWidth.Location = new System.Drawing.Point(152, 67);
            this.txtRatioWidth.Name = "txtRatioWidth";
            this.txtRatioWidth.Size = new System.Drawing.Size(41, 20);
            this.txtRatioWidth.TabIndex = 2;
            this.txtRatioWidth.Text = "16";
            this.txtRatioWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRatioWidth.TextChanged += new System.EventHandler(this.txtRatioHeight_TextChanged);
            this.txtRatioWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(197, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSide
            // 
            this.lblSide.Location = new System.Drawing.Point(23, 93);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(120, 20);
            this.lblSide.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Image Resolution";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImageResolution
            // 
            this.lblImageResolution.Location = new System.Drawing.Point(165, 192);
            this.lblImageResolution.Name = "lblImageResolution";
            this.lblImageResolution.Size = new System.Drawing.Size(100, 20);
            this.lblImageResolution.TabIndex = 12;
            this.lblImageResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewImageResolution
            // 
            this.lblNewImageResolution.Location = new System.Drawing.Point(165, 212);
            this.lblNewImageResolution.Name = "lblNewImageResolution";
            this.lblNewImageResolution.Size = new System.Drawing.Size(100, 20);
            this.lblNewImageResolution.TabIndex = 14;
            this.lblNewImageResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewImageResolution.Click += new System.EventHandler(this.lblSideLength_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(36, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Image Resolution";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(297, 31);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(280, 280);
            this.pbPreview.TabIndex = 15;
            this.pbPreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSideLength);
            this.panel1.Controls.Add(this.lblSide);
            this.panel1.Controls.Add(this.txtRatioHeight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRatioWidth);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 132);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ratio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImageRatioHeight
            // 
            this.txtImageRatioHeight.Location = new System.Drawing.Point(224, 169);
            this.txtImageRatioHeight.MaxLength = 2;
            this.txtImageRatioHeight.Name = "txtImageRatioHeight";
            this.txtImageRatioHeight.Size = new System.Drawing.Size(41, 20);
            this.txtImageRatioHeight.TabIndex = 5;
            this.txtImageRatioHeight.Text = "9";
            this.txtImageRatioHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImageRatioHeight.TextChanged += new System.EventHandler(this.txtRatio_TextChanged);
            this.txtImageRatioHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(210, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = ":";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImageRatioWidth
            // 
            this.txtImageRatioWidth.Location = new System.Drawing.Point(165, 169);
            this.txtImageRatioWidth.MaxLength = 2;
            this.txtImageRatioWidth.Name = "txtImageRatioWidth";
            this.txtImageRatioWidth.Size = new System.Drawing.Size(41, 20);
            this.txtImageRatioWidth.TabIndex = 4;
            this.txtImageRatioWidth.Text = "16";
            this.txtImageRatioWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImageRatioWidth.TextChanged += new System.EventHandler(this.txtRatio_TextChanged);
            this.txtImageRatioWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // rbAutomatic
            // 
            this.rbAutomatic.AutoSize = true;
            this.rbAutomatic.Checked = true;
            this.rbAutomatic.Location = new System.Drawing.Point(6, 21);
            this.rbAutomatic.Name = "rbAutomatic";
            this.rbAutomatic.Size = new System.Drawing.Size(72, 17);
            this.rbAutomatic.TabIndex = 6;
            this.rbAutomatic.TabStop = true;
            this.rbAutomatic.Text = "Automatic";
            this.rbAutomatic.UseVisualStyleBackColor = true;
            this.rbAutomatic.CheckedChanged += new System.EventHandler(this.rbAutomatic_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(6, 67);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 8;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // btnPickColor
            // 
            this.btnPickColor.Enabled = false;
            this.btnPickColor.Location = new System.Drawing.Point(145, 61);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor.TabIndex = 9;
            this.btnPickColor.Text = "Pick Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColorPreview);
            this.groupBox1.Controls.Add(this.rbFromImage);
            this.groupBox1.Controls.Add(this.btnPickColor);
            this.groupBox1.Controls.Add(this.rbAutomatic);
            this.groupBox1.Controls.Add(this.rbManual);
            this.groupBox1.Location = new System.Drawing.Point(39, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 90);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // lblColorPreview
            // 
            this.lblColorPreview.BackColor = System.Drawing.Color.White;
            this.lblColorPreview.Location = new System.Drawing.Point(193, 13);
            this.lblColorPreview.Name = "lblColorPreview";
            this.lblColorPreview.Size = new System.Drawing.Size(25, 25);
            this.lblColorPreview.TabIndex = 25;
            // 
            // rbFromImage
            // 
            this.rbFromImage.AutoSize = true;
            this.rbFromImage.Location = new System.Drawing.Point(6, 44);
            this.rbFromImage.Name = "rbFromImage";
            this.rbFromImage.Size = new System.Drawing.Size(80, 17);
            this.rbFromImage.TabIndex = 7;
            this.rbFromImage.Text = "From Image";
            this.rbFromImage.UseVisualStyleBackColor = true;
            this.rbFromImage.CheckedChanged += new System.EventHandler(this.rbFromImage_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(589, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(589, 370);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtImageRatioHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImageRatioWidth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.lblNewImageResolution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblImageResolution);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(605, 409);
            this.Name = "Form1";
            this.Text = "Image Ratio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSideLength;
        private System.Windows.Forms.TextBox txtRatioHeight;
        private System.Windows.Forms.TextBox txtRatioWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblImageResolution;
        private System.Windows.Forms.Label lblNewImageResolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImageRatioHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImageRatioWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton rbAutomatic;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFromImage;
        private System.Windows.Forms.Label lblColorPreview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

