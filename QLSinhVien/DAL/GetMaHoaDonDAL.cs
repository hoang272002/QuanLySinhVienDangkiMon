using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GetMaHoaDonDAL:database
    {
        public string layMaHDDAL(phieuHP hp)
        {
            string h = LayMaHD(hp);
            return h;
        }
    }
}
