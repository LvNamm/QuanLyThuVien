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
    public partial class FormQuanlynhanvien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = ConnectionString.getConnectionString();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT  Username AS N'Tài khoản', Tennv AS N'Tên nhân viên', MK AS N'Mật khẩu', Vaitro AS N'Vai trò' FROM dbo.NhanVien";
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public FormQuanlynhanvien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            
            ip_ten_dn.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            ip_ten_dd.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            ip_ten_mk.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            ip_ten_vt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        public bool check_rong()
        {
            if (ip_ten_dn.Text == "" || ip_ten_dd.Text == "" || ip_ten_mk.Text == "" || ip_ten_vt.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin !!!");
                return false;
            }
            return true;
        }

        public bool check_Keys()
        {
            //SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Username FROM dbo.NhanVien WHERE Username ='" + ip_ten_dn.Text +"'";
            var check = command.ExecuteScalar();
            if (check == null)
            {             
                return true;
            }
            MessageBox.Show("Tên đăng nhập không được trùng!!!");   
            return false;
        }

        public bool check_Keys2()
        {
            //SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Username FROM dbo.NhanVien WHERE Username ='" + ip_ten_dn.Text + "'";
            var check = command.ExecuteScalar();
            if (check == null)
            {
                MessageBox.Show("Không có UseName nào như vậy !!!");
                return false;
            }           
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (check_rong() && check_Keys())
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO NhanVien VALUES( '" + ip_ten_dn.Text + "',N'" + ip_ten_dd.Text + "','" + ip_ten_mk.Text + "',N'" + ip_ten_vt.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
            }

        }

        private void btn_thaydoi_Click(object sender, EventArgs e)
        {
            if (check_rong() && check_Keys2())
            {
                command = connection.CreateCommand();
                command.CommandText = "UPDATE NhanVien SET Tennv = N'" + ip_ten_dd.Text + "',MK = '" + ip_ten_mk.Text + "',Vaitro = N'" + ip_ten_vt.Text + "' WHERE Username = '" + ip_ten_dn.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (check_rong())
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM NhanVien WHERE Username = '" + ip_ten_dn.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
            }

        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            ip_ten_dn.Text = "";
            ip_ten_dd.Text = "";
            ip_ten_mk.Text = "";
            ip_ten_vt.Text = "";
        }

        private void btn_veHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
