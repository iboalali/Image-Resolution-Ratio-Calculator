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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(141, 12);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(141, 38);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ratio";
            // 
            // lblSideLength
            // 
            this.lblSideLength.Location = new System.Drawing.Point(138, 90);
            this.lblSideLength.Name = "lblSideLength";
            this.lblSideLength.Size = new System.Drawing.Size(103, 13);
            this.lblSideLength.TabIndex = 10;
            this.lblSideLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblSideLength, "Click to Copy the Number");
            this.lblSideLength.Click += new System.EventHandler(this.lblSideLength_Click);
            // 
            // txtRatioHeight
            // 
            this.txtRatioHeight.Location = new System.Drawing.Point(200, 64);
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
            this.txtRatioWidth.Location = new System.Drawing.Point(141, 64);
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
            this.label4.Location = new System.Drawing.Point(186, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(12, 90);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(0, 13);
            this.lblSide.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Image Resolution";
            // 
            // lblImageResolution
            // 
            this.lblImageResolution.Location = new System.Drawing.Point(141, 109);
            this.lblImageResolution.Name = "lblImageResolution";
            this.lblImageResolution.Size = new System.Drawing.Size(100, 13);
            this.lblImageResolution.TabIndex = 12;
            this.lblImageResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewImageResolution
            // 
            this.lblNewImageResolution.Location = new System.Drawing.Point(141, 128);
            this.lblNewImageResolution.Name = "lblNewImageResolution";
            this.lblNewImageResolution.Size = new System.Drawing.Size(100, 13);
            this.lblNewImageResolution.TabIndex = 14;
            this.lblNewImageResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewImageResolution.Click += new System.EventHandler(this.lblSideLength_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Image Resolution";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 191);
            this.Controls.Add(this.lblNewImageResolution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblImageResolution);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRatioWidth);
            this.Controls.Add(this.txtRatioHeight);
            this.Controls.Add(this.lblSideLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Ratio";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}

