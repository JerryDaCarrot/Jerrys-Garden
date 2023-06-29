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
            this.jerryRadish = new System.Windows.Forms.PictureBox();
            this.grown = new System.Windows.Forms.PictureBox();
            this.maintain = new System.Windows.Forms.PictureBox();
            this.grow = new System.Windows.Forms.PictureBox();
            this.seeds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).BeginInit();
            this.SuspendLayout();
            // 
            // jerryRadish
            // 
            this.jerryRadish.Location = new System.Drawing.Point(-27, -57);
            this.jerryRadish.Name = "jerryRadish";
            this.jerryRadish.Size = new System.Drawing.Size(95, 156);
            this.jerryRadish.TabIndex = 0;
            this.jerryRadish.TabStop = false;
            // 
            // grown
            // 
            this.grown.Location = new System.Drawing.Point(884, 336);
            this.grown.Name = "grown";
            this.grown.Size = new System.Drawing.Size(139, 74);
            this.grown.TabIndex = 4;
            this.grown.TabStop = false;
            // 
            // maintain
            // 
            this.maintain.Location = new System.Drawing.Point(990, 731);
            this.maintain.Name = "maintain";
            this.maintain.Size = new System.Drawing.Size(139, 74);
            this.maintain.TabIndex = 3;
            this.maintain.TabStop = false;
            // 
            // grow
            // 
            this.grow.Location = new System.Drawing.Point(100, 652);
            this.grow.Name = "grow";
            this.grow.Size = new System.Drawing.Size(139, 74);
            this.grow.TabIndex = 2;
            this.grow.TabStop = false;
            // 
            // seeds
            // 
            this.seeds.ErrorImage = null;
            this.seeds.Image = global::WindowsFormsApp8.Properties.Resources.seedy;
            this.seeds.Location = new System.Drawing.Point(407, 182);
            this.seeds.Name = "seeds";
            this.seeds.Size = new System.Drawing.Size(139, 74);
            this.seeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seeds.TabIndex = 1;
            this.seeds.TabStop = false;
            // 
            // RadishMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 847);
            this.Controls.Add(this.jerryRadish);
            this.Controls.Add(this.grown);
            this.Controls.Add(this.maintain);
            this.Controls.Add(this.grow);
            this.Controls.Add(this.seeds);
            this.Name = "RadishMove";
            this.Text = "RadishMove";
            this.Load += new System.EventHandler(this.RadishMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jerryRadish;
        private System.Windows.Forms.PictureBox seeds;
        private System.Windows.Forms.PictureBox grow;
        private System.Windows.Forms.PictureBox maintain;
        private System.Windows.Forms.PictureBox grown;
    }
}