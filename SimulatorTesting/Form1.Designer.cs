namespace SimulatorTesting
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ObstacleButton = new System.Windows.Forms.Button();
            this.GridCleanButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testing";
            // 
            // ObstacleButton
            // 
            this.ObstacleButton.Location = new System.Drawing.Point(164, 4);
            this.ObstacleButton.Name = "ObstacleButton";
            this.ObstacleButton.Size = new System.Drawing.Size(75, 23);
            this.ObstacleButton.TabIndex = 2;
            this.ObstacleButton.Text = "Obstacles";
            this.ObstacleButton.UseVisualStyleBackColor = true;
            this.ObstacleButton.Click += new System.EventHandler(this.ObstacleButton_Click);
            // 
            // GridCleanButton
            // 
            this.GridCleanButton.Location = new System.Drawing.Point(245, 4);
            this.GridCleanButton.Name = "GridCleanButton";
            this.GridCleanButton.Size = new System.Drawing.Size(75, 23);
            this.GridCleanButton.TabIndex = 3;
            this.GridCleanButton.Text = "Grid cleaning";
            this.GridCleanButton.UseVisualStyleBackColor = true;
            this.GridCleanButton.Click += new System.EventHandler(this.GridCleanButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(326, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Location = new System.Drawing.Point(407, 4);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(75, 23);
            this.FlipButton.TabIndex = 5;
            this.FlipButton.Text = "Flip";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 664);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.GridCleanButton);
            this.Controls.Add(this.ObstacleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ObstacleButton;
        private System.Windows.Forms.Button GridCleanButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button FlipButton;
    }
}

