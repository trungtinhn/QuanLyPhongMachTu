using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLL_LOGIN
    {
        private readonly DAL_LOGIN dalLogin;

        public BLL_LOGIN()
        {
            dalLogin = new DAL_LOGIN();
        }

        public bool Login(NGUOIDUNG account)
        {
            return dalLogin.Login(account.TenDangNhap, account.MatKhau);
        }
    }
}
