using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.DTO_LOGIN;

namespace BLL
{
    public class BLL_LOGIN
    {
        private readonly DAL_LOGIN dalLogin;

        public BLL_LOGIN()
        {
            dalLogin = new DAL_LOGIN();
        }

        public bool Login(DTO_ACCOUNT account)
        {
            return dalLogin.Login(account.TenDangNhap, account.MatKhau);
        }
    }
}
