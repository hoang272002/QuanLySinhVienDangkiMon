using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using DTO;

namespace DAL
{
    public class oracleConnectiondata
    {
        //tao chuoi ket noi csdl
        public static OracleConnection Connect()
        {
            string strcon = @"DATA SOURCE=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\ASUS\Oracle\network\admin;PERSIST SECURITY INFO=True;USER ID=SYS;Password=viethoang272002";
            OracleConnection conn = new OracleConnection(strcon);// khoi tao connect
            return conn;
        }
    }
    public class database
    {
        int a = 0;
        public string checkLoginDB(sinhvien sv)
        {
            string kq = "";
            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "select * from sinhvienhcmus where masv = :masv and pass = :pass";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":masv", OracleDbType.Varchar2).Value = sv.masv;
            cmd.Parameters.Add(":pass", OracleDbType.Varchar2).Value = sv.pass;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                kq = "Đăng nhập thành công!";
                return kq;
            }
            else
            {
                kq = "Đăng nhập thất bại!";
                return kq;
            }
            conn.Close();

        }
        public DataTable LoadDBSinhVienDTO(sinhvien sv)
        {
            DataTable dataTable = new DataTable();
            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "select * from sinhvienhcmus where masv = :masv";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":masv", OracleDbType.Varchar2).Value = sv.masv;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public string DoiMKDTO(sinhvien sv, string mk)
        {
           
            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "update sinhvienhcmus "+" set pass = :pass "+" where masv = :masv";
            OracleCommand cmd = new OracleCommand(sql, conn);


            OracleParameter pas = new OracleParameter();
            pas.Value = mk;
            pas.ParameterName = ":pass";

            OracleParameter sv1 = new OracleParameter();
            sv1.Value = sv.masv;
            sv1.ParameterName = ":masv";

            cmd.Parameters.Add(pas);
            cmd.Parameters.Add(sv1);

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result > 0)
            {
                return "1";
            }
            else
            {
                return "0";
            }    
        }

        public string CapNhatTTDTO(sinhvien sv,string tensv, DateTime ngaySinh, string diachi,string sdt)
        {

            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "update sinhvienhcmus " + " set tensv = :tensv, "+" ngaysinh = :ns, "+" diachi = :dc, "+" sdt = :sdt "+ " where masv = :masv";
            OracleCommand cmd = new OracleCommand(sql, conn);


            OracleParameter ns = new OracleParameter();
            ns.Value = ngaySinh;
            ns.ParameterName = ":ns";

            OracleParameter dc = new OracleParameter();
            dc.Value = diachi;
            dc.ParameterName = ":dc";

            OracleParameter dt = new OracleParameter();
            dt.Value = sdt;
            dt.ParameterName = ":sdt";

            OracleParameter ten = new OracleParameter();
            ten.Value = tensv;
            ten.ParameterName = ":tensv";

            OracleParameter sv1 = new OracleParameter();
            sv1.Value = sv.masv;
            sv1.ParameterName = ":masv";

            cmd.Parameters.Add(ten);
            cmd.Parameters.Add(ns);
            cmd.Parameters.Add(dc);
            cmd.Parameters.Add(dt);
            cmd.Parameters.Add(sv1);

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result > 0)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public string LayMaHP(sinhvien sv)
        {
            DataTable dataTable = new DataTable();

            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "select mahp from phieudkhp where masv = :masv";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":masv", OracleDbType.Varchar2).Value = sv.masv;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dataTable);
            conn.Close();

            if (dataTable.Rows.Count > 0)
            {
                string hp = dataTable.Rows[0]["MAHP"].ToString();
                return hp;
            }
            else
            {
                return "0";
            }
        }

        public DataTable LoadDBMonHocDTO()
        {
            DataTable dataTable = new DataTable();
            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "select * from monhochcmus";
            OracleCommand cmd = new OracleCommand(sql, conn);


            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public DataTable loadPhieuCT(phieuHP dk)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = oracleConnectiondata.Connect(); 
            conn.Open();
            string sql = "select m.mamh,m.tenmh,m.sotc,m.giatien from ctphieudk ct, monhochcmus m where ct.mahp = :mahp and ct.mamh = m.mamh";
            OracleCommand cmd = new OracleCommand( sql, conn);
            cmd.Parameters.Add(":mahp", OracleDbType.Varchar2).Value = dk.maHP;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public string luuPhieuCTDTO(phieuHP hp, DataTable dt)
        {
            a++;
            
            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "delete from ctphieudk where mahp = :mahp";
            OracleCommand cmd = new OracleCommand(sql,conn);
            cmd.Parameters.Add(":mahp", OracleDbType.Varchar2).Value = hp.maHP;
            int xoa = cmd.ExecuteNonQuery();

            if(xoa >= 0)
            {
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sql1 = @"
                MERGE INTO ctphieudk t
                USING (SELECT :mahp AS mahp, :maMH AS maMH FROM dual) s
                ON (t.mahp = s.mahp AND t.maMH = s.maMH)
                WHEN NOT MATCHED THEN
                    INSERT (mahp, maMH, soluong)
                    VALUES (s.mahp, s.maMH, :SL)";
                    cmd = new OracleCommand(sql1, conn);
                    cmd.Parameters.Add(":mahp", OracleDbType.Varchar2).Value = hp.maHP;
                    cmd.Parameters.Add(":maMH", OracleDbType.Varchar2).Value = dt.Rows[i]["MAMH"].ToString();
                    cmd.Parameters.Add(":SL", OracleDbType.Int64).Value = a;

                    int insertedRow = cmd.ExecuteNonQuery();

                    if (insertedRow > 0)
                    {
                        continue;
                    }
                    else
                    {
                        return "0";
                    }
                }
            }
            else
            {
                return "0";
            }
           return "1";
        }

        public string LayMaHD(phieuHP hp)
        {
            DataTable dataTable = new DataTable();

            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "select mahd from hoadon where mahp = :mahp";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(":mahp", OracleDbType.Varchar2).Value = hp.maHP;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dataTable);
            conn.Close();

            if (dataTable.Rows.Count > 0)
            {
                string a = dataTable.Rows[0]["MAHD"].ToString();
                return a;
            }
            else
            {
                return "0";
            }
        }

        public string CapNhatHDDTO(HoaDonThanhToan hd)
        {

            OracleConnection conn = oracleConnectiondata.Connect();
            conn.Open();
            string sql = "update hoadon " + " set tongtien = :tien, " + " phuongthuc = :pt " + " where mahd = :mahd";
            OracleCommand cmd = new OracleCommand(sql, conn);


            OracleParameter tien = new OracleParameter();
            tien.Value = hd.tongtien;
            tien.ParameterName = ":tien";

            OracleParameter pthuc = new OracleParameter();
            pthuc.Value = hd.phThuc;
            pthuc.ParameterName = ":pt";


            OracleParameter ma = new OracleParameter();
            ma.Value = hd.maHD;
            ma.ParameterName = ":mahd";

            cmd.Parameters.Add(tien);
            cmd.Parameters.Add(pthuc);
            cmd.Parameters.Add(ma);
           
           

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result > 0)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
    }
}
