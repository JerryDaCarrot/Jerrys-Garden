namespace WindowsFormsApp8
{
    partial class Cucumber_Seeds
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
            this.exit = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1031, 16);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(144, 71);
            this.exit.TabIndex = 12;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(1031, 750);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(144, 98);
            this.right.TabIndex = 11;
            this.right.Text = "->";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(107, 761);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(144, 98);
            this.left.TabIndex = 10;
            this.left.Text = "<-";
            this.left.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Cucumber;
            this.pictureBox1.Location = new System.Drawing.Point(741, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(138, 77);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(535, 627);
            this.Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Information.TabIndex = 9;
            this.Information.TabStop = false;
            // 
            // Cucumber_Seeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 877);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.Information);
            this.Name = "Cucumber_Seeds";
            this.Text = "Cucumber_Seeds";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.PictureBox Information;
    }
}