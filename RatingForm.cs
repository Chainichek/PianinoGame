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
        private static RatingForm _ratingForm;
        
        private RatingPresenter ratingPresenter;
        
        private RatingForm()
        {
            InitializeComponent();
            ratingPresenter = new RatingPresenter(this);
            ratingPresenter.ShowGeneralRatingTable();
            MakeGeneraleUnderline();
        }

        public static RatingForm GetInstance()
        {
            if (_ratingForm == null)
            {
                _ratingForm = new RatingForm();
            }

            return _ratingForm;
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
            MainForm.GetInstance().Close();
        }

        private void btn_BackToMainMenu_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainForm.GetInstance().Show();

        }

        private void MakeGeneraleUnderline()
        {
            GeneralRatingLabel.Font = new Font("Microsoft Sans Serif", 
                16, 
                FontStyle.Underline, 
                GraphicsUnit.Point);
            
            PersonalRatingLabel.Font = new Font("Microsoft Sans Serif", 
                16, 
                FontStyle.Regular, 
                GraphicsUnit.Point);
        }

        private void MakePersonalUnderline()
        {
            GeneralRatingLabel.Font = new Font("Microsoft Sans Serif", 
                16, 
                FontStyle.Regular, 
                GraphicsUnit.Point);
            
            PersonalRatingLabel.Font = new Font("Microsoft Sans Serif", 
                16, 
                FontStyle.Underline, 
                GraphicsUnit.Point);
        }

        private void GeneralRatingLabel_Click(object sender, EventArgs e)
        {
            ratingPresenter.ShowGeneralRatingTable();
            MakeGeneraleUnderline();
        }

        private void PersonalRatingLabel_Click(object sender, EventArgs e)
        {
            ratingPresenter.ShowPersonalRatingTable();
            MakePersonalUnderline();
        }

        
    }
}
