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
    public partial class FormMenuchucnang : Form
    {
        SqlConnection connection = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = ConnectionString.getConnectionString();
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        public void Ngatketnoi()
        {
            if (connection.State == ConnectionState.Open)
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
        public FormMenuchucnang()
        {
            Ketnoi();

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool check_Null()
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Hãy nhập username");
                return false;
            }
            if(textBox2.Text=="")
            {
                MessageBox.Show("Hãy nhập password");
                return false;
            }
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Hãy nhập vai trò");
                return false;
            }
            return true;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (check_Null())
            {
                String username = textBox1.Text;
                String password = textBox2.Text;
                
                command.Connection = connection;
                command.CommandText = "select vaitro from NhanVien where Username = '" + username + "' and MK='" + password + "'";

                String Vaitro = "";
                Object a = command.ExecuteScalar();
                if (a==null)
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    return;
                }
                else
                {
                    Vaitro = a.ToString();
                }

                command.Connection = connection;
                command.CommandText = "select count(*) from NhanVien where Username = '" + username + "' and MK='" + password + "'";
                if (Convert.ToInt32(command.ExecuteScalar()) == 1 && Vaitro == "Nhân viên" && Vaitro == comboBox1.Text)
                {

                    //btLogin.Enabled = false;
                    MessageBox.Show("Đăng nhập thành công");
                    plTinhNang.Visible = true;
                    panel2.Visible = true;
                    pictureBox1.Visible = true;
                    plDangNhap.Visible = false;
                    command.CommandText = "select Tennv from NhanVien where Username = '" + username + "' and MK='" + password + "'";
                    textBox3.Text = command.ExecuteScalar().ToString();
                    command.CommandText = "select Username from NhanVien where Username = '" + username + "' and MK='" + password + "'";
                    textBox4.Text = command.ExecuteScalar().ToString();
                    command.CommandText = "select vaitro from NhanVien where Username = '" + username + "' and MK = '" + password + "'";
                    button5.Visible = false;
                    this.BackgroundImage = null;

                }

                else if (Convert.ToInt32(command.ExecuteScalar()) == 1 && Vaitro == "Quản lý" && Vaitro == comboBox1.Text)
                {

                   
                    MessageBox.Show("Đăng nhập thành công");
                    plTinhNang.Visible = true;
                    panel2.Visible = true;
                    pictureBox1.Visible = true;
                    plDangNhap.Visible = false;
                    command.CommandText = "select Tennv from NhanVien where Username = '" + username + "' and MK='" + password + "'";
                    textBox3.Text = command.ExecuteScalar().ToString();
                    command.CommandText = "select Username from NhanVien where Username = '" + username + "' and MK='" + password + "'";
                    textBox4.Text = command.ExecuteScalar().ToString();
                    command.CommandText = "select vaitro from NhanVien where Username = '" + username + "' and MK = '" + password + "'";
                    button5.Visible = true;
                    this.BackgroundImage = null;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không","Thông báo",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                pictureBox1.Visible = false;
                plTinhNang.Visible = false;
                panel2.Visible = false;
                plDangNhap.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void plDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormQuanlynhanvien a = new FormQuanlynhanvien();
            a.FormBorderStyle = FormBorderStyle.FixedSingle;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMuonTraSach a = new FormMuonTraSach();
            a.FormBorderStyle = FormBorderStyle.FixedSingle;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLBD a = new QLBD();
            a.FormBorderStyle = FormBorderStyle.FixedSingle;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.FormBorderStyle = FormBorderStyle.FixedSingle;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormQuanLySach a = new FormQuanLySach();
            a.FormBorderStyle = FormBorderStyle.FixedSingle;
            a.StartPosition = FormStartPosition.CenterScreen;
            a.ShowDialog();
        }
    }
}
