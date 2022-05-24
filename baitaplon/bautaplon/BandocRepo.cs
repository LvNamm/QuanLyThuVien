using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien
{
    internal class BandocRepo
    {
        private SqlConnection conn;
        private string[] columsName = new string[] {"Mã BĐ","Tên BĐ","Giới tính","Địa chỉ","Ngày sinh"};
        public BandocRepo()
        {
            conn = new SqlConnection(ConnectionString.getConnectionString());
        }
        public DataTable getAll(){
            DataTable dtBandoc = new DataTable();
            string sql = "select * from Bandoc";
            SqlDataAdapter daBandoc = new SqlDataAdapter(sql,this.conn);
            daBandoc.Fill(dtBandoc);
            for(int i = 0; i<dtBandoc.Columns.Count; i++)
            {
                dtBandoc.Columns[i].ColumnName = columsName[i];
            }
            
            return dtBandoc;
        }
        public DataTable findById(int id)
        {
            conn.Open();
            DataTable dtBandoc = new DataTable();
            string sql = "select * from Bandoc where MaBd = " +id.ToString();
            SqlDataAdapter daBandoc = new SqlDataAdapter(sql, this.conn);
            daBandoc.Fill(dtBandoc);
            for (int i = 0; i<dtBandoc.Columns.Count; i++)
            {
                dtBandoc.Columns[i].ColumnName = columsName[i];
            }
            conn.Close();
            return dtBandoc;
        }
        public DataTable findByName(string s)
        {
            conn.Open();
            DataTable dtBandoc = new DataTable();
            string sql = "select * from Bandoc where TenBd like N'%" +s +"%'";
            SqlDataAdapter daBandoc = new SqlDataAdapter(sql, this.conn);
            daBandoc.Fill(dtBandoc);
            for (int i = 0; i<dtBandoc.Columns.Count; i++)
            {
                dtBandoc.Columns[i].ColumnName = columsName[i];
            }
            conn.Close();
            return dtBandoc;
        }
        public int getIden()
        {
            conn.Open();
            string sql = "select IDENT_CURRENT( 'Bandoc' )";
            SqlCommand Command = new SqlCommand(sql,conn);
            int retValue = Convert.ToInt32(Command.ExecuteScalar());
            conn.Close();
            return retValue+1;
        }
        public string insertBandoc(Bandoc bandoc)
        {
            try
            {
                conn.Open();
                string saveStaff = "INSERT into Bandoc VALUES (@tenBandoc,@gioitinh,@diachi,@ngayinh)";
                SqlCommand querySaveStaff = new SqlCommand(saveStaff, conn);
                querySaveStaff.Parameters.AddWithValue("@tenBandoc",bandoc.tenBd);
                querySaveStaff.Parameters.AddWithValue("@gioitinh",bandoc.gioiTinh);
                querySaveStaff.Parameters.AddWithValue("@diachi",bandoc.diachi);
                querySaveStaff.Parameters.AddWithValue("@ngayinh", bandoc.ngaySinh);
                querySaveStaff.ExecuteNonQuery();
                conn.Close();
                return "Thêm thành công";
            }
            catch(SqlException ex)
            {
                conn.Close();
                return "Thêm thất bại";
            }
        }
        public string updateBandoc(Bandoc bandoc)
        {
            try
            {
                conn.Open();
                string query = "update Bandoc "+
                                    "set TenBd = @tenBd,"+
                                    "gioitinh = @gioitinh,"+
                                    "diachi = @diachi,"+
                                    "ngaysinh = @ngaysinh "+
                                    "where MaBd = @Mabd";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TenBd",bandoc.tenBd);
                command.Parameters.AddWithValue("@gioitinh",bandoc.gioiTinh);
                command.Parameters.AddWithValue("@diachi",bandoc.diachi);
                command.Parameters.AddWithValue("@ngaysinh",bandoc.ngaySinh);
                command.Parameters.AddWithValue("@Mabd",bandoc.maBd);
                command.ExecuteNonQuery();
                conn.Close();
                return "Chỉnh sửa thành công";
            }
            catch(SqlException ex)
            {
                conn.Close();
                return "Chỉnh sửa thất bại";
            }
        }
        public string deleteById(int id)
        {
            try
            {
                conn.Open();
                string query = "select count(*) from muontra where MaBd = @Mabd and trangthai = 0";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Mabd", id);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count >=1)
                    throw new MyException("Không thể xóa do bạn đọc chưa trả hết sách");
                query = "delete from Bandoc where Mabd = @mabd";
                command = new SqlCommand(query, conn);
                command.Parameters.Add("@mabd", SqlDbType.NVarChar, 30).Value=id;
                command.ExecuteNonQuery();
                conn.Close();
                return "Xóa thành công";
            }
            catch(SqlException ex)
            {
                conn.Close();
                return "Xóa thất bại";
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
