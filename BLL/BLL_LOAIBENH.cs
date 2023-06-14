﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_LOAIBENH
    {
        DAL_LOAIBENH dLoaiBenhDAL;
        public BLL_LOAIBENH()
        {
            dLoaiBenhDAL = new DAL_LOAIBENH();
        }

        public dynamic LayDanhSachLoaiBenh()
        {
            return dLoaiBenhDAL.LayDanhSachLoaiBenh();
           
        }
        public string LayTenLoaiBenh(int maBenh)
        {
            return dLoaiBenhDAL.LayTenLoaiBenh(maBenh);
        }

        public bool ThemLoaiBenh(LOAIBENH loaiBenh)
        {
            try
            {
                dLoaiBenhDAL.ThemLoaiBenh(loaiBenh);
                return true;
            }catch(Exception)
            {
                return false;
            }
        }

        public bool CapNhatLoaiBenh(LOAIBENH loaiBenh)
        {
            if (dLoaiBenhDAL.KiemTraLoaiBenh(loaiBenh))
            {
                try
                {
                    dLoaiBenhDAL.CapNhatLoaiBenh(loaiBenh);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaLoaiBenh(LOAIBENH loaiBenh)
        {
            if (dLoaiBenhDAL.KiemTraLoaiBenh(loaiBenh))
            {
                try
                {
                    dLoaiBenhDAL.XoaLoaiBenh(loaiBenh);
                    return true;
                }catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }else { return false; }
        }

        public LOAIBENH LayThongTinLoaiBenh(string tenLB)
        {
            return dLoaiBenhDAL.LayThongTinLoaiBenh(tenLB);
        }
    }
}