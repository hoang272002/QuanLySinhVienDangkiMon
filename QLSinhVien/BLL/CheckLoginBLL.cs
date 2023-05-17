using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CheckLoginBLL
    {
        CheckLoginDAL dal = new CheckLoginDAL();
        public string ktDangNhapBLL(sinhvien sv)
        {
            if(sv.masv == "")
            {
                return "Ten tai khoan rong";
            }
            else if(sv.pass == "")
            {
                return "mk rong";
            }

            string kq = dal.ktDangNhapDAL(sv);
            return kq;
        }
    }
}
