using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CheckLoginDAL:database
    {
        public string ktDangNhapDAL(sinhvien sv)
        {
            string kq = checkLoginDB(sv);
            return kq;
        }

    }
}
