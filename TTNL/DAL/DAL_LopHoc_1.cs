using Microsoft.SqlServer.Server;
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
    public class DAL_LopHoc_1
    {
        public List<DTO_Part_KhoaHoc> selectKhoaHoc()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                List<DTO_Part_KhoaHoc> list = new List<DTO_Part_KhoaHoc>();
                string strCmd = "SELECT * FROM khoahoc";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string id = reader.GetString(reader.GetOrdinal("id"));
                    string tenKhoaHoc = reader.GetString(reader.GetOrdinal("tenKhoaHoc"));
                    bool isDuplicate = false;
                    for(int i = 0;i < list.Count;i++)
                    {
                        if (tenKhoaHoc.CompareTo(list[i].TenKhoaHoc) == 0)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate) 
                        list.Add(new DTO_Part_KhoaHoc(id, tenKhoaHoc));
                }
                return list;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public List<DTO_Part_PhongHoc> selectPhongHoc() {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                List<DTO_Part_PhongHoc> list = new List<DTO_Part_PhongHoc>();
                string strCmd = "SELECT id,tenPhongHoc FROM phonghoc";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string id = reader.GetString(reader.GetOrdinal("id"));
                    string tenPhongHoc = reader.GetString(reader.GetOrdinal("tenPhongHoc"));
                    list.Add(new DTO_Part_PhongHoc(id, tenPhongHoc));
                }
                return list;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
        public string autoCreateId()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string id = "L001";
                string strCmd = "SELECT MAX(SUBSTRING(id,2,3)) FROM lophoc";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                string strCmdChecked = "SELECT COUNT(id) FROM lophoc";
                SqlCommand cmdChecked = new SqlCommand(strCmdChecked,_conn);    
                int count = int.Parse(cmdChecked.ExecuteScalar().ToString());
                if (count == 0)
                    id = "L001";
                else
                {
                    int max = int.Parse(cmd.ExecuteScalar().ToString());
                    if (0 < max && max < 9)
                        id = string.Concat("L00", (max + 1).ToString());
                    if(9 <= max && max < 99)
                        id = string.Concat("L0",(max + 1).ToString());  
                    if(99 <= max && max < 999)
                        id = string.Concat("L",(max + 1).ToString());   
                }
                return id;
            }catch(Exception ex ) { throw ex; }
            finally { _conn.Close(); }
        }
        public void insertData(DTO_LopHoc_1 lopHoc)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "INSERT INTO lophoc(id,idGiangVien,idKhoaHoc,idNhanVien,idPhongHoc,tenLophoc,tinhtrang) VALUES (@id,@idGiangVien,@idKhoaHoc,@idNhanVien,@idPhongHoc,@tenLopHoc,@tinhtrang)";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                SqlParameter paramIdGiangVien = new SqlParameter("@idGiangVien", SqlDbType.VarChar);
                SqlParameter paramIdKhoaHoc = new SqlParameter("@idKhoaHoc",SqlDbType.VarChar);
                SqlParameter paramIdPhongHoc = new SqlParameter("@idPhongHoc", SqlDbType.VarChar);
                SqlParameter paramIdNhanVien = new SqlParameter("@idNhanVien", SqlDbType.VarChar);
                SqlParameter paramTenLopHoc = new SqlParameter("@tenLopHoc", SqlDbType.NVarChar);
                SqlParameter paramTinhTrang = new SqlParameter("@tinhtrang", SqlDbType.VarChar);
                paramId.Value = lopHoc.IdLopHoc;
                paramIdGiangVien.Value = lopHoc.IdGiangVien;
                paramIdKhoaHoc.Value = lopHoc.IdKhoaHoc;
                paramIdPhongHoc.Value = lopHoc.IdPhongHoc;
                if(!string.IsNullOrEmpty(lopHoc.IdTroGiang))
                    paramIdNhanVien.Value = lopHoc.IdTroGiang;
                else
                    paramIdNhanVien.Value = DBNull.Value;
                paramTenLopHoc.Value = lopHoc.TenLopHoc;
                paramTinhTrang.Value = lopHoc.TinhTrang;
                SqlParameter[] paramList = {paramId,paramIdGiangVien,paramIdKhoaHoc,paramIdPhongHoc,paramIdNhanVien,paramTenLopHoc,paramTinhTrang};
                cmd.Parameters.AddRange(paramList);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public DataTable selectData()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                DataTable dt = new DataTable();
                string strCmd = "SELECT * FROM lophoc";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }  
        }

        public void deleteData(string id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "DELETE FROM lophoc WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                paramId.Value = id;
                cmd.Parameters.Add(paramId);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }  
            finally { _conn.Close(); }
        }

        public DTO_LopHoc_1 selectLop(string id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                DTO_LopHoc_1 lopHoc = new DTO_LopHoc_1();
                string strCmd = "SELECT * FROM lophoc WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id",SqlDbType.VarChar);
                paramId.Value = id;
                cmd.Parameters.Add(paramId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lopHoc.IdLopHoc = id;
                    if (reader.IsDBNull(reader.GetOrdinal("idGiangVien")))
                        lopHoc.IdGiangVien = "";
                    else
                        lopHoc.IdGiangVien = reader.GetString(reader.GetOrdinal("idGiangVien"));
                    if (reader.IsDBNull(reader.GetOrdinal("idKhoaHoc")))
                        lopHoc.IdKhoaHoc = "";
                    else
                        lopHoc.IdKhoaHoc = reader.GetString(reader.GetOrdinal("idKhoaHoc"));
                    if (reader.IsDBNull(reader.GetOrdinal("idNhanVien")))
                        lopHoc.IdTroGiang = "";
                    else
                        lopHoc.IdTroGiang = reader.GetString(reader.GetOrdinal("idNhanVien"));
                    if (reader.IsDBNull(reader.GetOrdinal("idPhongHoc")))
                        lopHoc.IdPhongHoc = "";
                    else
                        lopHoc.IdPhongHoc = reader.GetString(reader.GetOrdinal("idPhongHoc"));
                    lopHoc.TenLopHoc = reader.GetString(reader.GetOrdinal("tenLopHoc"));
                    lopHoc.TinhTrang = reader.GetString(reader.GetOrdinal("tinhTrang"));
                }
                return lopHoc;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
    }
}
