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
        private static AskNameForm _askNameForm; 
        private AskNameForm()
        {
            InitializeComponent();
        }
        
        public static AskNameForm GetInstance()
        {
            if (_askNameForm == null)
            {
                _askNameForm = new AskNameForm();
            }
            return _askNameForm;
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = GameForm.GetInstance();
            gameForm.name = nameTextBox.Text;
            gameForm.Show();

            gameForm.RunGame();

            Hide();
        }

        private void AskNameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            MainForm.GetInstance().Show();
        }
    }
}
