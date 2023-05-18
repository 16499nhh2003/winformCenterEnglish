using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace DAL
{
    public class DAL_QuanLyCTLH
    {
        public DataTable selectData()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "SELECT hocvien.id,hocvien.tenHocVien,hocvien.gioitinh,hocvien.sdt,hocvien.ngaySinh FROM hocvien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                return data;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public DataTable selectDataChecked(string idLopHoc)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "SELECT hocvien.id,hocvien.tenHocVien,hocvien.gioitinh,hocvien.sdt,hocvien.ngaySinh FROM chitietlophoc INNER JOIN hocvien ON chitietlophoc.idHocVien = hocvien.id WHERE chitietlophoc.idLopHoc like @idLopHoc";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramIdLopHoc = new SqlParameter("@idLopHoc", SqlDbType.VarChar);
                paramIdLopHoc.Value = idLopHoc;
                cmd.Parameters.Add(paramIdLopHoc);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                return data;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public void deleteData(string idLopHoc)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "DELETE FROM chitietlophoc WHERE idLopHoc like @idLopHoc";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramIdLophoc = new SqlParameter("@idLopHoc", SqlDbType.VarChar);
                paramIdLophoc.Value = idLopHoc;
                cmd.Parameters.Add(paramIdLophoc);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public void insertCTData(string idLopHoc, string idHocVien)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "INSERT INTO chitietlophoc(idLopHoc,idHocVien) VALUES (@idLopHoc,@idHocVien)";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramLopHoc = new SqlParameter("@idLopHoc", SqlDbType.VarChar);
                SqlParameter paramHocVien = new SqlParameter("@idHocVien", SqlDbType.VarChar);
                paramHocVien.Value = idHocVien;
                paramLopHoc.Value = idLopHoc;
                SqlParameter[]paramList = {paramLopHoc,paramHocVien};
                cmd.Parameters.AddRange(paramList);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
    }
}
