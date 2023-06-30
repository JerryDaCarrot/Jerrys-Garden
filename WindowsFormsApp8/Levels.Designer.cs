namespace WindowsFormsApp8
{
    partial class Levels
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
            this.level1 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.level6 = new System.Windows.Forms.Button();
            this.level5 = new System.Windows.Forms.Button();
            this.level4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.Location = new System.Drawing.Point(76, 128);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(183, 117);
            this.level1.TabIndex = 0;
            this.level1.Text = "button1";
            this.level1.UseVisualStyleBackColor = true;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level3
            // 
            this.level3.Location = new System.Drawing.Point(526, 128);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(183, 117);
            this.level3.TabIndex = 1;
            this.level3.Text = "button1";
            this.level3.UseVisualStyleBackColor = true;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // level2
            // 
            this.level2.Location = new System.Drawing.Point(289, 128);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(183, 117);
            this.level2.TabIndex = 2;
            this.level2.Text = "button1";
            this.level2.UseVisualStyleBackColor = true;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level6
            // 
            this.level6.Location = new System.Drawing.Point(1232, 128);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(183, 117);
            this.level6.TabIndex = 3;
            this.level6.Text = "button1";
            this.level6.UseVisualStyleBackColor = true;
            this.level6.Click += new System.EventHandler(this.level6_Click);
            // 
            // level5
            // 
            this.level5.Location = new System.Drawing.Point(1015, 128);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(183, 117);
            this.level5.TabIndex = 4;
            this.level5.Text = "button1";
            this.level5.UseVisualStyleBackColor = true;
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // level4
            // 
            this.level4.Location = new System.Drawing.Point(781, 128);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(183, 117);
            this.level4.TabIndex = 5;
            this.level4.Text = "button1";
            this.level4.UseVisualStyleBackColor = true;
            this.level4.Click += new System.EventHandler(this.level4_Click);
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 849);
            this.Controls.Add(this.level4);
            this.Controls.Add(this.level5);
            this.Controls.Add(this.level6);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level1);
            this.Name = "Levels";
            this.Text = "Levels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button level3;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button level6;
        private System.Windows.Forms.Button level5;
        private System.Windows.Forms.Button level4;
    }
}