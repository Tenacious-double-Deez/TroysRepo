namespace RecipeProject
{
    partial class BeefForm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.servingYieldLabel = new System.Windows.Forms.Label();
            this.cookTimeLabel = new System.Windows.Forms.Label();
            this.prepTimeLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.recipeIngredientText = new System.Windows.Forms.RichTextBox();
            this.recipeInstructionText = new System.Windows.Forms.RichTextBox();
            this.beefButton1 = new System.Windows.Forms.Button();
            this.beefButton4 = new System.Windows.Forms.Button();
            this.beefButton3 = new System.Windows.Forms.Button();
            this.beefButton5 = new System.Windows.Forms.Button();
            this.beefButton2 = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Peru;
            this.HeaderPanel.Controls.Add(this.servingYieldLabel);
            this.HeaderPanel.Controls.Add(this.cookTimeLabel);
            this.HeaderPanel.Controls.Add(this.prepTimeLabel);
            this.HeaderPanel.Controls.Add(this.recipeNameLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1405, 123);
            this.HeaderPanel.TabIndex = 0;
            // 
            // servingYieldLabel
            // 
            this.servingYieldLabel.AutoSize = true;
            this.servingYieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingYieldLabel.Location = new System.Drawing.Point(1038, 81);
            this.servingYieldLabel.Name = "servingYieldLabel";
            this.servingYieldLabel.Size = new System.Drawing.Size(134, 32);
            this.servingYieldLabel.TabIndex = 20;
            this.servingYieldLabel.Text = "Servings:";
            this.servingYieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cookTimeLabel
            // 
            this.cookTimeLabel.AutoSize = true;
            this.cookTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookTimeLabel.Location = new System.Drawing.Point(607, 81);
            this.cookTimeLabel.Name = "cookTimeLabel";
            this.cookTimeLabel.Size = new System.Drawing.Size(159, 32);
            this.cookTimeLabel.TabIndex = 19;
            this.cookTimeLabel.Text = "Cook Time:";
            this.cookTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prepTimeLabel
            // 
            this.prepTimeLabel.AutoSize = true;
            this.prepTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeLabel.Location = new System.Drawing.Point(3, 81);
            this.prepTimeLabel.Name = "prepTimeLabel";
            this.prepTimeLabel.Size = new System.Drawing.Size(153, 32);
            this.prepTimeLabel.TabIndex = 18;
            this.prepTimeLabel.Text = "Prep Time:";
            this.prepTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameLabel.Location = new System.Drawing.Point(605, 9);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(273, 46);
            this.recipeNameLabel.TabIndex = 17;
            this.recipeNameLabel.Text = "Recipe Name";
            this.recipeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipeIngredientText
            // 
            this.recipeIngredientText.BackColor = System.Drawing.Color.White;
            this.recipeIngredientText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeIngredientText.Location = new System.Drawing.Point(13, 200);
            this.recipeIngredientText.Margin = new System.Windows.Forms.Padding(4);
            this.recipeIngredientText.Name = "recipeIngredientText";
            this.recipeIngredientText.ReadOnly = true;
            this.recipeIngredientText.Size = new System.Drawing.Size(707, 405);
            this.recipeIngredientText.TabIndex = 15;
            this.recipeIngredientText.Text = "";
            // 
            // recipeInstructionText
            // 
            this.recipeInstructionText.BackColor = System.Drawing.Color.White;
            this.recipeInstructionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeInstructionText.Location = new System.Drawing.Point(746, 200);
            this.recipeInstructionText.Margin = new System.Windows.Forms.Padding(4);
            this.recipeInstructionText.Name = "recipeInstructionText";
            this.recipeInstructionText.ReadOnly = true;
            this.recipeInstructionText.Size = new System.Drawing.Size(646, 405);
            this.recipeInstructionText.TabIndex = 16;
            this.recipeInstructionText.Text = "";
            // 
            // beefButton1
            // 
            this.beefButton1.BackColor = System.Drawing.Color.Peru;
            this.beefButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beefButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beefButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beefButton1.Location = new System.Drawing.Point(13, 130);
            this.beefButton1.Name = "beefButton1";
            this.beefButton1.Size = new System.Drawing.Size(160, 63);
            this.beefButton1.TabIndex = 17;
            this.beefButton1.Text = "Beef Satay";
            this.beefButton1.UseVisualStyleBackColor = false;
            this.beefButton1.Click += new System.EventHandler(this.beefButton1_Click);
            // 
            // beefButton4
            // 
            this.beefButton4.BackColor = System.Drawing.Color.Peru;
            this.beefButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beefButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beefButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beefButton4.Location = new System.Drawing.Point(945, 130);
            this.beefButton4.Name = "beefButton4";
            this.beefButton4.Size = new System.Drawing.Size(181, 63);
            this.beefButton4.TabIndex = 18;
            this.beefButton4.Text = "Beef Enchiladas";
            this.beefButton4.UseVisualStyleBackColor = false;
            this.beefButton4.Click += new System.EventHandler(this.beefButton4_Click);
            // 
            // beefButton3
            // 
            this.beefButton3.BackColor = System.Drawing.Color.Peru;
            this.beefButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beefButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beefButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beefButton3.Location = new System.Drawing.Point(641, 130);
            this.beefButton3.Name = "beefButton3";
            this.beefButton3.Size = new System.Drawing.Size(179, 63);
            this.beefButton3.TabIndex = 19;
            this.beefButton3.Text = "Beef Stroganoff";
            this.beefButton3.UseVisualStyleBackColor = false;
            this.beefButton3.Click += new System.EventHandler(this.beefButton3_Click);
            // 
            // beefButton5
            // 
            this.beefButton5.BackColor = System.Drawing.Color.Peru;
            this.beefButton5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beefButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beefButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beefButton5.Location = new System.Drawing.Point(1234, 130);
            this.beefButton5.Name = "beefButton5";
            this.beefButton5.Size = new System.Drawing.Size(159, 63);
            this.beefButton5.TabIndex = 20;
            this.beefButton5.Text = "Beef Stew";
            this.beefButton5.UseVisualStyleBackColor = false;
            this.beefButton5.Click += new System.EventHandler(this.beefButton5_Click);
            // 
            // beefButton2
            // 
            this.beefButton2.BackColor = System.Drawing.Color.Peru;
            this.beefButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beefButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beefButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beefButton2.Location = new System.Drawing.Point(317, 130);
            this.beefButton2.Name = "beefButton2";
            this.beefButton2.Size = new System.Drawing.Size(172, 63);
            this.beefButton2.TabIndex = 21;
            this.beefButton2.Text = "Beef Casserole";
            this.beefButton2.UseVisualStyleBackColor = false;
            this.beefButton2.Click += new System.EventHandler(this.beefButton2_Click);
            // 
            // BeefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1405, 618);
            this.Controls.Add(this.beefButton2);
            this.Controls.Add(this.beefButton5);
            this.Controls.Add(this.beefButton3);
            this.Controls.Add(this.beefButton4);
            this.Controls.Add(this.beefButton1);
            this.Controls.Add(this.recipeInstructionText);
            this.Controls.Add(this.recipeIngredientText);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BeefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeefForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.RichTextBox recipeIngredientText;
        private System.Windows.Forms.RichTextBox recipeInstructionText;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.Button beefButton1;
        private System.Windows.Forms.Button beefButton4;
        private System.Windows.Forms.Button beefButton3;
        private System.Windows.Forms.Button beefButton5;
        private System.Windows.Forms.Button beefButton2;
        private System.Windows.Forms.Label servingYieldLabel;
        private System.Windows.Forms.Label cookTimeLabel;
        private System.Windows.Forms.Label prepTimeLabel;
    }
}

