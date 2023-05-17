using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoadTTMHDAL:database
    {
        public DataTable layTTMHDAL()
        {
            DataTable dt = LoadDBMonHocDTO();
            return dt;
        }
    }
}
