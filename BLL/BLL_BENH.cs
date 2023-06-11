using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_BENH
    {
        DAL_BENH dBenhDAL;
        public BLL_BENH()
        {
            dBenhDAL = new DAL_BENH();
        }

        public dynamic LayThongTinBenh()
        {
            return dBenhDAL.LayThongTinBenh();
            
        }

    }
}
