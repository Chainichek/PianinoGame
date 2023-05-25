using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianinoGame.Models
{
    public class User
    {

        public User()
        {

        }
        public User(int id, string nickname, string email, string password)
        {
            Id = id;
            Nickname = nickname;
            Email = email;
            Password = password;
        }

        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
