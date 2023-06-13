using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BENH
    {
        QLPMTEntities db;
        public DAL_BENH()
        {
            db = new QLPMTEntities();
        }

        public dynamic LayThongTinBenh()
        {
            var dsBenh = db.BENHs.Select(s => new
            {
                s.id

            }).ToList();

            var benhs = new List<BENH>();

            foreach (var b in dsBenh)
            {
                BENH benh = db.BENHs.Find(b.id);
                benhs.Add(benh);
            }

            return benhs;
        }

        public void XoaBenh(BENH benh)
        {
            BENH b = db.BENHs.SingleOrDefault(p => p.MaBenh == benh.MaBenh);
            db.BENHs.Remove(b);
            db.SaveChanges();
        }

     

        public void ThemBenh(BENH benh)
        {
            db.BENHs.Add(benh);
            db.SaveChanges();
        }

        public void CapNhatBenh(BENH benh)
        {
            BENH b = db.BENHs.SingleOrDefault(p => p.MaBenh == benh.MaBenh);
            
            b.TenBenh = benh.TenBenh;
            b.TrieuChung = benh.TrieuChung;
            b.idMaThuocDacTri = benh.idMaThuocDacTri;
            b.idMaLoaiBenh = benh.idMaLoaiBenh;
            db.SaveChanges();
        }

        public bool KiemTraBenh(BENH benh)
        {
            try
            {
                BENH b = db.BENHs.SingleOrDefault(p => p.MaBenh == benh.MaBenh);
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        public BENH LayBenh(string maBenh)
        {
            BENH b = db.BENHs.SingleOrDefault(p => p.MaBenh == maBenh);
            return b;
        }
        public BENH LayBenh(int maBenh)
        {
            BENH b = db.BENHs.Find(maBenh);
            return b;
        }

    }
}
