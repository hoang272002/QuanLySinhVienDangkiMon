using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DoiMKDAL:database
    {
        public string DoiMatKhauDAL(sinhvien sv, string a)
        {
            string kq = DoiMKDTO(sv,a);
            return kq;
        }
    }
}
