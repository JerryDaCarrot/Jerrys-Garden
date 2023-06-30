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
            this.grown = new System.Windows.Forms.PictureBox();
            this.maintain = new System.Windows.Forms.PictureBox();
            this.grow = new System.Windows.Forms.PictureBox();
            this.seeds = new System.Windows.Forms.PictureBox();
            this.jerryRadish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).BeginInit();
            this.SuspendLayout();
            // 
            // grown
            // 
            this.grown.Image = global::WindowsFormsApp8.Properties.Resources.Grown;
            this.grown.Location = new System.Drawing.Point(884, 336);
            this.grown.Name = "grown";
            this.grown.Size = new System.Drawing.Size(139, 167);
            this.grown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grown.TabIndex = 4;
            this.grown.TabStop = false;
            this.grown.Visible = false;
            // 
            // maintain
            // 
            this.maintain.Image = global::WindowsFormsApp8.Properties.Resources.Maintain;
            this.maintain.Location = new System.Drawing.Point(953, 626);
            this.maintain.Name = "maintain";
            this.maintain.Size = new System.Drawing.Size(139, 167);
            this.maintain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maintain.TabIndex = 3;
            this.maintain.TabStop = false;
            this.maintain.Visible = false;
            // 
            // grow
            // 
            this.grow.Image = global::WindowsFormsApp8.Properties.Resources.Grow;
            this.grow.Location = new System.Drawing.Point(146, 500);
            this.grow.Name = "grow";
            this.grow.Size = new System.Drawing.Size(182, 167);
            this.grow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grow.TabIndex = 2;
            this.grow.TabStop = false;
            this.grow.Visible = false;
            // 
            // seeds
            // 
            this.seeds.ErrorImage = null;
            this.seeds.Image = global::WindowsFormsApp8.Properties.Resources.Seeds;
            this.seeds.Location = new System.Drawing.Point(407, 182);
            this.seeds.Name = "seeds";
            this.seeds.Size = new System.Drawing.Size(139, 167);
            this.seeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seeds.TabIndex = 1;
            this.seeds.TabStop = false;
            this.seeds.Visible = false;
            // 
            // jerryRadish
            // 
            this.jerryRadish.Location = new System.Drawing.Point(-27, -57);
            this.jerryRadish.Name = "jerryRadish";
            this.jerryRadish.Size = new System.Drawing.Size(95, 156);
            this.jerryRadish.TabIndex = 0;
            this.jerryRadish.TabStop = false;
            // 
            // RadishMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 847);
            this.Controls.Add(this.seeds);
            this.Controls.Add(this.grown);
            this.Controls.Add(this.maintain);
            this.Controls.Add(this.grow);
            this.Controls.Add(this.jerryRadish);
            this.Name = "RadishMove";
            this.Text = "RadishMove";
            this.Load += new System.EventHandler(this.RadishMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jerryRadish;
        public System.Windows.Forms.PictureBox seeds;
        public System.Windows.Forms.PictureBox grow;
        public System.Windows.Forms.PictureBox maintain;
        public System.Windows.Forms.PictureBox grown;
    }
}