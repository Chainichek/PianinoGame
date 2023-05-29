using System.ComponentModel;

namespace PianinoGame
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.gameplaySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.volumeSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.musiclVolumeSettingsLabel = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.effectslVolumeSettingsLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.generalVolumeSettingslabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cultureComboBox = new System.Windows.Forms.ComboBox();
            this.cultureLabel = new System.Windows.Forms.Label();
            this.settingsGroupBox.SuspendLayout();
            this.gameplaySettingsGroupBox.SuspendLayout();
            this.volumeSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.gameplaySettingsGroupBox);
            this.settingsGroupBox.Controls.Add(this.volumeSettingsGroupBox);
            this.settingsGroupBox.Location = new System.Drawing.Point(23, 70);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(290, 357);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            // 
            // gameplaySettingsGroupBox
            // 
            this.gameplaySettingsGroupBox.Controls.Add(this.cultureLabel);
            this.gameplaySettingsGroupBox.Controls.Add(this.cultureComboBox);
            this.gameplaySettingsGroupBox.Controls.Add(this.nicknameTextBox);
            this.gameplaySettingsGroupBox.Controls.Add(this.nicknameLabel);
            this.gameplaySettingsGroupBox.Location = new System.Drawing.Point(13, 22);
            this.gameplaySettingsGroupBox.Name = "gameplaySettingsGroupBox";
            this.gameplaySettingsGroupBox.Size = new System.Drawing.Size(262, 125);
            this.gameplaySettingsGroupBox.TabIndex = 4;
            this.gameplaySettingsGroupBox.TabStop = false;
            this.gameplaySettingsGroupBox.Text = "Настройки игры";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(77, 19);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(179, 20);
            this.nicknameTextBox.TabIndex = 4;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Location = new System.Drawing.Point(6, 23);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(67, 16);
            this.nicknameLabel.TabIndex = 3;
            this.nicknameLabel.Text = "Ваше имя:";
            // 
            // volumeSettingsGroupBox
            // 
            this.volumeSettingsGroupBox.Controls.Add(this.trackBar3);
            this.volumeSettingsGroupBox.Controls.Add(this.musiclVolumeSettingsLabel);
            this.volumeSettingsGroupBox.Controls.Add(this.trackBar2);
            this.volumeSettingsGroupBox.Controls.Add(this.effectslVolumeSettingsLabel);
            this.volumeSettingsGroupBox.Controls.Add(this.trackBar1);
            this.volumeSettingsGroupBox.Controls.Add(this.generalVolumeSettingslabel);
            this.volumeSettingsGroupBox.Location = new System.Drawing.Point(6, 156);
            this.volumeSettingsGroupBox.Name = "volumeSettingsGroupBox";
            this.volumeSettingsGroupBox.Size = new System.Drawing.Size(275, 195);
            this.volumeSettingsGroupBox.TabIndex = 3;
            this.volumeSettingsGroupBox.TabStop = false;
            this.volumeSettingsGroupBox.Text = "Настройки громкости";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(86, 142);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(183, 45);
            this.trackBar3.TabIndex = 11;
            // 
            // musiclVolumeSettingsLabel
            // 
            this.musiclVolumeSettingsLabel.Location = new System.Drawing.Point(6, 142);
            this.musiclVolumeSettingsLabel.Name = "musiclVolumeSettingsLabel";
            this.musiclVolumeSettingsLabel.Size = new System.Drawing.Size(67, 29);
            this.musiclVolumeSettingsLabel.TabIndex = 10;
            this.musiclVolumeSettingsLabel.Text = "Громкость музыки";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(86, 91);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(183, 45);
            this.trackBar2.TabIndex = 9;
            // 
            // effectslVolumeSettingsLabel
            // 
            this.effectslVolumeSettingsLabel.Location = new System.Drawing.Point(6, 91);
            this.effectslVolumeSettingsLabel.Name = "effectslVolumeSettingsLabel";
            this.effectslVolumeSettingsLabel.Size = new System.Drawing.Size(67, 28);
            this.effectslVolumeSettingsLabel.TabIndex = 8;
            this.effectslVolumeSettingsLabel.Text = "Громкость звуков";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(86, 40);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(183, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // generalVolumeSettingslabel
            // 
            this.generalVolumeSettingslabel.Location = new System.Drawing.Point(6, 40);
            this.generalVolumeSettingslabel.Name = "generalVolumeSettingslabel";
            this.generalVolumeSettingslabel.Size = new System.Drawing.Size(67, 30);
            this.generalVolumeSettingslabel.TabIndex = 4;
            this.generalVolumeSettingslabel.Text = "Общая громкость";
            // 
            // settingsLabel
            // 
            this.settingsLabel.Location = new System.Drawing.Point(113, 27);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(118, 28);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Настройки";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(224, 433);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(252, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // cultureComboBox
            // 
            this.cultureComboBox.FormattingEnabled = true;
            this.cultureComboBox.Location = new System.Drawing.Point(77, 63);
            this.cultureComboBox.Name = "cultureComboBox";
            this.cultureComboBox.Size = new System.Drawing.Size(179, 21);
            this.cultureComboBox.TabIndex = 5;
            // 
            // cultureLabel
            // 
            this.cultureLabel.Location = new System.Drawing.Point(6, 66);
            this.cultureLabel.Name = "cultureLabel";
            this.cultureLabel.Size = new System.Drawing.Size(67, 16);
            this.cultureLabel.TabIndex = 6;
            this.cultureLabel.Text = "Язык";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 481);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.settingsGroupBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.settingsGroupBox.ResumeLayout(false);
            this.gameplaySettingsGroupBox.ResumeLayout(false);
            this.gameplaySettingsGroupBox.PerformLayout();
            this.volumeSettingsGroupBox.ResumeLayout(false);
            this.volumeSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox gameplaySettingsGroupBox;

        private System.Windows.Forms.TextBox nicknameTextBox;

        private System.Windows.Forms.Label nicknameLabel;

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label settingsLabel;

        #endregion

        private System.Windows.Forms.GroupBox volumeSettingsGroupBox;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label musiclVolumeSettingsLabel;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label effectslVolumeSettingsLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label generalVolumeSettingslabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label cultureLabel;
        private System.Windows.Forms.ComboBox cultureComboBox;
    }
}