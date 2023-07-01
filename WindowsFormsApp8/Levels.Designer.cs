namespace WindowsFormsApp8
{
    partial class Levels
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
            this.level4 = new System.Windows.Forms.Button();
            this.level5 = new System.Windows.Forms.Button();
            this.level6 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // level4
            // 
            this.level4.Location = new System.Drawing.Point(546, 600);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(183, 237);
            this.level4.TabIndex = 5;
            this.level4.Text = "Level 4";
            this.level4.UseVisualStyleBackColor = true;
            this.level4.Click += new System.EventHandler(this.level4_Click);
            // 
            // level5
            // 
            this.level5.Location = new System.Drawing.Point(961, 678);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(183, 159);
            this.level5.TabIndex = 4;
            this.level5.Text = "Level 5";
            this.level5.UseVisualStyleBackColor = true;
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // level6
            // 
            this.level6.Location = new System.Drawing.Point(1077, 370);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(183, 223);
            this.level6.TabIndex = 3;
            this.level6.Text = "Level 6";
            this.level6.UseVisualStyleBackColor = true;
            this.level6.Click += new System.EventHandler(this.level6_Click);
            // 
            // level2
            // 
            this.level2.Location = new System.Drawing.Point(140, 370);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(183, 173);
            this.level2.TabIndex = 2;
            this.level2.Text = "Level 2";
            this.level2.UseVisualStyleBackColor = true;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.Location = new System.Drawing.Point(480, 333);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(183, 194);
            this.level3.TabIndex = 1;
            this.level3.Text = "Level 3";
            this.level3.UseVisualStyleBackColor = true;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // level1
            // 
            this.level1.Location = new System.Drawing.Point(113, 619);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(210, 195);
            this.level1.TabIndex = 0;
            this.level1.Text = "Level 1";
            this.level1.UseVisualStyleBackColor = true;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.LevelsBG;
            this.pictureBox1.Location = new System.Drawing.Point(-22, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1616, 1005);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 849);
            this.Controls.Add(this.level4);
            this.Controls.Add(this.level5);
            this.Controls.Add(this.level6);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Levels";
            this.Text = "Levels";
            this.Load += new System.EventHandler(this.Levels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button level3;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button level6;
        private System.Windows.Forms.Button level5;
        private System.Windows.Forms.Button level4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}