namespace WindowsFormsApp8
{
    partial class Cabbage_Seeds
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
            this.Cabbage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cabbage)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1019, 15);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(144, 71);
            this.exit.TabIndex = 7;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(1019, 749);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(144, 98);
            this.right.TabIndex = 6;
            this.right.Text = "->";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(95, 760);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(144, 98);
            this.left.TabIndex = 5;
            this.left.Text = "<-";
            this.left.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(128, 73);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(535, 627);
            this.Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Information.TabIndex = 4;
            this.Information.TabStop = false;
            // 
            // Cabbage
            // 
            this.Cabbage.Image = global::WindowsFormsApp8.Properties.Resources.Cabbage;
            this.Cabbage.Location = new System.Drawing.Point(731, 328);
            this.Cabbage.Name = "Cabbage";
            this.Cabbage.Size = new System.Drawing.Size(377, 371);
            this.Cabbage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cabbage.TabIndex = 8;
            this.Cabbage.TabStop = false;
            // 
            // Cabbage_Seeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 883);
            this.Controls.Add(this.Cabbage);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.Information);
            this.Name = "Cabbage_Seeds";
            this.Text = "Cabbage_Seeds";
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cabbage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.PictureBox Information;
        private System.Windows.Forms.PictureBox Cabbage;
    }
}