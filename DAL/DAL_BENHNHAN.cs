using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BENHNHAN
    {
        QLPMTEntities db;
        public DAL_BENHNHAN()
        {
            db = new QLPMTEntities();
        }
        public dynamic LayDanhSachBenhNhan()
        {
            var danhsach = db.BENHNHANs.Select(s => new
            {
 
                s.MaBenhNhan,
                s.HoTenBenhNhan,
                s.GioiTinh,
                s.NgaySinh,
                s.DiaChi,
               
            }).ToList();

            return danhsach;
        }

        public void ThemBenhNhan(BENHNHAN benhNhan)
        {
            db.BENHNHANs.Add(benhNhan);
            db.SaveChanges();
        }

        public bool KiemTraBenhNhan(BENHNHAN benhNhan)
        {
            try
            {
                BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
               
                return true;
            }
            catch (Exception ex)
            {
              
                Console.WriteLine(ex.Message);
            }
           
            return false;
        }

        public void CapNhatBenhNhan(BENHNHAN benhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
            bn.HoTenBenhNhan = benhNhan.HoTenBenhNhan;
            bn.NgaySinh = benhNhan.NgaySinh;
            bn.DiaChi = benhNhan.DiaChi;
            bn.GioiTinh = benhNhan.GioiTinh;

            db.SaveChanges();
        }

        public void XoaBenhNhan(BENHNHAN benhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
            db.BENHNHANs.Remove(bn);
            db.SaveChanges();
        }

        public BENHNHAN LayThongTinBenhNhan(string MaBenhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.FirstOrDefault(p => p.MaBenhNhan == MaBenhNhan);
            if (bn == null)
            {
                return null;
            }
            return bn;
        }

       
    }

   
}
