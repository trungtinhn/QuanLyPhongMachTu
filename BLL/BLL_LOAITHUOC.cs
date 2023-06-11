using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_LOAITHUOC
    {
        DAL_LOAITHUOC dLoaiThuocDAL;
        public BLL_LOAITHUOC()
        {
            dLoaiThuocDAL = new DAL_LOAITHUOC();    
        }

        public dynamic LayDanhSachLoaiThuoc()
        {
            return dLoaiThuocDAL.LayDanhSachLoaiThuoc();
        }

        public LOAITHUOC LayLoaiThuoc(string MaLoaiThuoc)
        {
            return dLoaiThuocDAL.LayLoaiThuoc(MaLoaiThuoc);
        }

        public string LayTenLoaiThuoc(int idLoaiThuoc)
        {
            return dLoaiThuocDAL.LayTenLoaiThuoc(idLoaiThuoc);
        }
       
    }
}
