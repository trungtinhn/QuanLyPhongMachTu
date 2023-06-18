
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace PhanQuyen
{
    public class Admin
    {
        private string username;
        private string role;

        // constructor
        public Admin(string username, string role)
        {
            this.username = username;
            this.role = role;
        }

        // Kiểm tra quyền truy cập của người dùng và đưa ra phán đoán tương ứng
        public bool HasPermission(string permission)
        {
            return permission.Equals(role);
        }
    }

}

