using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class LuuPhieuCTBLL
    {
        LuuPhieuCTDAL dal = new LuuPhieuCTDAL();
        public string luuPhieuctBLL(phieuHP hp, DataTable dt)
        {
            string h = dal.luuPhieuCTDAL(hp, dt);
            return h;
        }
    }
}
