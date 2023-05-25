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
    public partial class Form1 : Form
    {
        public Form1 MainForm = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void RatingLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RatingForm().Show();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AskNameForm().ShowDialog();
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
            this.Hide();
            new About().ShowDialog();
        }
    }
}
