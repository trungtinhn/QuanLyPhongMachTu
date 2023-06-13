using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DANGKY
    {
        QLPMTEntities db;
        public DAL_DANGKY()
        {
            db = new QLPMTEntities();
        }

        public dynamic LayDanhSachDangKy()
        {

            var ds = db.DANGKies.Select(s => new
            {
                s.idMaBenhNhan
            });

            var result = new List<BENHNHAN>();

            foreach (var item in ds)
            {
                BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.id == item.idMaBenhNhan);
                result.Add(bn);
            }
            return result;
        }


        public void DangKyKhamBenh(DANGKY dangKy)
        {
            db.DANGKies.Add(dangKy);
            db.SaveChanges();
            var changedEntries = db.ChangeTracker.Entries<DANGKY>().Where(x => x.State != EntityState.Unchanged);
        }
    }
}
