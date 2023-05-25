using PianinoGame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PianinoGame.Models;
using System.Windows.Forms;

namespace PianinoGame.Presenters
{
    public class RatingPresenter
    {
        IRating ratingView;
        Rating rating;

        public RatingPresenter(IRating view)
        {
            ratingView = view;
            rating = new Rating();
        }

        public void ShowRatingTable()
        {
           
            List<RatingDTO> users = rating.getRatingUsers();
            /*MessageBox.Show(
               users.ToString(),
               "Сообщение",
               MessageBoxButtons.YesNo);*/
            string text = "";
            for (int i = 0; i < users.Count; i++)
            {
                text += (i+1) + ". " + users[i].name  + " - " + users[i].score + "\n";
            }
            ratingView.RatingUsers = text;
        }


    }
}
