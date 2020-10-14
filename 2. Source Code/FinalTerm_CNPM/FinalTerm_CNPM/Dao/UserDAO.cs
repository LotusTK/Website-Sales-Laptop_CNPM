using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class UserDAO
    {
        private FinalTermContext db;
        public UserDAO(FinalTermContext context)
        {
            this.db = context;
        }

        public User getUserByUserName(string username)
        {
            return db.Users.FirstOrDefault(u => u.userName.Equals(username));
        }

        public User validateUser(string username, string password)
        {
            return db.Users.FirstOrDefault(u => u.userName.Equals(username) && u.password.Equals(password));
        }
    }
}