using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianinoGame.Models
{
    public class RatingDTO
    {
        public string name { set; get; }
        public int score { set; get; }


        RatingDTO()
        {

        }
        public RatingDTO(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
