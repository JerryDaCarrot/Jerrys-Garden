namespace WindowsFormsApp8
{
    partial class Carrot_Seeds
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
            this.Information = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1113, 25);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(144, 71);
            this.exit.TabIndex = 7;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(1113, 759);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(144, 98);
            this.right.TabIndex = 6;
            this.right.Text = "->";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(189, 770);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(144, 98);
            this.left.TabIndex = 5;
            this.left.Text = "<-";
            this.left.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(450, 101);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(535, 627);
            this.Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Information.TabIndex = 4;
            this.Information.TabStop = false;
            // 
            // Carrot_Seeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 893);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.Information);
            this.Name = "Carrot_Seeds";
            this.Text = "Carrot_Seeds";
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.PictureBox Information;
    }
}