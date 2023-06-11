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
    }
}
