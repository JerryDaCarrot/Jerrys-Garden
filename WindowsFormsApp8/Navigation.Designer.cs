namespace WindowsFormsApp8
{
    partial class Navigation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Carrot = new System.Windows.Forms.Button();
            this.Radish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1309, 879);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Carrot
            // 
            this.Carrot.Location = new System.Drawing.Point(97, 73);
            this.Carrot.Name = "Carrot";
            this.Carrot.Size = new System.Drawing.Size(160, 88);
            this.Carrot.TabIndex = 1;
            this.Carrot.Text = "Carrot";
            this.Carrot.UseVisualStyleBackColor = true;
            // 
            // Radish
            // 
            this.Radish.Location = new System.Drawing.Point(574, 394);
            this.Radish.Name = "Radish";
            this.Radish.Size = new System.Drawing.Size(160, 88);
            this.Radish.TabIndex = 2;
            this.Radish.Text = "Radish";
            this.Radish.UseVisualStyleBackColor = true;
            this.Radish.Click += new System.EventHandler(this.Radish_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 876);
            this.Controls.Add(this.Radish);
            this.Controls.Add(this.Carrot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.Navigation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Carrot;
        private System.Windows.Forms.Button Radish;
    }
}