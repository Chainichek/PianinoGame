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
            this.pause_PictureBox = new System.Windows.Forms.PictureBox();
            this.gamePictureBoxTargerPanel = new System.Windows.Forms.Panel();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.pauseGroupBox = new System.Windows.Forms.GroupBox();
            this.pauseSettingsButton = new System.Windows.Forms.Button();
            this.pauseApplicationExitButton = new System.Windows.Forms.Button();
            this.pauseGameExitButton = new System.Windows.Forms.Button();
            this.pauseAboutButton = new System.Windows.Forms.Button();
            this.pauseContinueButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicBox)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_PictureBox)).BeginInit();
            this.pausePanel.SuspendLayout();
            this.pauseGroupBox.SuspendLayout();
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
            this.gamePanel.BackgroundImage = global::PianinoGame.Properties.Resources.png_transparent_light_blue_abstract_gradient_background_blurred;
            this.gamePanel.Controls.Add(this.pause_PictureBox);
            this.gamePanel.Controls.Add(this.BackPicBox);
            this.gamePanel.Controls.Add(this.ScoreLabel);
            this.gamePanel.Controls.Add(this.gamePictureBoxTargerPanel);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(444, 561);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // pause_PictureBox
            // 
            this.pause_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pause_PictureBox.Image = global::PianinoGame.Properties.Resources.icons8_pause_50;
            this.pause_PictureBox.Location = new System.Drawing.Point(382, 12);
            this.pause_PictureBox.Name = "pause_PictureBox";
            this.pause_PictureBox.Size = new System.Drawing.Size(50, 53);
            this.pause_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause_PictureBox.TabIndex = 6;
            this.pause_PictureBox.TabStop = false;
            this.pause_PictureBox.Click += new System.EventHandler(this.pause_PictureBox_Click);
            // 
            // gamePictureBoxTargerPanel
            // 
            this.gamePictureBoxTargerPanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePictureBoxTargerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gamePictureBoxTargerPanel.Location = new System.Drawing.Point(0, 501);
            this.gamePictureBoxTargerPanel.Name = "gamePictureBoxTargerPanel";
            this.gamePictureBoxTargerPanel.Size = new System.Drawing.Size(444, 60);
            this.gamePictureBoxTargerPanel.TabIndex = 5;
            this.gamePictureBoxTargerPanel.Visible = false;
            // 
            // pausePanel
            // 
            this.pausePanel.Controls.Add(this.pauseGroupBox);
            this.pausePanel.Controls.Add(this.pauseLabel);
            this.pausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pausePanel.Location = new System.Drawing.Point(0, 0);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(444, 561);
            this.pausePanel.TabIndex = 5;
            this.pausePanel.Visible = false;
            // 
            // pauseGroupBox
            // 
            this.pauseGroupBox.Controls.Add(this.pauseSettingsButton);
            this.pauseGroupBox.Controls.Add(this.pauseApplicationExitButton);
            this.pauseGroupBox.Controls.Add(this.pauseGameExitButton);
            this.pauseGroupBox.Controls.Add(this.pauseAboutButton);
            this.pauseGroupBox.Controls.Add(this.pauseContinueButton);
            this.pauseGroupBox.Location = new System.Drawing.Point(119, 75);
            this.pauseGroupBox.Name = "pauseGroupBox";
            this.pauseGroupBox.Size = new System.Drawing.Size(230, 249);
            this.pauseGroupBox.TabIndex = 3;
            this.pauseGroupBox.TabStop = false;
            // 
            // pauseSettingsButton
            // 
            this.pauseSettingsButton.Location = new System.Drawing.Point(20, 113);
            this.pauseSettingsButton.Name = "pauseSettingsButton";
            this.pauseSettingsButton.Size = new System.Drawing.Size(190, 23);
            this.pauseSettingsButton.TabIndex = 5;
            this.pauseSettingsButton.Text = "Настройки";
            this.pauseSettingsButton.UseVisualStyleBackColor = true;
            this.pauseSettingsButton.Click += new System.EventHandler(this.pauseSettingsButton_Click);
            // 
            // pauseApplicationExitButton
            // 
            this.pauseApplicationExitButton.Location = new System.Drawing.Point(17, 210);
            this.pauseApplicationExitButton.Name = "pauseApplicationExitButton";
            this.pauseApplicationExitButton.Size = new System.Drawing.Size(190, 23);
            this.pauseApplicationExitButton.TabIndex = 4;
            this.pauseApplicationExitButton.Text = "Выйти в Windows";
            this.pauseApplicationExitButton.UseVisualStyleBackColor = true;
            this.pauseApplicationExitButton.Click += new System.EventHandler(this.pauseApplicationExitButton_Click);
            // 
            // pauseGameExitButton
            // 
            this.pauseGameExitButton.Location = new System.Drawing.Point(17, 163);
            this.pauseGameExitButton.Name = "pauseGameExitButton";
            this.pauseGameExitButton.Size = new System.Drawing.Size(190, 23);
            this.pauseGameExitButton.TabIndex = 3;
            this.pauseGameExitButton.Text = "Выйти в  главное меню";
            this.pauseGameExitButton.UseVisualStyleBackColor = true;
            // 
            // pauseAboutButton
            // 
            this.pauseAboutButton.Location = new System.Drawing.Point(17, 62);
            this.pauseAboutButton.Name = "pauseAboutButton";
            this.pauseAboutButton.Size = new System.Drawing.Size(190, 23);
            this.pauseAboutButton.TabIndex = 2;
            this.pauseAboutButton.Text = "Об игре";
            this.pauseAboutButton.UseVisualStyleBackColor = true;
            this.pauseAboutButton.Click += new System.EventHandler(this.pauseAboutButton_Click);
            // 
            // pauseContinueButton
            // 
            this.pauseContinueButton.Location = new System.Drawing.Point(17, 15);
            this.pauseContinueButton.Name = "pauseContinueButton";
            this.pauseContinueButton.Size = new System.Drawing.Size(190, 23);
            this.pauseContinueButton.TabIndex = 1;
            this.pauseContinueButton.Text = "Продолжить";
            this.pauseContinueButton.UseVisualStyleBackColor = true;
            this.pauseContinueButton.Click += new System.EventHandler(this.pauseContinueButton_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pauseLabel.Location = new System.Drawing.Point(191, 20);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(74, 26);
            this.pauseLabel.TabIndex = 0;
            this.pauseLabel.Text = "Пауза";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.pausePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pause_PictureBox)).EndInit();
            this.pausePanel.ResumeLayout(false);
            this.pausePanel.PerformLayout();
            this.pauseGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.ControlBox = false;
        }

        private System.Windows.Forms.Button pauseAboutButton;
        private System.Windows.Forms.GroupBox pauseGroupBox;
        private System.Windows.Forms.Button pauseGameExitButton;
        private System.Windows.Forms.Button pauseApplicationExitButton;

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox BackPicBox;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button pauseContinueButton;
        private System.Windows.Forms.Panel gamePictureBoxTargerPanel;
        private System.Windows.Forms.Button pauseSettingsButton;
        private System.Windows.Forms.PictureBox pause_PictureBox;
    }
}