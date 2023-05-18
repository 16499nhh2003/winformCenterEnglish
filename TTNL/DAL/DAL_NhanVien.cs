using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace DAL
{
    public class DAL_NhanVien
    {
        
        public DataTable getData()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select id,tennhanvien,gioitinh,sdt,ngaysinh,email,idChucVu from nhanvien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                cmd.CommandType = CommandType.Text;
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
        }

        public DataTable searchData(string ChucVu,string GioiTinh,string Name)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd;
                if (!string.IsNullOrEmpty(Name))
                    strCmd = "select id,tennhanvien,gioitinh,sdt,ngaysinh,email,idChucVu from nhanvien where idChucVu like @ChucVu and gioitinh like @GioiTinh and tennhanvien like @Name";
                else
                    strCmd = "select id,tennhanvien,gioitinh,sdt,ngaysinh,email,idChucVu from nhanvien where idChucVu like @ChucVu and gioitinh like @GioiTinh";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramChucVu = new SqlParameter("@ChucVu",SqlDbType.NVarChar);
                SqlParameter paramGioiTinh = new SqlParameter("@GioiTinh", SqlDbType.Int);
                SqlParameter paramName = new SqlParameter("@Name", SqlDbType.NVarChar);
                paramChucVu.Value = ChucVu;
                string bitGioiTinh;
                if(GioiTinh.CompareTo("Nam") == 0)
                {
                    bitGioiTinh = "1";
                }
                else
                {
                    bitGioiTinh = "0"; 
                }
                paramGioiTinh.Value = int.Parse(bitGioiTinh);
                paramName.Value = Name;
                SqlParameter[] paramList = { paramChucVu, paramGioiTinh, paramName };
                cmd.Parameters.AddRange(paramList);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                return data;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public string autoCreateIdNhanVien()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select max(substring(id,3,4)) from nhanvien";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                string strCheck = "select count(id) from nhanvien";
                SqlCommand cmdCheck = new SqlCommand(strCheck, _conn);
                int check = int.Parse(cmdCheck.ExecuteScalar().ToString());
                if (check == 0)
                {
                    return "NV0001";
                }
                int result = int.Parse(cmd.ExecuteScalar().ToString());
                string id = "";
                if (result >= 0 && result < 9)
                {
                    id = string.Concat("NV000", (result + 1).ToString());
                }
                else if(result >= 9 && result < 99)
                {
                    id = string.Concat("NV00", (result + 1).ToString());
                }
                else if(result >=99 && result < 999)
                {
                    id = string.Concat("NV0", (result + 1).ToString());
                }
                else if(result >= 999 && result < 9999)
                {
                    id = string.Concat("NV", (result + 1).ToString());
                }
                return id;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public void insertData(string tenNhanVien,int gioiTinh,string sdt, string ngaySinh,string email,string chucVu,string maAnh)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string id = autoCreateIdNhanVien();
                string strCmd = "INSERT INTO nhanvien(id,tennhanvien,gioitinh,sdt,ngaysinh,email,idChucVu,maAnh) VALUES (@id,@tenNhanVien,@gioiTinh,@sdt,@ngaySinh,@email,@idChucVu,@maAnh)";
                SqlCommand cmd = new SqlCommand(strCmd,_conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                SqlParameter paramTenNhanVien = new SqlParameter("tenNhanVien", SqlDbType.NVarChar);
                SqlParameter paramGioiTinh = new SqlParameter("@gioiTinh", SqlDbType.Int);
                SqlParameter paramSdt = new SqlParameter("@sdt", SqlDbType.NVarChar);
                SqlParameter paramNgaySinh = new SqlParameter("@ngaySinh", SqlDbType.Date);
                SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.NVarChar);
                SqlParameter paramIdChucVu = new SqlParameter("@idChucVu", SqlDbType.NVarChar);
                SqlParameter paramMaAnh = new SqlParameter("@maAnh",SqlDbType.NVarChar);
                paramId.Value = id;
                paramTenNhanVien.Value = tenNhanVien;
                paramGioiTinh.Value = gioiTinh;
                paramSdt.Value = sdt;
                paramNgaySinh.Value = ngaySinh;
                paramEmail.Value = email;
                paramIdChucVu.Value = chucVu;
                if(string.IsNullOrEmpty(maAnh) || maAnh.Length == 0)
                {
                    paramMaAnh.Value = DBNull.Value;
                }
                else
                    paramMaAnh.Value = maAnh;
                SqlParameter[] paramList = {paramId, paramTenNhanVien,paramGioiTinh,paramSdt,paramNgaySinh,paramEmail,paramIdChucVu,paramMaAnh};
                cmd.Parameters.AddRange(paramList);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public bool checkMaAnh(string maAnh)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select count(1) from Anh where MaAnh like @maAnh";
                SqlCommand cmd = new SqlCommand(strCmd,_conn);  
                SqlParameter paramMaAnh = new SqlParameter("@maAnh", SqlDbType.NVarChar);
                paramMaAnh.Value= maAnh;
                cmd.Parameters.Add(paramMaAnh);
                int result = int.Parse(cmd.ExecuteScalar().ToString());
                if(result == 0)
                {
                    return false;
                }
                return true;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
        public void insertAnh(string maAnh, string duongDan,string tenFile)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "exec dbo.ImportImage @maAnh,@duongDan,@tenFile ";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramMaAnh = new SqlParameter("@maAnh", SqlDbType.NVarChar);
                SqlParameter paramDuongDan = new SqlParameter("@duongDan", SqlDbType.NVarChar);
                SqlParameter paramTenFile = new SqlParameter("@tenFile", SqlDbType.NVarChar);
                paramMaAnh.Value = maAnh;
                paramDuongDan.Value = duongDan;
                paramTenFile.Value = tenFile;
                SqlParameter[] paramList = { paramMaAnh, paramDuongDan, paramTenFile };
                cmd.Parameters.AddRange(paramList);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public DTO_NhanVien getDataBaseOnId(string Id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                string strCmd = "select tennhanvien,gioitinh,sdt,email,ngaysinh,idChucVu,maAnh from nhanvien where id like @Id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id",SqlDbType.VarChar);
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    nv.TenNhanVien = read["tennhanvien"].ToString();
                    bool gioitinhBit = read.GetBoolean(read.GetOrdinal("gioitinh"));
                    nv.GioiTinh = gioitinhBit ? 1 : 0;
                    nv.Sdt = read["sdt"].ToString();
                    nv.Email = read["email"].ToString();
                    nv.NgaySinh = read["ngaysinh"].ToString();
                    nv.ChucVu = read["idChucVu"].ToString();
                    nv.MaAnh = read["maAnh"].ToString() ;
                }
                return nv;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public string getMaAnh(string idNhanVien)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select MaAnh from nhanvien where id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.NVarChar);
                paramId.Value = idNhanVien;
                cmd.Parameters.Add(paramId);
                string result = cmd.ExecuteScalar().ToString();
                return result;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
        public byte[] getAnh(string maAnh)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select AnhData from Anh where MaAnh like @maAnh";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramMaAnh = new SqlParameter("@maAnh", SqlDbType.NVarChar);
                paramMaAnh.Value = maAnh;
                cmd.Parameters.Add(paramMaAnh);
                byte[] result = (byte[])cmd.ExecuteScalar();
                return result;
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public string getDuongDan(string maAnh)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "select DuongDan from Anh where MaAnh like @maAnh";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramMaAnh = new SqlParameter("@maAnh", SqlDbType.NVarChar);
                paramMaAnh.Value = maAnh;
                cmd.Parameters.Add(paramMaAnh);
                string result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch (Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public void deleteData(string Id)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "Delete from nhanvien where id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id",SqlDbType.VarChar);
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);
                int row = cmd.ExecuteNonQuery();
            }
            catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

        public void updateData(DTO_NhanVien nv)
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                string strCmd = "Update nhanvien set tennhanvien = @tenNhanVien, gioitinh = @gioiTinh, sdt = @sdt, ngaysinh = @ngaySinh, email = @email,idChucVu = @idChucVu, MaAnh = @maAnh where id like @id";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlParameter paramId = new SqlParameter("@id", SqlDbType.VarChar);
                SqlParameter paramTenNhanVien = new SqlParameter("@tenNhanVien", SqlDbType.NVarChar);
                SqlParameter paramGioiTinh = new SqlParameter("@gioiTinh", SqlDbType.Int);
                SqlParameter paramSdt = new SqlParameter("@sdt", SqlDbType.VarChar);
                SqlParameter paramNgaySinh = new SqlParameter("@ngaySinh", SqlDbType.Date);
                SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.NVarChar);
                SqlParameter paramIdChucVu = new SqlParameter("@idChucVu", SqlDbType.NVarChar);
                SqlParameter paramMaAnh = new SqlParameter("@maAnh", SqlDbType.NVarChar);
                paramId.Value = nv.Id;
                paramTenNhanVien.Value = nv.TenNhanVien;
                paramGioiTinh.Value = nv.GioiTinh;  
                paramSdt.Value = nv.Sdt;
                paramNgaySinh.Value = nv.NgaySinh;
                paramEmail.Value = nv.Email;
                paramIdChucVu.Value = nv.ChucVu;
                if (string.IsNullOrEmpty(nv.MaAnh))
                {
                    paramMaAnh.Value = DBNull.Value;
                }
                else
                    paramMaAnh.Value = nv.MaAnh;
                SqlParameter[] paramList = {paramId,paramTenNhanVien,paramGioiTinh,paramSdt,paramNgaySinh,paramEmail,paramIdChucVu,paramMaAnh};
                cmd.Parameters.AddRange(paramList);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }

      
    }
}
