namespace WindowsFormsApp8
{
    partial class How_To_Play
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
            this.HowToPlay = new System.Windows.Forms.PictureBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HowToPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // HowToPlay
            // 
            this.HowToPlay.Location = new System.Drawing.Point(108, 60);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(1089, 713);
            this.HowToPlay.TabIndex = 0;
            this.HowToPlay.TabStop = false;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(108, 797);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(134, 96);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "button1";
            this.Previous.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(274, 797);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(134, 96);
            this.Next.TabIndex = 2;
            this.Next.Text = "button2";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(1063, 797);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(134, 96);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "button3";
            this.Finish.UseVisualStyleBackColor = true;
            // 
            // How_To_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 905);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.HowToPlay);
            this.Name = "How_To_Play";
            this.Text = "How_To_Play";
            this.Load += new System.EventHandler(this.How_To_Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HowToPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HowToPlay;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Finish;
    }
}