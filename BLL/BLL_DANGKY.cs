﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_DANGKY
    {
        DAL_DANGKY dDanhKyDAL;
        public BLL_DANGKY()
        {
            dDanhKyDAL = new DAL_DANGKY();
        }

        public dynamic LayDanhSachDangKy()
        {
            return dDanhKyDAL.LayDanhSachDangKy();
        }

        public bool DangKyKhamBenh(DANGKY dangKy)
        {
            try
            {
                dDanhKyDAL.DangKyKhamBenh(dangKy);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}