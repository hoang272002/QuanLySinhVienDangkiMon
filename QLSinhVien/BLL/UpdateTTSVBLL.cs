using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class UpdateTTSVBLL
    {
        UpdateTTSVDAL dl = new UpdateTTSVDAL();
        public string CapNhatTTBLL(sinhvien sv,string d,DateTime a,string b,string c)
        {
            string kq = dl.capNhatTTSVDAL(sv,d,a,b,c);
            return kq;
        }
    }
}
