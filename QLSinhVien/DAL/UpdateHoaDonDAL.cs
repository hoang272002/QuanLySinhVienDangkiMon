using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UpdateHoaDonDAL:database
    {
        public string capNhatHDDAL(HoaDonThanhToan hd)
        {
            string h = CapNhatHDDTO(hd);
            return h;
        }
    }
}
