using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LOAITHUOC
    {
        QLPMTEntities db;

        public DAL_LOAITHUOC()
        {
            db = new QLPMTEntities();
        }

        public dynamic LayDanhSachLoaiThuoc()
        {
            var loaiThuocs = db.LOAITHUOCs.Select(s => new
            {
                s.MaLoaiThuoc,
                s.TenLoaiThuoc
            }).ToList();

            return loaiThuocs;
        }

        public LOAITHUOC LayLoaiThuoc(string MaLoaiThuoc)
        {
            LOAITHUOC loaiThuoc = db.LOAITHUOCs.FirstOrDefault(p => p.MaLoaiThuoc == MaLoaiThuoc);
            return loaiThuoc;
        }

        public string LayTenLoaiThuoc(int idLoaiBenh)
        {
            LOAITHUOC loaiBenh = db.LOAITHUOCs.Find(idLoaiBenh);
            return loaiBenh.TenLoaiThuoc;
        }
    }
}
