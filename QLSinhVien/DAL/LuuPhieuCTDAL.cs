using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LuuPhieuCTDAL:database
    {
        public string luuPhieuCTDAL(phieuHP hp, DataTable dt)
        {
            string h = luuPhieuCTDTO(hp, dt);
            return h;
        }
    }
}
