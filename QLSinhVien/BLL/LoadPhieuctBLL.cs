using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoadPhieuctBLL
    {
        LoadPhieuCTDAL dl = new LoadPhieuCTDAL();
        public DataTable loadCTPhieu(phieuHP dk)
        {
            DataTable dt = dl.loadCTdal(dk);
            return dt;
        }
    }
}
