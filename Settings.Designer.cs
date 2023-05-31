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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.gameplaySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.cultureLabel = new System.Windows.Forms.Label();
            this.cultureComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.volumeSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.musiclVolumeSettingsTrackBar = new System.Windows.Forms.TrackBar();
            this.musiclVolumeSettingsLabel = new System.Windows.Forms.Label();
            this.effectslVolumeSettingsTrackBar = new System.Windows.Forms.TrackBar();
            this.effectslVolumeSettingsLabel = new System.Windows.Forms.Label();
            this.generalVolumeSettingsTrackBar = new System.Windows.Forms.TrackBar();
            this.generalVolumeSettingsLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            this.gameplaySettingsGroupBox.SuspendLayout();
            this.volumeSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musiclVolumeSettingsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectslVolumeSettingsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalVolumeSettingsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.gameplaySettingsGroupBox);
            this.settingsGroupBox.Controls.Add(this.volumeSettingsGroupBox);
            resources.ApplyResources(this.settingsGroupBox, "settingsGroupBox");
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.TabStop = false;
            // 
            // gameplaySettingsGroupBox
            // 
            this.gameplaySettingsGroupBox.Controls.Add(this.cultureLabel);
            this.gameplaySettingsGroupBox.Controls.Add(this.cultureComboBox);
            this.gameplaySettingsGroupBox.Controls.Add(this.usernameTextBox);
            this.gameplaySettingsGroupBox.Controls.Add(this.usernameLabel);
            resources.ApplyResources(this.gameplaySettingsGroupBox, "gameplaySettingsGroupBox");
            this.gameplaySettingsGroupBox.Name = "gameplaySettingsGroupBox";
            this.gameplaySettingsGroupBox.TabStop = false;
            // 
            // cultureLabel
            // 
            resources.ApplyResources(this.cultureLabel, "cultureLabel");
            this.cultureLabel.Name = "cultureLabel";
            // 
            // cultureComboBox
            // 
            this.cultureComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.cultureComboBox, "cultureComboBox");
            this.cultureComboBox.Name = "cultureComboBox";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // volumeSettingsGroupBox
            // 
            this.volumeSettingsGroupBox.Controls.Add(this.musiclVolumeSettingsTrackBar);
            this.volumeSettingsGroupBox.Controls.Add(this.musiclVolumeSettingsLabel);
            this.volumeSettingsGroupBox.Controls.Add(this.effectslVolumeSettingsTrackBar);
            this.volumeSettingsGroupBox.Controls.Add(this.effectslVolumeSettingsLabel);
            this.volumeSettingsGroupBox.Controls.Add(this.generalVolumeSettingsTrackBar);
            this.volumeSettingsGroupBox.Controls.Add(this.generalVolumeSettingsLabel);
            resources.ApplyResources(this.volumeSettingsGroupBox, "volumeSettingsGroupBox");
            this.volumeSettingsGroupBox.Name = "volumeSettingsGroupBox";
            this.volumeSettingsGroupBox.TabStop = false;
            // 
            // musiclVolumeSettingsTrackBar
            // 
            resources.ApplyResources(this.musiclVolumeSettingsTrackBar, "musiclVolumeSettingsTrackBar");
            this.musiclVolumeSettingsTrackBar.Maximum = 100;
            this.musiclVolumeSettingsTrackBar.Name = "musiclVolumeSettingsTrackBar";
            // 
            // musiclVolumeSettingsLabel
            // 
            resources.ApplyResources(this.musiclVolumeSettingsLabel, "musiclVolumeSettingsLabel");
            this.musiclVolumeSettingsLabel.Name = "musiclVolumeSettingsLabel";
            // 
            // effectslVolumeSettingsTrackBar
            // 
            resources.ApplyResources(this.effectslVolumeSettingsTrackBar, "effectslVolumeSettingsTrackBar");
            this.effectslVolumeSettingsTrackBar.Maximum = 100;
            this.effectslVolumeSettingsTrackBar.Name = "effectslVolumeSettingsTrackBar";
            // 
            // effectslVolumeSettingsLabel
            // 
            resources.ApplyResources(this.effectslVolumeSettingsLabel, "effectslVolumeSettingsLabel");
            this.effectslVolumeSettingsLabel.Name = "effectslVolumeSettingsLabel";
            // 
            // generalVolumeSettingsTrackBar
            // 
            resources.ApplyResources(this.generalVolumeSettingsTrackBar, "generalVolumeSettingsTrackBar");
            this.generalVolumeSettingsTrackBar.Maximum = 100;
            this.generalVolumeSettingsTrackBar.Name = "generalVolumeSettingsTrackBar";
            // 
            // generalVolumeSettingsLabel
            // 
            resources.ApplyResources(this.generalVolumeSettingsLabel, "generalVolumeSettingsLabel");
            this.generalVolumeSettingsLabel.Name = "generalVolumeSettingsLabel";
            // 
            // settingsLabel
            // 
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.Name = "settingsLabel";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.settingsGroupBox);
            this.Name = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.settingsGroupBox.ResumeLayout(false);
            this.gameplaySettingsGroupBox.ResumeLayout(false);
            this.gameplaySettingsGroupBox.PerformLayout();
            this.volumeSettingsGroupBox.ResumeLayout(false);
            this.volumeSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musiclVolumeSettingsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectslVolumeSettingsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalVolumeSettingsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.ControlBox = false;

        }

        private System.Windows.Forms.GroupBox gameplaySettingsGroupBox;

        private System.Windows.Forms.TextBox usernameTextBox;

        private System.Windows.Forms.Label usernameLabel;

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label settingsLabel;

        #endregion

        private System.Windows.Forms.GroupBox volumeSettingsGroupBox;
        private System.Windows.Forms.TrackBar musiclVolumeSettingsTrackBar;
        private System.Windows.Forms.Label musiclVolumeSettingsLabel;
        private System.Windows.Forms.TrackBar effectslVolumeSettingsTrackBar;
        private System.Windows.Forms.Label effectslVolumeSettingsLabel;
        private System.Windows.Forms.TrackBar generalVolumeSettingsTrackBar;
        private System.Windows.Forms.Label generalVolumeSettingsLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label cultureLabel;
        private System.Windows.Forms.ComboBox cultureComboBox;
    }
}