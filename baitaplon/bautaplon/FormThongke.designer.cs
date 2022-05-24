
namespace Quanlythuvien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoSach = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tim_MaS = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tim_TenS = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tim_MaND = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tim_ND = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.output_demKQ = new System.Windows.Forms.Label();
            this.output_tongSach = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output_tongNgDung = new System.Windows.Forms.Label();
            this.output_tongMuonTra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 178);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimKiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(119, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoSach,
            this.theoNguoiDung});
            this.TimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(111, 21);
            this.TimKiem.Text = "Tìm kiếm theo...";
            // 
            // theoSach
            // 
            this.theoSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tim_MaS,
            this.btn_tim_TenS});
            this.theoSach.Name = "theoSach";
            this.theoSach.Size = new System.Drawing.Size(181, 22);
            this.theoSach.Text = "Theo sách";
            // 
            // btn_tim_MaS
            // 
            this.btn_tim_MaS.Name = "btn_tim_MaS";
            this.btn_tim_MaS.Size = new System.Drawing.Size(126, 22);
            this.btn_tim_MaS.Text = "Mã sách";
            this.btn_tim_MaS.Click += new System.EventHandler(this.btn_tim_MaS_Click);
            // 
            // btn_tim_TenS
            // 
            this.btn_tim_TenS.Name = "btn_tim_TenS";
            this.btn_tim_TenS.Size = new System.Drawing.Size(126, 22);
            this.btn_tim_TenS.Text = "Tên sách";
            this.btn_tim_TenS.Click += new System.EventHandler(this.btn_tim_TenS_Click);
            // 
            // theoNguoiDung
            // 
            this.theoNguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tim_MaND,
            this.btn_tim_ND});
            this.theoNguoiDung.Name = "theoNguoiDung";
            this.theoNguoiDung.Size = new System.Drawing.Size(181, 22);
            this.theoNguoiDung.Text = "Theo người mượn";
            // 
            // btn_tim_MaND
            // 
            this.btn_tim_MaND.Name = "btn_tim_MaND";
            this.btn_tim_MaND.Size = new System.Drawing.Size(168, 22);
            this.btn_tim_MaND.Text = "Mã người dùng";
            this.btn_tim_MaND.Click += new System.EventHandler(this.btn_tim_MaND_Click);
            // 
            // btn_tim_ND
            // 
            this.btn_tim_ND.Name = "btn_tim_ND";
            this.btn_tim_ND.Size = new System.Drawing.Size(168, 22);
            this.btn_tim_ND.Text = "Tên người dùng";
            this.btn_tim_ND.Click += new System.EventHandler(this.btn_tim_ND_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số kết quả tìm kiếm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Về trang chủ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(162, 57);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(79, 25);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // output_demKQ
            // 
            this.output_demKQ.AutoSize = true;
            this.output_demKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_demKQ.Location = new System.Drawing.Point(133, 104);
            this.output_demKQ.Name = "output_demKQ";
            this.output_demKQ.Size = new System.Drawing.Size(0, 16);
            this.output_demKQ.TabIndex = 10;
            // 
            // output_tongSach
            // 
            this.output_tongSach.AutoSize = true;
            this.output_tongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_tongSach.Location = new System.Drawing.Point(164, 47);
            this.output_tongSach.Name = "output_tongSach";
            this.output_tongSach.Size = new System.Drawing.Size(0, 16);
            this.output_tongSach.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng số sách trong kho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng số người dùng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng số mượn trả:";
            // 
            // output_tongNgDung
            // 
            this.output_tongNgDung.AutoSize = true;
            this.output_tongNgDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_tongNgDung.Location = new System.Drawing.Point(164, 75);
            this.output_tongNgDung.Name = "output_tongNgDung";
            this.output_tongNgDung.Size = new System.Drawing.Size(0, 16);
            this.output_tongNgDung.TabIndex = 16;
            // 
            // output_tongMuonTra
            // 
            this.output_tongMuonTra.AutoSize = true;
            this.output_tongMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_tongMuonTra.Location = new System.Drawing.Point(164, 105);
            this.output_tongMuonTra.Name = "output_tongMuonTra";
            this.output_tongMuonTra.Size = new System.Drawing.Size(0, 16);
            this.output_tongMuonTra.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.output_tongMuonTra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.output_tongSach);
            this.groupBox1.Controls.Add(this.output_tongNgDung);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(297, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 146);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.input_timkiem);
            this.panel1.Controls.Add(this.output_demKQ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(41, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 146);
            this.panel1.TabIndex = 19;
            // 
            // input_timkiem
            // 
            this.input_timkiem.Location = new System.Drawing.Point(3, 60);
            this.input_timkiem.Name = "input_timkiem";
            this.input_timkiem.Size = new System.Drawing.Size(153, 20);
            this.input_timkiem.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
            this.Text = "Thống kê";
=======
            this.Text = "Form1";
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TimKiem;
        private System.Windows.Forms.ToolStripMenuItem theoSach;
        private System.Windows.Forms.ToolStripMenuItem btn_tim_MaS;
        private System.Windows.Forms.ToolStripMenuItem btn_tim_TenS;
        private System.Windows.Forms.ToolStripMenuItem theoNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem btn_tim_MaND;
        private System.Windows.Forms.ToolStripMenuItem btn_tim_ND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label output_demKQ;
        private System.Windows.Forms.Label output_tongSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label output_tongNgDung;
        private System.Windows.Forms.Label output_tongMuonTra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox input_timkiem;
    }
}

