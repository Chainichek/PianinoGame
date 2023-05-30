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

        public void ShowGeneralRatingTable()
        {
            var users = rating.getGeneralRatingUsers();
            var text = "";
            for (var i = 0; i < users.Count & i < 10; i++)
            {
                text += (i+1) + ". " + users[i].name  + " - " + users[i].score + "\n";
            }
            ratingView.RatingUsers = text;
        }
        
        public void ShowPersonalRatingTable()
        {
            var users = rating.getPersonalRatingUsers(Properties.Settings.Default.Username);
            var text = "";
            for (var i = 0; i < users.Count & i < 10; i++)
            {
                text += (i+1) + ". " + users[i].name  + " - " + users[i].score + "\n";
            }
            ratingView.RatingUsers = text;
        }


    }
}
