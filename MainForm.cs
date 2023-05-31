using PianinoGame.Models;
using PianinoGame.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianinoGame
{
    public partial class MainForm : Form
    {

        private static MainForm _mainForm;
        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm GetInstance()
        {
            if (_mainForm == null)
            {
                _mainForm = new MainForm();
            }

            return _mainForm;
        }

        private void RatingLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RatingForm.GetInstance().Show();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                AskNameForm.GetInstance().Show();
            }
            else
            {
                GameForm.GetInstance().Show();
                GameForm.GetInstance().RunGame();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            About.GetInstance().SetBackForm(this);
            this.Hide();
            About.GetInstance().ShowDialog();
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            Settings.GetInstance().SetBackForm(this);
            this.Hide();
            Settings.GetInstance().ShowDialog();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
