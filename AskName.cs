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
    public partial class AskNameForm : Form
    {
        public AskNameForm()
        {
            InitializeComponent();
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.name = nameTextBox.Text;
            gameForm.Show();
            this.Hide();
        }

        private void AskNameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
