using System.Collections.Generic;
using DTO;
using System.Linq;
namespace DAL
{
    public class DAL_LOGIN
    {
        // Phương thức kiểm tra tài khoản
        public bool CheckAccount(string username, string password)
        {
            using (QLPMTEntities dataContext = new QLPMTEntities())
            {
                DTO_LOGIN account = (from a in dataContext.NGUOIDUNG
                                     where a.TenDangNhap == username && a.MatKhau == password
                                     select new DTO_LOGIN {

                                         TenDangNhap = a.TenDangNhap,
                                         id = a.id,
                                         MatKhau = a.MatKhau,
                                     }).FirstOrDefault();

                return account != null;
            }
        }

        // Phương thức lấy tài khoản theo tên
        public DTO_LOGIN GetAccountByUsername(string username)
        {
            using (QLPMTEntities dataContext = new QLPMTEntities())
            {
                DTO_LOGIN account = (from a in dataContext.NGUOIDUNG
                                      where a.TenDangNhap == username
                                     select new DTO_LOGIN
                                      {
                                          id = a.id,
                                          TenDangNhap = a.TenDangNhap,
                                          MatKhau = a.MatKhau,
                                      }).FirstOrDefault();

                return account;
            }
        }

        // Phương thức lấy danh sách tài khoản
        public List<DTO_LOGIN> GetAllAccounts()
        {
            using (QLPMTEntities dataContext = new QLPMTEntities())
            {
                List<DTO_LOGIN> accounts = (from a in dataContext.NGUOIDUNG
                                             select new DTO_LOGIN
                                             {  
                                                 id = a.id,
                                                   TenDangNhap = a.TenDangNhap, 
                                                   MatKhau = a.MatKhau,
                                             }).ToList();

                return accounts;
            }
        }
    }
}
