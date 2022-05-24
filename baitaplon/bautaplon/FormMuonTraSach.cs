<<<<<<< HEAD
﻿using System;
=======
﻿using bautaplon;
using System;
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
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
    public partial class FormMuonTraSach : Form
    {

        public FormMuonTraSach()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void btnXacNhan1_Click(object sender, EventArgs e)
        {

            try
            {
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();

            string sql = "select count(*) from Sach where MaSach = " + txtMaSach.Text;
            SqlCommand Command = new SqlCommand(sql, conn);
            int countMasach = Convert.ToInt32(Command.ExecuteScalar());

            if (countMasach == 0)
            {
                MessageBox.Show("Sách không tồn tại");
                txtMaSach.Text = "";
            }
            else
            {
                sql = "select trangthai from Sach where MaSach = " + txtMaSach.Text;
                Command = new SqlCommand(sql, conn);
                int trangthai = Convert.ToInt32(Command.ExecuteScalar());
            

                if (trangthai == 1)
                {

                    sql = "select tensach, tentacgia from Sach where MaSach = " + txtMaSach.Text;
                    Command = new SqlCommand(sql, conn);
                    SqlDataReader sdr = Command.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtTenSach.Text = sdr["TenSach"].ToString();

                        txtTenTg.Text = sdr["TenTacGia"].ToString();
                    }

                    txtMaSach.ReadOnly = true;

                    if (txtMaNguoiMuon.ReadOnly == true)
                    {
                        btnXacNhanMuon.Enabled = true;
                    }

                }
                else
                    MessageBox.Show("Sách đang được cho mượn");

            }
            }
            catch(Exception)
            {
                MessageBox.Show("Hãy nhập Mã người mượn là một số nguyên!");
            }
           
        }

        private void btnXacNhan2_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();

            string sql = "select count(*) from BanDoc where MaBD = " + txtMaNguoiMuon.Text;
            SqlCommand Command = new SqlCommand(sql, conn);
            int countMaBD = Convert.ToInt32(Command.ExecuteScalar());

            if (countMaBD == 0)
            {
                MessageBox.Show("Bạn đọc không tồn tại");
                txtMaNguoiMuon.Text ="";
            }
            else
            {
                sql = "select tenBD, GioiTinh, diachi from BanDoc where MaBD = " + txtMaNguoiMuon.Text;
                Command = new SqlCommand(sql, conn);
                SqlDataReader sdr = Command.ExecuteReader();
                while (sdr.Read())
                {

                    txtTenNguoiMuon.Text = sdr["tenBD"].ToString();

                    txtGioiTinh.Text = sdr["GioiTinh"].ToString();
                    txtQue.Text = sdr["diachi"].ToString();
                }


                txtMaNguoiMuon.ReadOnly = true;

                if(txtMaSach.ReadOnly == true)
                {
                    btnXacNhanMuon.Enabled = true;
                }
                
            }
            }
            catch(Exception )
            {
                MessageBox.Show("Hãy nhập Mã sách là một số nguyên!");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtMaSach.Text = txtTenSach.Text = txtTenTg.Text=txtTenNguoiMuon.Text=txtGioiTinh.Text=txtQue.Text="";
            txtMaNguoiMuon.Text = "";
            txtMaSach.ReadOnly = false;
            txtMaNguoiMuon.ReadOnly = false;
            btnXacNhanMuon.Enabled = false;

        }

        private void btnXacNhanMuon_Click(object sender, EventArgs e)
        {

            int masach = Convert.ToInt32(txtMaSach.Text);
            int manguoimuon = Convert.ToInt32(txtMaNguoiMuon.Text);
            DateTime ngaymuon = dateTimePickerNgayMuon.Value;
            DateTime ngaytra = dateTimePickerNgayTra.Value;

            if(ngaytra < ngaymuon)
            {
                MessageBox.Show("Dữ liệu ngày tháng chưa chính xác");
                return;
            }
          
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();

            string sql = "Insert into MuonTra values ( @MaBD, @MaSach, @ngaymuon, @ngayhentra, 0 )";
            SqlCommand Command = new SqlCommand(sql, conn);
            Command.Parameters.AddWithValue("@MaBD", manguoimuon);
            Command.Parameters.AddWithValue("@MaSach", masach);

            Command.Parameters.AddWithValue("@ngaymuon", ngaymuon);
            Command.Parameters.AddWithValue("@ngayhentra", ngaytra);
            Command.ExecuteNonQuery();
           

            //
            sql = "Update sach set TrangThai = 0 where MaSach = @MaSach";
            Command = new SqlCommand(sql, conn);
          
            Command.Parameters.AddWithValue("@MaSach", masach);
            Command.ExecuteNonQuery();
            MessageBox.Show("Bạn đã mượn thành công sách","Xác nhận");

            txtMaSach.Text = txtTenSach.Text = txtTenTg.Text = txtTenNguoiMuon.Text = txtGioiTinh.Text = txtQue.Text = "";
            txtMaNguoiMuon.Text = "";
            txtMaSach.ReadOnly = false;
            txtMaNguoiMuon.ReadOnly = false;
            btnXacNhanMuon.Enabled = false;

        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            try
            {

            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();

            string sql = "select count(*) from Sach where MaSach = " + txtMaSachTra.Text;
            SqlCommand Command = new SqlCommand(sql, conn);
            int countMasach = Convert.ToInt32(Command.ExecuteScalar());

            if(countMasach == 0 )
            {
                MessageBox.Show("Sách không tồn tại trong thư viện");
            }
            else
            {
                sql = "select trangthai from Sach where MaSach = " + txtMaSachTra.Text;
                Command = new SqlCommand(sql, conn);
                int trangthai = Convert.ToInt32(Command.ExecuteScalar());

                if(trangthai == 1)
                {
                    MessageBox.Show("Sachs chưa được cho mượn");
                }
                else
                {

                    sql = "select MaBD, NgayMuon, NgayHenTra from MuonTra where TrangThai =0 and MaSach = " + txtMaSachTra.Text;
                    Command = new SqlCommand(sql, conn);
                    SqlDataReader sdr = Command.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtMaNguoiMuonTra.Text = sdr["MaBD"].ToString();
                        txtNgayMuon.Text = sdr["NgayMuon"].ToString();
                        txtNgayTra.Text = sdr["NgayHenTra"].ToString();
   
                    }
                    sql = "select TenBD,GioiTinh,Diachi from BanDoc where MaBD = " + txtMaNguoiMuonTra.Text;
                    Command = new SqlCommand(sql, conn);  
                    sdr.Close();

                    sdr = Command.ExecuteReader();
                 
                    while(sdr.Read())
                    {
                        txtTenNguoiMuonTra.Text = sdr["tenBD"].ToString();
                        txtGioiTinhTra.Text = sdr["GioiTinh"].ToString();
                        txtDiaChiTra.Text = sdr["diachi"].ToString();
                    }
                    sql = "select Tensach,TenTacgia from Sach where MaSach = " + txtMaSachTra.Text;
                    Command = new SqlCommand(sql, conn);
                    sdr.Close();
                    sdr = Command.ExecuteReader();
                    while(sdr.Read())
                    {
                        txtTenSachTra.Text = sdr["tenSach"].ToString();
                        txtTenTacGiaTra.Text = sdr["TenTacGia"].ToString();
                    }
                    txtMaSachTra.ReadOnly = true;
                    btnXacNhanTraSach.Enabled = true;
                }
                
            }
            }
            catch(Exception)
            {
                MessageBox.Show("Hãy nhập Mã sách là một số nguyên!");
            }
            
        }

        private void btnXacNhanTraSach_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.getConnectionString());
            conn.Open();

            string sql = "Update sach set TrangThai = 1 where MaSach ="+ txtMaSachTra.Text;
            SqlCommand Command = new SqlCommand(sql, conn);
            Command.ExecuteNonQuery();

            DateTime ngaytra = Convert.ToDateTime(txtNgayTra.Text);
            DateTime ngayhientai = DateTime.Now;
            if(ngayhientai > ngaytra)
            {
                sql = "Update MuonTra set TrangThai = 2 where TrangThai = 0 and MaSach = " + txtMaSachTra.Text;
                MessageBox.Show("Bạn trả sách muônj..");
            }
            else
            {
                sql = "Update MuonTra set TrangThai = 1 where TrangThai = 0 and MaSach = " + txtMaSachTra.Text;
                MessageBox.Show("Bạn đã trả sách thành công", "Xác nhận");
            }

           
            Command = new SqlCommand(sql, conn);
            Command.ExecuteNonQuery();


            txtMaSachTra.Text = txtTenSachTra.Text = txtTenTacGiaTra.Text = txtTenNguoiMuonTra.Text = txtGioiTinhTra.Text = txtDiaChiTra.Text = "";
            txtMaNguoiMuonTra.Text = txtGioiTinhTra.Text = txtDiaChiTra.Text = txtNgayMuon.Text = txtNgayTra.Text = "";

            txtMaSachTra.ReadOnly = false;
            btnXacNhanTraSach.Enabled = false;


        }

        private void btnResetTra_Click(object sender, EventArgs e)
        {

            txtMaSachTra.Text = txtTenSachTra.Text = txtTenTacGiaTra.Text = txtTenNguoiMuonTra.Text = txtGioiTinhTra.Text = txtDiaChiTra.Text = "";
            txtMaNguoiMuonTra.Text= txtGioiTinhTra.Text= txtDiaChiTra.Text= txtNgayMuon.Text = txtNgayTra.Text = "";

            txtMaSachTra.ReadOnly = false;
            btnXacNhanTraSach.Enabled = false;

        }
=======
            
        }

        
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
    }
}
