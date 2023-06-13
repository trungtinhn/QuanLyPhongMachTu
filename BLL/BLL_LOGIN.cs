using DTO;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_LOGIN
    {
        private readonly QLPMTEntities _dataContext;

        public BLL_LOGIN()
        {
            _dataContext = new QLPMTEntities();
        }

        // Phương thức xác minh thông tin đăng nhập
        public bool VerifyAccount(string username, string password)
        {
            DTO_LOGIN account = GetAccountByUsername(username);

            if (account == null)
            {
                return false;
            }

            if (account.MatKhau != password)
            {
                return false;
            }

            return true;
        }

        // Phương thức lấy tài khoản theo tên đăng nhập
        public DTO_LOGIN GetAccountByUsername(string username)
        {
            DTO_LOGIN account = (from a in _dataContext.NGUOIDUNG
                                  where a.TenDangNhap == username
                                  select new DTO_LOGIN
                                  {
                                      TenDangNhap = username,

                                  }).FirstOrDefault();

            return account;
        }

        // Phương thức lấy danh sách tài khoản
        public List<DTO_LOGIN> GetAllAccounts()
        {
            List<DTO_LOGIN> accounts = (from a in _dataContext.NGUOIDUNG
                                         select new DTO_LOGIN
                                         {
                                             TenDangNhap = a.TenDangNhap,
                                         }).ToList();

            return accounts;
        }
    }
}
