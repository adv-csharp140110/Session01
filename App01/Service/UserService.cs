using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App01.DataSource;
using App01.Model;

namespace App01.Service
{
    public class UserService
    {
        public void Add(User user)
        {
            InMemoryDB.Users.Add(user);
        }

        public User GetByIndex(int index)
        {
            return InMemoryDB.Users[index];
        }

        public void Update(User user, int index)
        {
            InMemoryDB.Users[index] = user;
        }



    }
}
