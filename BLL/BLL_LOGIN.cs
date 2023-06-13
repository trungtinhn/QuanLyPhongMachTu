using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LOGIN
{
    public class User_BLL_LOGIN
    {
        DAL_LOGIN db;

        public User_BLL_LOGIN()
        {
            db = new DAL_LOGIN();
        }

        public bool CheckUser(string username, string password)
        {
            return db.CheckUser(username, password);
        }
    }
}
