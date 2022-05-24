
namespace Quanlythuvien
{
    partial class FormQuanlynhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ip_ten_dn = new System.Windows.Forms.TextBox();
            this.ip_ten_mk = new System.Windows.Forms.TextBox();
            this.ip_ten_dd = new System.Windows.Forms.TextBox();
            this.ip_ten_vt = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thaydoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_veHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đầy đủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vai trò";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu";
            // 
            // ip_ten_dn
            // 
            this.ip_ten_dn.Location = new System.Drawing.Point(35, 41);
            this.ip_ten_dn.Name = "ip_ten_dn";
            this.ip_ten_dn.Size = new System.Drawing.Size(159, 24);
            this.ip_ten_dn.TabIndex = 6;
            // 
            // ip_ten_mk
            // 
            this.ip_ten_mk.Location = new System.Drawing.Point(35, 160);
            this.ip_ten_mk.Name = "ip_ten_mk";
            this.ip_ten_mk.Size = new System.Drawing.Size(159, 24);
            this.ip_ten_mk.TabIndex = 9;
            // 
            // ip_ten_dd
            // 
            this.ip_ten_dd.Location = new System.Drawing.Point(35, 99);
            this.ip_ten_dd.Name = "ip_ten_dd";
            this.ip_ten_dd.Size = new System.Drawing.Size(159, 24);
            this.ip_ten_dd.TabIndex = 10;
            // 
            // ip_ten_vt
            // 
            this.ip_ten_vt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ip_ten_vt.FormattingEnabled = true;
            this.ip_ten_vt.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.ip_ten_vt.Location = new System.Drawing.Point(35, 215);
            this.ip_ten_vt.Name = "ip_ten_vt";
            this.ip_ten_vt.Size = new System.Drawing.Size(159, 26);
            this.ip_ten_vt.TabIndex = 13;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Location = new System.Drawing.Point(32, 403);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(135, 33);
            this.btn_them.TabIndex = 14;
            this.btn_them.TabStop = false;
            this.btn_them.Text = "Thêm tài khoản";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thaydoi
            // 
            this.btn_thaydoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thaydoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thaydoi.Location = new System.Drawing.Point(217, 403);
            this.btn_thaydoi.Name = "btn_thaydoi";
            this.btn_thaydoi.Size = new System.Drawing.Size(134, 33);
            this.btn_thaydoi.TabIndex = 15;
            this.btn_thaydoi.TabStop = false;
            this.btn_thaydoi.Text = "Thay đổi thông tin";
            this.btn_thaydoi.UseVisualStyleBackColor = false;
            this.btn_thaydoi.Click += new System.EventHandler(this.btn_thaydoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(400, 403);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(134, 33);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.TabStop = false;
            this.btn_xoa.Text = "Xoá tài khoản";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_khoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoitao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_khoitao.Location = new System.Drawing.Point(583, 403);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(135, 33);
            this.btn_khoitao.TabIndex = 19;
            this.btn_khoitao.TabStop = false;
            this.btn_khoitao.Text = "Khởi tạo";
            this.btn_khoitao.UseVisualStyleBackColor = false;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ip_ten_dn);
            this.panel1.Controls.Add(this.ip_ten_mk);
            this.panel1.Controls.Add(this.ip_ten_vt);
            this.panel1.Controls.Add(this.ip_ten_dd);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(491, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 261);
            this.panel1.TabIndex = 20;
            // 
            // btn_veHome
            // 
            this.btn_veHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_veHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_veHome.Location = new System.Drawing.Point(307, 458);
            this.btn_veHome.Name = "btn_veHome";
            this.btn_veHome.Size = new System.Drawing.Size(134, 33);
            this.btn_veHome.TabIndex = 21;
            this.btn_veHome.TabStop = false;
            this.btn_veHome.Text = "Về trang chủ";
            this.btn_veHome.UseVisualStyleBackColor = false;
            this.btn_veHome.Click += new System.EventHandler(this.btn_veHome_Click);
            // 
            // FormQuanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(742, 503);
            this.Controls.Add(this.btn_veHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_khoitao);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_thaydoi);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQuanlynhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ip_ten_dn;
        private System.Windows.Forms.TextBox ip_ten_mk;
        private System.Windows.Forms.TextBox ip_ten_dd;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thaydoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ip_ten_vt;
        private System.Windows.Forms.Button btn_veHome;
    }
}

