using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_THUOC
    {
        DAL_THUOC dThuocDAL;
        public BLL_THUOC()
        {
            dThuocDAL = new DAL_THUOC();
        }

        public dynamic LayDanhSachThuoc(int idLoaiThuoc)
        {
            return dThuocDAL.LayDanhSachThuoc(idLoaiThuoc);
        }

        public THUOC LayThuoc(string maThuoc)
        {
            return dThuocDAL.LayThuoc(maThuoc);
        }

        public string LayTenThuoc(int idThuoc)
        {
            return dThuocDAL.LayTenThuoc(idThuoc);
        }

        public int LayIdLoaiThuoc(string tenThuoc)
        {
            return dThuocDAL.LayIdLoaiThuoc(tenThuoc);
        }

    }
}
