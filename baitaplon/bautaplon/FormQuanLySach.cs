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
    public partial class FormQuanLySach : Form
    {
<<<<<<< HEAD
        private string[] columsName = new string[] { "Mã Sách", "Tên Sách", "Tên tác giả", "Trạng thái"};
=======
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
        public FormQuanLySach()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
        private void LoadDgv()
        {
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();
            string sql = "select MaSach,TenSach,tentacgia,TTSach.Trangthai from Sach, TTSach where Sach.Trangthai = TTsach.MaTT";
            SqlDataAdapter daSach = new SqlDataAdapter(sql, conn);
            DataTable dtSach = new DataTable();
            daSach.Fill(dtSach);
<<<<<<< HEAD
            for (int i = 0; i<dtSach.Columns.Count; i++)
            {
                dtSach.Columns[i].ColumnName = columsName[i];
            }
            dgvSach.Columns.Clear();
            dgvSach.DataSource = dtSach;
            dgvSach.Columns[1].Width = 140;
            dgvSach.Columns[2].Width = 100;
            dgvSach.Columns[0].Width = 90;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "button";
                button.HeaderText = "";
                button.Text = "Sửa";
                button.UseColumnTextForButtonValue = true;
                this.dgvSach.Columns.Add(button);
            }
            dgvSach.Columns[dgvSach.Columns.Count-1].Width = 35;

            DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
            {
                button1.Name = "button1";
                button1.HeaderText = "";
                button1.Text = "Xóa";
                button1.UseColumnTextForButtonValue = true;
                this.dgvSach.Columns.Add(button1);
            }
            dgvSach.Columns[dgvSach.Columns.Count-1].Width = 35;
=======
            dgvSach.DataSource = dtSach;
            dgvSach.Columns[1].Width = 150;
            dgvSach.Columns[2].Width = 150;
            dgvSach.Columns[0].Width = 90;
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
        }
        private void Reset()
        {

            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();
            string sql = "select IDENT_CURRENT('Sach')";
            SqlCommand command = new SqlCommand(sql, conn);
            int getValue = Convert.ToInt32(command.ExecuteScalar()) + 1;

            textBox2.Text = textBox3.Text = "";

            textBox1.Text = getValue.ToString();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            textBox4.Text = "Trong thư viện";
            btnLuu.Enabled = true;
        }
        private void FormQuanLySach_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();
            string sql = "select IDENT_CURRENT('Sach')";
            SqlCommand command = new SqlCommand(sql, conn);
            int getValue = Convert.ToInt32(command.ExecuteScalar()) + 1;
            textBox1.Text = getValue.ToString();
            LoadDgv();
            conn.Close();
        }

        private void dgvSach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if(textBox4.Text == "Trong thư viện")
            {
                SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
                conn.Open();
                string sql = "Delete from MuonTra where MaSach= " + textBox1.Text;
                SqlCommand Command = new SqlCommand(sql, conn);
                
                Command.ExecuteNonQuery();

                sql = "Delete from Sach where MaSach= " + textBox1.Text;
                Command = new SqlCommand(sql, conn);
                
                Command.ExecuteNonQuery();
                LoadDgv();
                Reset();

            }
            else
            {
                MessageBox.Show("Sách đang được mượn, bạn không được phép xóa!");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin");
                return; 
            }
<<<<<<< HEAD
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();
=======


            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();

>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            string sql = "Insert into Sach values ( @TenSach, @TenTacGia, 1 )";
            SqlCommand Command = new SqlCommand(sql, conn);
            Command.Parameters.AddWithValue("@TenSach", textBox3.Text);
            Command.Parameters.AddWithValue("@TenTacGia", textBox2.Text);
<<<<<<< HEAD
=======
            
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            Command.ExecuteNonQuery();
            MessageBox.Show("Bạn đã thêm thành công sách");
            Reset();
            LoadDgv();
<<<<<<< HEAD
=======
            
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin");
                return;
            }
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();
            string sql = "Update  Sach set TenSach = @TenSach , TenTacGia = @TenTacGia where MaSach = "+textBox1.Text;
            SqlCommand Command = new SqlCommand(sql, conn);
            Command.Parameters.AddWithValue("@TenSach", textBox3.Text);
            Command.Parameters.AddWithValue("@TenTacGia", textBox2.Text);
<<<<<<< HEAD
            Command.ExecuteNonQuery();
            MessageBox.Show("Sửa thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
=======

            Command.ExecuteNonQuery();
            MessageBox.Show("Bạn đã chỉnh sửa thành công!");
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            LoadDgv();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            
                if (comboBox.SelectedIndex == 0)
                {
                    SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
                    conn.Open();
                    string sql = "select MaSach,TenSach,tentacgia,TTSach.Trangthai from Sach, TTSach where Sach.Trangthai = TTsach.MaTT and MaSach = " + txtTimKiem.Text;
                    SqlDataAdapter daSach = new SqlDataAdapter(sql, conn);
                    DataTable dtSach = new DataTable();
                    daSach.Fill(dtSach);
<<<<<<< HEAD
                    for (int i = 0; i<dtSach.Columns.Count; i++)
                    {
                        dtSach.Columns[i].ColumnName = columsName[i];
                    }
                    dgvSach.Columns.Clear();
                    dgvSach.DataSource = dtSach;
                    dgvSach.Columns[1].Width = 140;
                    dgvSach.Columns[2].Width = 100;
                    dgvSach.Columns[0].Width = 90;
                    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                    {
                        button.Name = "button";
                        button.HeaderText = "";
                        button.Text = "Sửa";
                        button.UseColumnTextForButtonValue = true;
                        this.dgvSach.Columns.Add(button);
                    }
                    dgvSach.Columns[dgvSach.Columns.Count-1].Width = 35;

                    DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
                    {
                        button1.Name = "button1";
                        button1.HeaderText = "";
                        button1.Text = "Xóa";
                        button1.UseColumnTextForButtonValue = true;
                        this.dgvSach.Columns.Add(button1);
                    }
                    dgvSach.Columns[dgvSach.Columns.Count-1].Width = 35;
=======
                    dgvSach.DataSource = dtSach;
                    dgvSach.Columns[1].Width = 150;
                    dgvSach.Columns[2].Width = 150;
                    dgvSach.Columns[0].Width = 90;

>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
                }
                if (comboBox.SelectedIndex == 1)
                {
                    SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
                    conn.Open();
                    string sql = "select MaSach,TenSach,tentacgia,TTSach.Trangthai from Sach, TTSach where Sach.Trangthai = TTsach.MaTT and TenSach like N'%" + txtTimKiem.Text+"%'";
                    SqlDataAdapter daSach = new SqlDataAdapter(sql, conn);
                    DataTable dtSach = new DataTable();
                    daSach.Fill(dtSach);
                    dgvSach.DataSource = dtSach;
                    dgvSach.Columns[1].Width = 150;
                    dgvSach.Columns[2].Width = 150;
                    dgvSach.Columns[0].Width = 90;

                }
            

           
        }
<<<<<<< HEAD

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                textBox1.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }

            if (e.ColumnIndex == 6)
            {
                dgvSach.Rows.RemoveAt(e.RowIndex);
            }
        }
=======
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
    }
}
