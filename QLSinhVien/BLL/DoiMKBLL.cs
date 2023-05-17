using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DoiMKBLL
    {
        DoiMKDAL dl = new DoiMKDAL();
        public string DoiMatKhauBLL(sinhvien sv, string a)
        {
            string kq = dl.DoiMatKhauDAL(sv, a); 
            return kq;
        }
    }
}
