using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoadPhieuCTDAL:database
    {
        public DataTable loadCTdal(phieuHP dk)
        {
            DataTable dt = loadPhieuCT(dk);
            return dt;
        }
    }
}
