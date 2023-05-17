using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class getMahpDAL:database
    {
        public string layMahpDAL(sinhvien sv)
        {
            string h = LayMaHP(sv);
             return h;
        }
    }
}
