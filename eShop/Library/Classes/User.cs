using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class User
    {
        private static int _count = 1;
        public int ID { get; set; }
        public string UserName { get; set; }
        public static List<User> _users = new List<User>();


        public User(string userName)
        {
            this.ID = _count++;
            this.UserName = userName;

            _users.Add(this);
        }

    }
}
