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

    public partial class FormChitietbandoc : Form
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
        public FormChitietbandoc()
        {
            InitializeComponent();

        }
        public FormChitietbandoc(Bandoc bd)
        {
            Ketnoi();
            InitializeComponent();
            Bandoc bandoc = bd;
            txtidBandoc.Text = bandoc.maBd.ToString();
            txtTenBD.Text = bandoc.tenBd;
            txtGioiTinh.Text = bandoc.gioiTinh;
            txtDiaChi.Text = bandoc.diachi;
            dtNgaySinh.Text = bandoc.ngaySinh.ToString();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM dbo.MuonTra, dbo.Bandoc WHERE dbo.MuonTra.MaBD = dbo.Bandoc.MaBD AND MuonTra.Trangthai=0 AND Bandoc.MaBD = " + bandoc.maBd;

            txtSachMuon.Text = command.ExecuteScalar().ToString();

            command.CommandText = "select count(*) from MuonTra, dbo.Bandoc where dbo.MuonTra.Mabd = dbo.Bandoc.Mabd AND dbo.Bandoc.MaBD = " +bandoc.maBd;
            txtLanMuon.Text = command.ExecuteScalar().ToString();

            command.CommandText = "select count(*) from Muontra, dbo.Bandoc where dbo.MuonTra.MaBd = dbo.Bandoc.Mabd and Trangthai = 2 AND Bandoc.MaBD = " + bandoc.maBd;
            txtTraMuon.Text = command.ExecuteScalar().ToString();

            hien_thi_bang(bandoc.maBd);
        }
        public void hien_thi_bang(int maBD)
        {
            string sql = "select MaSach AS N'Mã sách', bandoc.MaBD AS N'Mã bạn đọc',Bandoc.tenBD as N'Tên bạn đọc', Ngaymuon AS N'Ngày mượn', Ngayhentra AS N'Ngày hẹn trả', TTmuontra.Trangthai AS N'Trạng thái'  FROM TTmuontra, dbo.MuonTra, Bandoc  WHERE MaTTmuontra =MuonTra.Trangthai AND bandoc.MaBD=MuonTra.MaBD and  bandoc.MaBD =" + maBD;
            dataGridView1.DataSource = HienDL(sql);
        }
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSachMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bạn có muốn thoát khỏi màn hình", "Thông báo");
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
