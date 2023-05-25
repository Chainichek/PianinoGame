﻿using PianinoGame.Database;
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

        public List<RatingDTO> getGeneralRatingUsers()
        {
            return connection.GetUsers();
        }
        
        public List<RatingDTO> getPersonalRatingUsers(string name)
        {
            return connection.GetPersonalUsers(name);
        }
    }
}
