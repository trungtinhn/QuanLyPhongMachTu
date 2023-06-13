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

        public THUOC LayTenThuoc(int idThuoc)
        {
            return dThuocDAL.LayTenThuoc(idThuoc);
        }

        public THUOC LayThongTinThuoc(string tenThuoc)
        {
            return dThuocDAL.LayThongTinThuoc(tenThuoc);
        }

    }
}
