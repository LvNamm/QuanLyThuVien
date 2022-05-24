using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (connection.State == 0)
                {
                    connection.ConnectionString = ConnectionString.getConnectionString();
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Ngatketnoi()
        {
            if (connection.State != 0)
            {
                connection.Close();
            }
        }
        public DataTable HienDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

            Ngatketnoi();
        }
        SqlCommand command = new SqlCommand();


        public Form1()
        {
            Ketnoi();
            InitializeComponent();
            input_timkiem.Enabled = false;
            btn_search.Enabled = false;
            dem_tim_kiem();

        }


        public void tim_kiem_ten(string bang, string dk_bang, string dieuKien)
        {
            string sql = "select * from " + bang + " where " + dk_bang + " = N'" + dieuKien + "'";
            dataGridView1.DataSource = HienDL(sql);

        }
        public void tim_kiem_ma(string bang, string dk_bang, int dieuKien)
        {
            string sql = "select * from " + bang + " where " + dk_bang + " = " + dieuKien + "";
            dataGridView1.DataSource = HienDL(sql);
        }


        public void dem_tim_kiem_ten(string bang, string dk_bang, string dieuKien)
        {
            command.Connection = connection;
            command.CommandText = "select COUNT(*) from " + bang + " where " + dk_bang + " = N'" + dieuKien + "'";
            if (Convert.ToInt32(command.ExecuteScalar()) != 0)
            {
                output_demKQ.Text = command.ExecuteScalar().ToString();
            }
            else
            {
                output_demKQ.Text = "Không tìm thấy kết quả!!!";
            }
        }
        public void dem_tim_kiem_Ma(string bang, string dk_bang, int dieuKien)
        {
            command.Connection = connection;
            command.CommandText = "select COUNT(*) from " + bang + " where " + dk_bang + " = " + dieuKien + "";
            if (Convert.ToInt32(command.ExecuteScalar()) != 0)
            {
                output_demKQ.Text = command.ExecuteScalar().ToString();
            }
            else
            {
                output_demKQ.Text = "Không tìm thấy kết quả!!!";
            }
        }

        public void dem_tim_kiem()
        {
            command.Connection = connection;
            command.CommandText = "select COUNT(*) from " + "sach" + "";

            output_tongSach.Text = command.ExecuteScalar().ToString();

            command.CommandText = "select COUNT(*) from " + "Bandoc" + "";

            output_tongNgDung.Text = command.ExecuteScalar().ToString();

            command.CommandText = "select COUNT(*) from " + "MuonTra" + "";
            output_tongMuonTra.Text = command.ExecuteScalar().ToString();

        }


        bool nguoi_dung = false;
        bool ma_nguoi_dung = false;
        bool ma_sach = false;
        bool sach = false;



        private void btn_search_Click(object sender, EventArgs e)
        {

            int ip = 0;
            if (nguoi_dung)
            {
                tim_kiem_ten("Bandoc", "tenBD", input_timkiem.Text);
                dem_tim_kiem_ten("Bandoc", "tenBD", input_timkiem.Text);
            }
            if (ma_nguoi_dung)
            {
                try
                {
                    ip = Convert.ToInt32(input_timkiem.Text);
                    tim_kiem_ma("Bandoc", "MaBD", ip);
                    dem_tim_kiem_Ma("Bandoc", "MaBD", ip);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay nhap so nguyen!!!");
                    ma_nguoi_dung = false;
                    return;
                }
            }
            if (ma_sach)
            {
                try
                {
                    ip = Convert.ToInt32(input_timkiem.Text);
                    tim_kiem_ma("sach", "MaSach", ip);
                    dem_tim_kiem_Ma("sach", "MaSach", ip);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay nhap so nguyen!!!");
                    ma_sach = false;
                    return;
                }

            }
            if (sach)
            {
                tim_kiem_ten("sach", "TenSach", input_timkiem.Text);
                dem_tim_kiem_ten("sach", "TenSach", input_timkiem.Text);
            }
            nguoi_dung = false;
            ma_nguoi_dung = false;
            ma_sach = false;
            sach = false;
        }


        // khi bấm chọn lại phải đặt lại các text !!!
        private void su_kien_btn()
        {
            btn_search.Enabled = true;
            input_timkiem.Enabled = true;
            input_timkiem.Text = "";
            output_demKQ.Text = "";
            dataGridView1.DataSource = "";
        }
        private void btn_tim_ND_Click(object sender, EventArgs e)
        {
            nguoi_dung = true;
            TimKiem.Text = "Tìm kiếm theo : " + btn_tim_ND.Text;
            su_kien_btn();

        }

        private void btn_tim_MaS_Click(object sender, EventArgs e)
        {
            ma_sach = true;
            TimKiem.Text = "Tìm kiếm theo : " + btn_tim_MaS.Text;
            su_kien_btn();


        }

        private void btn_tim_TenS_Click(object sender, EventArgs e)
        {
            sach = true;
            TimKiem.Text = "Tìm kiếm theo : " + btn_tim_TenS.Text;
            su_kien_btn();

        }
        private void btn_tim_MaND_Click(object sender, EventArgs e)
        {
            ma_nguoi_dung = true;
            TimKiem.Text = "Tìm kiếm theo : " + btn_tim_MaND.Text;
            su_kien_btn();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
