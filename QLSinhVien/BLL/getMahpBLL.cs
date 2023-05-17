using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class getMahpBLL
    {
        getMahpDAL dl = new getMahpDAL();
        public string layMahpBLL(sinhvien sv)
        {
            string h = dl.layMahpDAL(sv);
            return h;
        }
    }
}
