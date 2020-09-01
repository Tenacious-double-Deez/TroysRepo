namespace RecipeProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLink = new System.Windows.Forms.LinkLabel();
            this.ChickenBox = new System.Windows.Forms.PictureBox();
            this.BeefBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SeafoodBox1 = new System.Windows.Forms.PictureBox();
            this.ChickenLink = new System.Windows.Forms.LinkLabel();
            this.PorkLink = new System.Windows.Forms.LinkLabel();
            this.BeefLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SampleTextBody = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeefBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeafoodBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.HeaderPanel.Controls.Add(this.HeaderLink);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1405, 123);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLink
            // 
            this.HeaderLink.AutoSize = true;
            this.HeaderLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLink.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeaderLink.Location = new System.Drawing.Point(428, 32);
            this.HeaderLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLink.Name = "HeaderLink";
            this.HeaderLink.Size = new System.Drawing.Size(678, 48);
            this.HeaderLink.TabIndex = 13;
            this.HeaderLink.TabStop = true;
            this.HeaderLink.Text = "Header Link, links back to homepage";
            this.HeaderLink.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // ChickenBox
            // 
            this.ChickenBox.Image = ((System.Drawing.Image)(resources.GetObject("ChickenBox.Image")));
            this.ChickenBox.Location = new System.Drawing.Point(85, 130);
            this.ChickenBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChickenBox.Name = "ChickenBox";
            this.ChickenBox.Size = new System.Drawing.Size(160, 98);
            this.ChickenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChickenBox.TabIndex = 1;
            this.ChickenBox.TabStop = false;
            this.ChickenBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BeefBox
            // 
            this.BeefBox.Image = ((System.Drawing.Image)(resources.GetObject("BeefBox.Image")));
            this.BeefBox.Location = new System.Drawing.Point(591, 130);
            this.BeefBox.Margin = new System.Windows.Forms.Padding(4);
            this.BeefBox.Name = "BeefBox";
            this.BeefBox.Size = new System.Drawing.Size(179, 98);
            this.BeefBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BeefBox.TabIndex = 4;
            this.BeefBox.TabStop = false;
            this.BeefBox.Click += new System.EventHandler(this.BeefBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(320, 130);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SeafoodBox1
            // 
            this.SeafoodBox1.Image = ((System.Drawing.Image)(resources.GetObject("SeafoodBox1.Image")));
            this.SeafoodBox1.Location = new System.Drawing.Point(872, 132);
            this.SeafoodBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SeafoodBox1.Name = "SeafoodBox1";
            this.SeafoodBox1.Size = new System.Drawing.Size(181, 97);
            this.SeafoodBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeafoodBox1.TabIndex = 6;
            this.SeafoodBox1.TabStop = false;
            // 
            // ChickenLink
            // 
            this.ChickenLink.AutoSize = true;
            this.ChickenLink.BackColor = System.Drawing.Color.White;
            this.ChickenLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChickenLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChickenLink.ForeColor = System.Drawing.Color.Transparent;
            this.ChickenLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ChickenLink.LinkColor = System.Drawing.Color.Black;
            this.ChickenLink.Location = new System.Drawing.Point(180, 204);
            this.ChickenLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChickenLink.Name = "ChickenLink";
            this.ChickenLink.Size = new System.Drawing.Size(84, 25);
            this.ChickenLink.TabIndex = 7;
            this.ChickenLink.TabStop = true;
            this.ChickenLink.Text = "Chicken";
            this.ChickenLink.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // PorkLink
            // 
            this.PorkLink.AutoSize = true;
            this.PorkLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorkLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.PorkLink.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PorkLink.Location = new System.Drawing.Point(449, 204);
            this.PorkLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PorkLink.Name = "PorkLink";
            this.PorkLink.Size = new System.Drawing.Size(52, 25);
            this.PorkLink.TabIndex = 8;
            this.PorkLink.TabStop = true;
            this.PorkLink.Text = "Pork";
            this.PorkLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.PorkLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PorkLink_LinkClicked);
            // 
            // BeefLink
            // 
            this.BeefLink.AutoSize = true;
            this.BeefLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeefLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.BeefLink.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BeefLink.Location = new System.Drawing.Point(727, 204);
            this.BeefLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BeefLink.Name = "BeefLink";
            this.BeefLink.Size = new System.Drawing.Size(52, 25);
            this.BeefLink.TabIndex = 9;
            this.BeefLink.TabStop = true;
            this.BeefLink.Text = "Beef";
            this.BeefLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.BeefLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BeefLink_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel4.Location = new System.Drawing.Point(988, 206);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(86, 25);
            this.linkLabel4.TabIndex = 10;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Seafood";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1144, 130);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(1225, 198);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 25);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Non-meat";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // SampleTextBody
            // 
            this.SampleTextBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleTextBody.Location = new System.Drawing.Point(85, 283);
            this.SampleTextBody.Margin = new System.Windows.Forms.Padding(4);
            this.SampleTextBody.Name = "SampleTextBody";
            this.SampleTextBody.Size = new System.Drawing.Size(1188, 184);
            this.SampleTextBody.TabIndex = 13;
            this.SampleTextBody.Text = resources.GetString("SampleTextBody.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 123);
            this.panel1.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.Location = new System.Drawing.Point(428, 32);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(831, 48);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Footer, maybe links to about, contact, etc, etc\r\n";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SampleTextBody);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.BeefLink);
            this.Controls.Add(this.PorkLink);
            this.Controls.Add(this.ChickenLink);
            this.Controls.Add(this.SeafoodBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BeefBox);
            this.Controls.Add(this.ChickenBox);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeefBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeafoodBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox ChickenBox;
        private System.Windows.Forms.PictureBox BeefBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox SeafoodBox1;
        private System.Windows.Forms.LinkLabel ChickenLink;
        private System.Windows.Forms.LinkLabel PorkLink;
        private System.Windows.Forms.LinkLabel BeefLink;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel HeaderLink;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox SampleTextBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

