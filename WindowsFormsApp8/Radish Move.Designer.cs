﻿namespace WindowsFormsApp8
{
    partial class Radish_Move
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radish_Move));
            this.button1 = new System.Windows.Forms.Button();
            this.JerryRadish = new System.Windows.Forms.PictureBox();
            this.RadishSeeds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.JerryRadish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadishSeeds)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 10);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JerryRadish
            // 
            this.JerryRadish.Image = ((System.Drawing.Image)(resources.GetObject("JerryRadish.Image")));
            this.JerryRadish.Location = new System.Drawing.Point(121, 131);
            this.JerryRadish.Name = "JerryRadish";
            this.JerryRadish.Size = new System.Drawing.Size(127, 173);
            this.JerryRadish.TabIndex = 1;
            this.JerryRadish.TabStop = false;
            this.JerryRadish.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyDown);
            // 
            // RadishSeeds
            // 
            this.RadishSeeds.Image = ((System.Drawing.Image)(resources.GetObject("RadishSeeds.Image")));
            this.RadishSeeds.Location = new System.Drawing.Point(408, 101);
            this.RadishSeeds.Name = "RadishSeeds";
            this.RadishSeeds.Size = new System.Drawing.Size(68, 52);
            this.RadishSeeds.TabIndex = 2;
            this.RadishSeeds.TabStop = false;
            // 
            // Radish_Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 871);
            this.Controls.Add(this.RadishSeeds);
            this.Controls.Add(this.JerryRadish);
            this.Controls.Add(this.button1);
            this.Name = "Radish_Move";
            this.Text = "Radish_Move";
            ((System.ComponentModel.ISupportInitialize)(this.JerryRadish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadishSeeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox JerryRadish;
        private System.Windows.Forms.PictureBox RadishSeeds;
    }
}