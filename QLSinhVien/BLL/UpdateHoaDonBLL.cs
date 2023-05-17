using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class UpdateHoaDonBLL
    {
        UpdateHoaDonDAL dal = new UpdateHoaDonDAL();
        public string capNhatHDBLL(HoaDonThanhToan hd)
        {
            string h = dal.capNhatHDDAL(hd);
            return h;
        }
    }
}
