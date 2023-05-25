namespace PianinoGame
{
    partial class GameForm
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.BackPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(174, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 24);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Счет: 0";
            // 
            // BackPicBox
            // 
            this.BackPicBox.BackColor = System.Drawing.Color.Transparent;
            this.BackPicBox.Image = global::PianinoGame.Properties.Resources.icons8_back_96;
            this.BackPicBox.Location = new System.Drawing.Point(12, 12);
            this.BackPicBox.Name = "BackPicBox";
            this.BackPicBox.Size = new System.Drawing.Size(50, 53);
            this.BackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackPicBox.TabIndex = 4;
            this.BackPicBox.TabStop = false;
            this.BackPicBox.Click += new System.EventHandler(this.BackPicBox_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PianinoGame.Properties.Resources.png_transparent_light_blue_abstract_gradient_background_blurred;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.BackPicBox);
            this.Controls.Add(this.ScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox BackPicBox;
    }
}