using PianinoGame.Models;
using PianinoGame.Presenters;
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
    public partial class RatingForm : Form, IRating
    {
        public RatingForm()
        {
            InitializeComponent();
            var ratingPresenter = new RatingPresenter(this);
            ratingPresenter.ShowRatingTable();
        }

        public string RatingUsers
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                RatingNamePlace.Text = value;
            }
        }

        private void RatingNamePlace_Click(object sender, EventArgs e)
        {
            
        }

        private void RatingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void atingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
