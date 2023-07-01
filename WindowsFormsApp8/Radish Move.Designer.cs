namespace WindowsFormsApp8
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
            this.jerryRadish = new System.Windows.Forms.PictureBox();
            this.seeds = new System.Windows.Forms.PictureBox();
            this.grown = new System.Windows.Forms.PictureBox();
            this.maintain = new System.Windows.Forms.PictureBox();
            this.grow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).BeginInit();
            this.SuspendLayout();
            // 
            // jerryRadish
            // 
            this.jerryRadish.Location = new System.Drawing.Point(34, -169);
            this.jerryRadish.Name = "jerryRadish";
            this.jerryRadish.Size = new System.Drawing.Size(51, 22);
            this.jerryRadish.TabIndex = 11;
            this.jerryRadish.TabStop = false;
            // 
            // seeds
            // 
            this.seeds.ErrorImage = null;
            this.seeds.Image = global::WindowsFormsApp8.Properties.Resources.Seeds;
            this.seeds.Location = new System.Drawing.Point(584, 108);
            this.seeds.Name = "seeds";
            this.seeds.Size = new System.Drawing.Size(139, 167);
            this.seeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seeds.TabIndex = 7;
            this.seeds.TabStop = false;
            // 
            // grown
            // 
            this.grown.Image = global::WindowsFormsApp8.Properties.Resources.Grown;
            this.grown.Location = new System.Drawing.Point(1109, 45);
            this.grown.Name = "grown";
            this.grown.Size = new System.Drawing.Size(139, 167);
            this.grown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grown.TabIndex = 10;
            this.grown.TabStop = false;
            this.grown.Visible = false;
            // 
            // maintain
            // 
            this.maintain.Image = global::WindowsFormsApp8.Properties.Resources.Maintain;
            this.maintain.Location = new System.Drawing.Point(734, 452);
            this.maintain.Name = "maintain";
            this.maintain.Size = new System.Drawing.Size(139, 167);
            this.maintain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maintain.TabIndex = 9;
            this.maintain.TabStop = false;
            this.maintain.Visible = false;
            // 
            // grow
            // 
            this.grow.Image = global::WindowsFormsApp8.Properties.Resources.Grow;
            this.grow.Location = new System.Drawing.Point(301, 370);
            this.grow.Name = "grow";
            this.grow.Size = new System.Drawing.Size(182, 167);
            this.grow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grow.TabIndex = 8;
            this.grow.TabStop = false;
            this.grow.Visible = false;
            // 
            // Radish_Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 845);
            this.Controls.Add(this.jerryRadish);
            this.Controls.Add(this.seeds);
            this.Controls.Add(this.grown);
            this.Controls.Add(this.maintain);
            this.Controls.Add(this.grow);
            this.Name = "Radish_Move";
            this.Text = "Radish_Move";
            ((System.ComponentModel.ISupportInitialize)(this.jerryRadish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jerryRadish;
        public System.Windows.Forms.PictureBox seeds;
        public System.Windows.Forms.PictureBox grown;
        public System.Windows.Forms.PictureBox maintain;
        public System.Windows.Forms.PictureBox grow;
    }
}