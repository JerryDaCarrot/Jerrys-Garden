﻿namespace WindowsFormsApp8
{
    partial class Corn_Seeds
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
            this.exit = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.Corn;
            this.pictureBox1.Location = new System.Drawing.Point(828, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1116, 26);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(144, 71);
            this.exit.TabIndex = 12;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(1116, 760);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(144, 98);
            this.right.TabIndex = 11;
            this.right.Text = "->";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(192, 771);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(144, 98);
            this.left.TabIndex = 10;
            this.left.Text = "<-";
            this.left.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(225, 84);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(535, 627);
            this.Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Information.TabIndex = 9;
            this.Information.TabStop = false;
            // 
            // Corn_Seeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 894);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.Information);
            this.Name = "Corn_Seeds";
            this.Text = "Corn_Seeds";
            this.Load += new System.EventHandler(this.Corn_Seeds_Load);
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