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

        private void InitializeComponent()
        {
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.HowToPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HowToPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(51, 757);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(144, 98);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "<-";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(975, 746);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(144, 98);
            this.Next.TabIndex = 2;
            this.Next.Text = "->";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(975, 12);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(144, 71);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "x";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // HowToPlay
            // 
            this.HowToPlay.Location = new System.Drawing.Point(117, 88);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(945, 627);
            this.HowToPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HowToPlay.TabIndex = 0;
            this.HowToPlay.TabStop = false;
            // 
            // How_To_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 884);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.HowToPlay);
            this.Name = "How_To_Play";
            this.Text = "Radish_Seeds";
            this.Load += new System.EventHandler(this.How_To_Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HowToPlay)).EndInit();
            this.ResumeLayout(false);

        }
        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.PictureBox HowToPlay;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Finish;
    }
}