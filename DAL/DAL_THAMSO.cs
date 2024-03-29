﻿using DTO;
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

        public void ThayDoiThamSo(int TienKham, int SoBenhNhanToiDa, int SoLuongThuocSapHet)
        {
            THAMSO thamSo = db.THAMSOes.Find(1);
            thamSo.TienKham = TienKham;
            thamSo.SoBenhNhanToiDa = SoBenhNhanToiDa;
            thamSo.SoLuongSapHet = SoLuongThuocSapHet;
            db.SaveChanges();
        }

      
    }
}
