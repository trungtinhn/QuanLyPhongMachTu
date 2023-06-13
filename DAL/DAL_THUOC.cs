using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_THUOC
    {
        QLPMTEntities db;
        public DAL_THUOC()
        {
            db = new QLPMTEntities();
        }

        public dynamic LayDanhSachThuoc(int idLoaiThuoc)
        {
            var thuocs = db.THUOCs.Where(p => p.idMaLoaiThuoc == idLoaiThuoc).ToList();
            return thuocs;
        }

        public THUOC LayThuoc(string maThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(s => s.MaThuoc == maThuoc);
            return thuoc;
        }

        public THUOC LayTenThuoc(int idThuoc)
        {
            THUOC thuoc = db.THUOCs.Find(idThuoc);
            return thuoc;
        }

        public THUOC LayThongTinThuoc(string tenThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(s => s.TenThuoc == tenThuoc);
            return thuoc;
        }
    }
}
