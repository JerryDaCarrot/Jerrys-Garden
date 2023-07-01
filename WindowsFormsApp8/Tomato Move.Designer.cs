namespace WindowsFormsApp8
{
    partial class Tomato_Move
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
            this.seeds = new System.Windows.Forms.PictureBox();
            this.grown = new System.Windows.Forms.PictureBox();
            this.maintain = new System.Windows.Forms.PictureBox();
            this.grow = new System.Windows.Forms.PictureBox();
            this.jerryTomato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerryTomato)).BeginInit();
            this.SuspendLayout();
            // 
            // seeds
            // 
            this.seeds.ErrorImage = null;
            this.seeds.Image = global::WindowsFormsApp8.Properties.Resources.Seeds;
            this.seeds.Location = new System.Drawing.Point(497, 655);
            this.seeds.Name = "seeds";
            this.seeds.Size = new System.Drawing.Size(139, 167);
            this.seeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seeds.TabIndex = 5;
            this.seeds.TabStop = false;
            // 
            // grown
            // 
            this.grown.Image = global::WindowsFormsApp8.Properties.Resources.Grown;
            this.grown.Location = new System.Drawing.Point(931, 504);
            this.grown.Name = "grown";
            this.grown.Size = new System.Drawing.Size(139, 167);
            this.grown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grown.TabIndex = 8;
            this.grown.TabStop = false;
            this.grown.Visible = false;
            // 
            // maintain
            // 
            this.maintain.Image = global::WindowsFormsApp8.Properties.Resources.Maintain;
            this.maintain.Location = new System.Drawing.Point(1198, 137);
            this.maintain.Name = "maintain";
            this.maintain.Size = new System.Drawing.Size(139, 167);
            this.maintain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maintain.TabIndex = 7;
            this.maintain.TabStop = false;
            this.maintain.Visible = false;
            // 
            // grow
            // 
            this.grow.Image = global::WindowsFormsApp8.Properties.Resources.Grow;
            this.grow.Location = new System.Drawing.Point(160, 68);
            this.grow.Name = "grow";
            this.grow.Size = new System.Drawing.Size(182, 167);
            this.grow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grow.TabIndex = 6;
            this.grow.TabStop = false;
            this.grow.Visible = false;
            // 
            // jerryTomato
            // 
            this.jerryTomato.Location = new System.Drawing.Point(839, 48);
            this.jerryTomato.Name = "jerryTomato";
            this.jerryTomato.Size = new System.Drawing.Size(57, 30);
            this.jerryTomato.TabIndex = 9;
            this.jerryTomato.TabStop = false;
            // 
            // Tomato_Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 882);
            this.Controls.Add(this.jerryTomato);
            this.Controls.Add(this.seeds);
            this.Controls.Add(this.grown);
            this.Controls.Add(this.maintain);
            this.Controls.Add(this.grow);
            this.Name = "Tomato_Move";
            this.Text = "Tomato_Move";
            ((System.ComponentModel.ISupportInitialize)(this.seeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerryTomato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox seeds;
        public System.Windows.Forms.PictureBox grown;
        public System.Windows.Forms.PictureBox maintain;
        public System.Windows.Forms.PictureBox grow;
        private System.Windows.Forms.PictureBox jerryTomato;
    }
}