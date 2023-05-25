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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.pauseContinueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.pausePanel.SuspendLayout();
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
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.Controls.Add(this.BackPicBox);
            this.gamePanel.Controls.Add(this.ScoreLabel);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(444, 561);
            this.gamePanel.TabIndex = 5;
            // 
            // pausePanel
            // 
            this.pausePanel.Controls.Add(this.pauseContinueButton);
            this.pausePanel.Controls.Add(this.pauseLabel);
            this.pausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pausePanel.Location = new System.Drawing.Point(0, 0);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(444, 561);
            this.pausePanel.TabIndex = 5;
            this.pausePanel.Visible = false;
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Location = new System.Drawing.Point(133, 19);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(57, 13);
            this.pauseLabel.TabIndex = 0;
            this.pauseLabel.Text = "Это пауза";
            // 
            // pauseContinueButton
            // 
            this.pauseContinueButton.Location = new System.Drawing.Point(136, 91);
            this.pauseContinueButton.Name = "pauseContinueButton";
            this.pauseContinueButton.Size = new System.Drawing.Size(190, 23);
            this.pauseContinueButton.TabIndex = 1;
            this.pauseContinueButton.Text = "ПРОДОЛЖАЙ ДЕТКА";
            this.pauseContinueButton.UseVisualStyleBackColor = true;
            this.pauseContinueButton.Click += new System.EventHandler(this.pauseContinueButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PianinoGame.Properties.Resources.png_transparent_light_blue_abstract_gradient_background_blurred;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.pausePanel.ResumeLayout(false);
            this.pausePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox BackPicBox;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button pauseContinueButton;
    }
}