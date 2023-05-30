﻿using System;
using System.Windows.Forms;
using PianinoGame.Properties;

namespace PianinoGame
{
    public partial class Settings : Form
    {
        private Form _backForm;
        private static Settings _settings;

        private Settings()
        {
            InitializeComponent();

            foreach (var culture in Resources.Cultures.Split(','))
            {
                cultureComboBox.Items.Add(culture);
            }
            SetUserSettings();

        }

        public void SetBackForm(Form form)
        {
            _backForm = form;
        }

        private void SetUserSettings()
        {
            usernameTextBox.Text = Properties.Settings.Default.Username;
            cultureComboBox.SelectedIndex = cultureComboBox.Items.IndexOf(Properties.Settings.Default.Culture);
            generalVolumeSettingsTrackBar.Value = Properties.Settings.Default.GeneralVolume;
            effectslVolumeSettingsTrackBar.Value = Properties.Settings.Default.EffectsVolume;
            musiclVolumeSettingsTrackBar.Value = Properties.Settings.Default.MusicVolume;

        }

        public static Settings GetInstance()
        {
            return _settings ?? (_settings = new Settings());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = usernameTextBox.Text;
            Properties.Settings.Default.Culture = cultureComboBox.Text;
            Properties.Settings.Default.GeneralVolume = (ushort)generalVolumeSettingsTrackBar.Value;
            Properties.Settings.Default.EffectsVolume = (ushort)effectslVolumeSettingsTrackBar.Value;
            Properties.Settings.Default.MusicVolume = (ushort)musiclVolumeSettingsTrackBar.Value;

            Properties.Settings.Default.Save();

            ApplicationBootStrap.ChangeCulture();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.GetInstance().Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _backForm.Show();
        }
    }
}