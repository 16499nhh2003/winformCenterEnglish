using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_GiaoVien
    {
       public void insertData(DTO_GiaoVien gv)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "INSERT INTO giangvien(id,tenGiangVien,ngaySinh,cccd,sdt,gioitinh,diachi,giaTheoGio,loaiGiangVien) VALUES (@id,@tenGv,@ngaySinh,@cccd,@sdt,@gioiTinh,@diaChi,@giaTheoGio,@loaiGiangVien)";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                SqlParameter paramTenGiangVien = new SqlParameter("@tenGv", SqlDbType.NVarChar);
                SqlParameter paramNgaySinh = new SqlParameter("@ngaySinh", SqlDbType.Date);
                SqlParameter paramCCCD = new SqlParameter("@cccd", SqlDbType.VarChar);
                SqlParameter paramSDT = new SqlParameter("@sdt", SqlDbType.VarChar);
                SqlParameter paramGioiTinh = new SqlParameter("@gioiTinh", SqlDbType.Bit);
                SqlParameter paramDiaChi = new SqlParameter("@diaChi", SqlDbType.VarChar);
                SqlParameter paramLoaiGiaoVien = new SqlParameter("@loaiGiangVien", SqlDbType.VarChar);
                SqlParameter paramGiaTheoGio = new SqlParameter("@giaTheoGio", SqlDbType.Int);
                paramId.Value = gv.MaGiaoVien;
                paramTenGiangVien.Value = gv.TenGiaoVien;
                paramNgaySinh.Value = gv.NgaySinh;
                paramCCCD.Value = gv.CCCD;
                paramSDT.Value = gv.SDT;
                paramGioiTinh.Value = gv.GioiTinh;
                if(!string.IsNullOrEmpty(gv.DiaChi))
                    paramDiaChi.Value = gv.DiaChi;
                else 
                    paramDiaChi.Value = DBNull.Value;
                paramLoaiGiaoVien.Value = gv.LoaiGiaoVien;
                paramGiaTheoGio.Value = gv.GiaTheoGio;
                SqlParameter[] listParam = { paramId, paramTenGiangVien, paramNgaySinh, paramCCCD, paramSDT, paramGioiTinh, paramDiaChi, paramLoaiGiaoVien, paramGiaTheoGio };
                cmd.Parameters.AddRange(listParam);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public void deleteGiaoVien(string id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "DELETE FROM giangvien WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramID = new SqlParameter("@id", SqlDbType.VarChar);
                paramID.Value = id;
                cmd.Parameters.Add(paramID);
                int rows = cmd.ExecuteNonQuery();   
            } catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public DataTable selectGiaoVien()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                DataTable dt = new DataTable();
                string strCmd = "SELECT id,tenGiangVien,ngaySinh,cccd,sdt,gioitinh,diachi,giaTheoGio,loaiGiangVien FROM giangvien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlDataAdapter adapter= new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public string selectTenLoaiGV(string ma)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "SELECT ten FROM loaigiangvien where id like @ma";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramMa = new SqlParameter("@ma",SqlDbType.VarChar);
                paramMa.Value = ma; 
                cmd.Parameters.Add(paramMa);
                string rs = cmd.ExecuteScalar().ToString();
                return rs;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
        public void updateGiaoVien(DTO_GiaoVien gv)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "UPDATE giangvien SET tenGiangVien = @tenGiangVien,ngaySinh = @ngaySinh,cccd = @cccd,sdt = @sdt, gioitinh = @gioiTinh,diachi = @diaChi,giaTheoGio = @giaTheoGio,loaiGiangVien = @loaiGiangVien WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                SqlParameter paramTenGiangVien = new SqlParameter("@tenGiangVien", SqlDbType.NVarChar);
                SqlParameter paramNgaySinh = new SqlParameter("@ngaySinh", SqlDbType.Date);
                SqlParameter paramCCCD = new SqlParameter("@cccd", SqlDbType.VarChar);
                SqlParameter paramSDT = new SqlParameter("@sdt", SqlDbType.VarChar);
                SqlParameter paramGioiTinh = new SqlParameter("@gioiTinh", SqlDbType.Bit);
                SqlParameter paramDiaChi = new SqlParameter("@diaChi", SqlDbType.VarChar);
                SqlParameter paramLoaiGiaoVien = new SqlParameter("@loaiGiangVien", SqlDbType.VarChar);
                SqlParameter paramGiaTheoGio = new SqlParameter("@giaTheoGio", SqlDbType.Int);
                paramId.Value = gv.MaGiaoVien;
                paramTenGiangVien.Value = gv.TenGiaoVien;
                paramNgaySinh.Value = gv.NgaySinh;
                paramCCCD.Value = gv.CCCD;
                paramSDT.Value = gv.SDT;
                paramGioiTinh.Value = gv.GioiTinh;
                if (!string.IsNullOrEmpty(gv.DiaChi))
                    paramDiaChi.Value = gv.DiaChi;
                else
                    paramDiaChi.Value = DBNull.Value;
                paramLoaiGiaoVien.Value = gv.LoaiGiaoVien;
                paramGiaTheoGio.Value = gv.GiaTheoGio;
                SqlParameter[] listParam = { paramId, paramTenGiangVien, paramNgaySinh, paramCCCD, paramSDT, paramGioiTinh, paramDiaChi, paramLoaiGiaoVien, paramGiaTheoGio };
                cmd.Parameters.AddRange(listParam);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
        public string autoCreateIdGiaoVien()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select max(substring(id,3,4)) from giangvien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                string strCheck = "select count(id) from giangvien";
                SqlCommand cmdCheck = new SqlCommand(strCheck, _conn);
                int check = int.Parse(cmdCheck.ExecuteScalar().ToString());
                if (check == 0)
                {
                    return "GV0001";
                }
                int result = int.Parse(cmd.ExecuteScalar().ToString());
                string id = "";
                if (result >= 0 && result < 9)
                {
                    id = string.Concat("GV000", (result + 1).ToString());
                }
                else if (result >= 9 && result < 99)
                {
                    id = string.Concat("GV00", (result + 1).ToString());
                }
                else if (result >= 99 && result < 999)
                {
                    id = string.Concat("GV0", (result + 1).ToString());
                }
                else if (result >= 999 && result < 9999)
                {
                    id = string.Concat("GV", (result + 1).ToString());
                }
                return id;
            }
            catch (Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public List<DTO_LoaiGiangVien> selectLoaiGiangVien()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                List<DTO_LoaiGiangVien> listLGV = new List<DTO_LoaiGiangVien>();
                string strCmd = "SELECT * FROM loaiGiangVien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlDataReader reader = cmd.ExecuteReader(); 
                while(reader.Read())
                {
                    string ma = reader.GetString(0);
                    string ten = reader.GetString(1);
                    listLGV.Add(new DTO_LoaiGiangVien(ma, ten));
                }
                return listLGV;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public DTO_GiaoVien selectGV(string id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                DTO_GiaoVien gv = new DTO_GiaoVien();
                string strCmd = "SELECT * FROM giangvien WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                paramId.Value= id;
                cmd.Parameters.Add(paramId);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string ten = reader.GetString(reader.GetOrdinal("tenGiangVien"));
                    string ngaySinh = reader.GetDateTime(reader.GetOrdinal("ngaySinh")).ToString();
                    string cccd = reader.GetString(reader.GetOrdinal("cccd"));
                    string sdt = reader.GetString(reader.GetOrdinal("sdt"));
                    int gioitinh = 1;
                    if (reader.GetBoolean(reader.GetOrdinal("gioiTinh")))
                        gioitinh = 1;
                    else
                        gioitinh = 0;
                    string diachi = reader.GetString(reader.GetOrdinal("diaChi"));
                    string loaiGv = reader.GetString(reader.GetOrdinal("loaiGiangVien"));
                    int giaTheoGio = reader.GetInt32(reader.GetOrdinal("giaTheoGio"));
                    gv = new DTO_GiaoVien(id, ten, ngaySinh, cccd, sdt, gioitinh, diachi, giaTheoGio, loaiGv);
                }
                return gv;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public string getLoaiGV(string id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "SELECT ten FROM loaiGiangVien WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd,_conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.NVarChar);
                paramId.Value = id;
                cmd.Parameters.Add(paramId);
                string rs = cmd.ExecuteScalar().ToString();
                return rs;
            }catch(Exception ex) { throw ex; }  
            finally { _conn.Close(); }
        }
        public DataTable searchBMaGv(string maGv)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "SELECT * FROM giangvien WHERE id like @id";
                SqlCommand cmd = new SqlCommand(strCmd,_conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                paramId.Value = maGv;
                cmd.Parameters.Add(paramId);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                return data;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
        public DataTable searchBTenGv(string tengiangvien)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "SELECT * FROM giangvien WHERE tenGiangVien like @tengiangvien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramTen = new SqlParameter("@tengiangvien", SqlDbType.NVarChar);
                paramTen.Value = tengiangvien;
                cmd.Parameters.Add(paramTen);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

    }
}
