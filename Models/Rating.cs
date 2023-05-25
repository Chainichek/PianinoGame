using PianinoGame.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianinoGame.Models
{
    public class Rating
    {
        public Connection connection = Connection.GetInstanse();
        public List<String> rating;

        public List<RatingDTO> getRatingUsers()
        {
            return connection.GetUsers();
        }
    }
}
