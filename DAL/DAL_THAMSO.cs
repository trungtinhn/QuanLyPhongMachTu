using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_THAMSO
    {
        QLPMTEntities db;
        public DAL_THAMSO()
        {
            db = new QLPMTEntities();
        }

        public THAMSO LayThamSo(int id) 
        {
            return db.THAMSOes.Find(id);
        }
    }
}
