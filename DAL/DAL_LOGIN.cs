using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LOGIN
    {
        QLPMTEntities db;
        public DAL_LOGIN()
        {
            db = new QLPMTEntities();
        }

        public bool CheckUser(string username, string password)
        {
            var user = db.NGUOIDUNG.FirstOrDefault(x => x.TenDangNhap== username && x.MatKhau == password);
            if (user == null) return false;
            return true;
        }
    }

}
