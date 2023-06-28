namespace WindowsFormsApp8
{
    partial class RadishMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadishMove));
            this.jerryRadish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).BeginInit();
            this.SuspendLayout();
            // 
            // jerryRadish
            // 
            this.jerryRadish.Image = ((System.Drawing.Image)(resources.GetObject("jerryRadish.Image")));
            this.jerryRadish.Location = new System.Drawing.Point(72, 168);
            this.jerryRadish.Name = "jerryRadish";
            this.jerryRadish.Size = new System.Drawing.Size(326, 456);
            this.jerryRadish.TabIndex = 0;
            this.jerryRadish.TabStop = false;
            // 
            // RadishMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 847);
            this.Controls.Add(this.jerryRadish);
            this.Name = "RadishMove";
            this.Text = "RadishMove";
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jerryRadish;
    }
}