using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianinoGame.Models
{
    public class RatingDTO
    {
        public int id { set; get; }
        public UserDto user { set; get; }
        public int score { set; get; }

        
    }
}
