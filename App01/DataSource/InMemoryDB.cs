using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App01.Model;

namespace App01.DataSource
{
    /*
     * normal
     * partial
     * static
     *  can't be instantiated (no new)
     *      utility
     *      db store <- single user (desktop)
     */
    public static class InMemoryDB
    {
        /**
         * multiple data?
         *  Array -> size fix
         *  List -> size dynamic
         */
        public static List<User> Users = new List<User>
        {
            new User{Id = 1, FirstName = "f1", LastName = "l1", Email = "e1", Phone = "p1"},
            new User{Id = 2, FirstName = "f2", LastName = "l2", Email = "e2", Phone = "p2"},
            new User{Id = 3, FirstName = "f3", LastName = "l3", Email = "e3", Phone = "p3"},
        };
    }
}
