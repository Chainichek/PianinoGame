﻿using System;
using System.Windows.Forms;
using PianinoGame.Database;
using PianinoGame.Models;
using PianinoGame.Properties;

namespace PianinoGame
{
    public partial class Settings : Form
    {
        private Form _backForm;
        private static Settings _settings;
        private Connection Connection = new Connection();

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
           

        }

        public static Settings GetInstance()
        {
            return _settings ?? (_settings = new Settings());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (!Properties.Settings.Default.Username.Equals(usernameTextBox.Text))
            {
                UserDto result = saveName(usernameTextBox.Text);
                if (result != null)
                {
                    Properties.Settings.Default.Username = usernameTextBox.Text;
                    Properties.Settings.Default.UserId = result.id;
                }
            }
            Properties.Settings.Default.Culture = cultureComboBox.Text;
            Properties.Settings.Default.GeneralVolume = (ushort)generalVolumeSettingsTrackBar.Value;

            Properties.Settings.Default.Save();
        
            ApplicationBootStrap.ChangeCulture();
        }

        private UserDto saveName(string name)
        {
            var result = Connection.InsertUser(name);
            if (result == null)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Попробуйте выбрать другой никнейм.",
                    "Этот никнейм занят",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
                return null;
            }

            return result;
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