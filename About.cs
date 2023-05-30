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
    public partial class About : Form
    {
        private Form _backForm;

        private static About _aboutForm;
        private About()
        {
            InitializeComponent();
        }
        
        public static About GetInstance()
        {
            if (_aboutForm == null)
            {
                _aboutForm = new About();
            }

            return _aboutForm;
        }

        public void SetBackForm(Form form)
        {
            _backForm = form;
        }
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
            _backForm.Show();
        }
    }
}
