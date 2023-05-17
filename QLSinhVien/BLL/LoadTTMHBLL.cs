using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class LoadTTMHBLL
    {
        LoadTTMHDAL dl = new LoadTTMHDAL();
        public DataTable layTTMHBLL()
        {
            DataTable dt = dl.layTTMHDAL();
            return dt;
        }
        
    }
}
