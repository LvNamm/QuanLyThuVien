using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class QLBD : Form
    {
        private BandocRepo bandocRepo;
        private TextBox[] listtextbox;
        public QLBD()
        {
            bandocRepo = new BandocRepo();
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            //this.dataGridView1.RowHeaderMouseDoubleClick -=new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = e.ColumnIndex.ToString();
            textBox2.Text = e.RowIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            dataGridView1.Columns.Clear();
=======
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            dataGridView1.DataSource = bandocRepo.getAll();
            fixSizeColumns();
            textBox1.Text = bandocRepo.getIden().ToString();
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button1.Enabled = false;
            //TextBox[] listtextbox = { textBox1, textBox2, textBox3, textBox4, textBox6 };
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            radioButton1.Checked = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()=="Nam" ? true : false;
            radioButton2.Checked = !radioButton1.Checked;
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            button3.Enabled = true;
            butto4.Enabled = true;
            button7.Enabled = true;
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(536, 532);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length==0)
<<<<<<< HEAD
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = bandocRepo.getAll();
            }
            else if (comboBox1.SelectedIndex==0)
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = bandocRepo.findById(Convert.ToInt32(textBox5.Text));
                    fixSizeColumns();
                }
                catch (Exception ex)
                {

                }
            else if (comboBox1.SelectedIndex==1)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = bandocRepo.findByName(textBox5.Text);
                fixSizeColumns();
            }
        }
=======
                dataGridView1.DataSource = bandocRepo.getAll();
            else if (comboBox1.SelectedIndex==0)
                try {
                    dataGridView1.DataSource = bandocRepo.findById(Convert.ToInt32(textBox5.Text));
                    fixSizeColumns();
                }
                catch (Exception ex) {
                    
                }
            else if (comboBox1.SelectedIndex==1)
                    dataGridView1.DataSource = bandocRepo.findByName(textBox5.Text);
                    fixSizeColumns();
                }
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bandoc banDoc = new Bandoc();
                banDoc.maBd = Convert.ToInt32(textBox1.Text);
                banDoc.tenBd = Convert.ToString(textBox2.Text);
                if (banDoc.tenBd.Length==0)
                    throw new MyException("Tên bạn đọc không được để trống");
                string s = "0123456789";
                foreach(char x in banDoc.tenBd)
                {
                    if (s.IndexOf(x)>-1)
                        throw new MyException("Tên không được có chữ số");
                }
                banDoc.gioiTinh = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                banDoc.diachi = textBox4.Text;
                if (banDoc.diachi.Length == 0)
                    throw new MyException("Địa chỉ không được để trống");
                banDoc.ngaySinh = dateTimePicker1.Value;
                string y = bandocRepo.insertBandoc(banDoc);
<<<<<<< HEAD
                dataGridView1.Columns.Clear();
=======
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
                dataGridView1.DataSource = bandocRepo.getAll();
                fixSizeColumns();
                textBox2.Text = "";
                textBox4.Text = "";
                textBox1.Text = bandocRepo.getIden().ToString();
                dateTimePicker1.Value = DateTime.Now;
<<<<<<< HEAD
                MessageBox.Show("Lưu thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MyException ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
                MessageBox.Show(y);
            }
            catch (MyException ex) {
               MessageBox.Show(ex.Message);
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton1.Checked = false;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Bandoc banDoc = new Bandoc();
                banDoc.maBd = Convert.ToInt32(textBox1.Text);
                banDoc.tenBd = Convert.ToString(textBox2.Text);
                if (banDoc.tenBd.Length==0)
                    throw new MyException("Tên bạn đọc không được để trống");
                string s = "0123456789";
                foreach (char x in banDoc.tenBd)
                {
                    if (s.IndexOf(x)>-1)
                        throw new MyException("Tên không được có chữ số");
                }
                banDoc.gioiTinh = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                banDoc.diachi = textBox4.Text;
                if (banDoc.diachi.Length == 0)
                    throw new MyException("Địa chỉ không được để trống");
                banDoc.ngaySinh = dateTimePicker1.Value;
                string y = bandocRepo.updateBandoc(banDoc);
<<<<<<< HEAD
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = bandocRepo.getAll();
                fixSizeColumns();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MyException ex)
            {
                MessageBox.Show("Mã sách chưa tồn tại", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Mã người dùng chưa tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Hãy nhập đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
=======
                dataGridView1.DataSource = bandocRepo.getAll();
                fixSizeColumns();
                MessageBox.Show(y);
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
            }
           // catch(Exception ex)
          //  {
           //     MessageBox.Show("Lỗi không xác định. Đảm bảo cơ sở dữ liệu đang chạy");
           // }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            reset();
        }
        /// <summary>
        /// 
        /// </summary>
        private void fixSizeColumns()
        {
<<<<<<< HEAD
            
            int[] sizeColumns = { 65, 125, 75, 100, 100 };
            for (int i = 0; i<dataGridView1.Columns.Count; i++)
            {
                if (i>4)
                {
                    break;
                }
                dataGridView1.Columns[i].Width = sizeColumns[i];
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "button";
                button.HeaderText = "";
                button.Text = "Sửa";
                button.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button);
            }
            dataGridView1.Columns[dataGridView1.Columns.Count-1].Width = 35;

            DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
            {
                button1.Name = "button1";
                button1.HeaderText = "";
                button1.Text = "Xóa";
                button1.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button1);
            }
            dataGridView1.Columns[dataGridView1.Columns.Count-1].Width = 35;
=======
            int[] sizeColumns = { 50, 135, 70, 100, 100 };
            for (int i = 0; i<dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = sizeColumns[i];
            }
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int Mabd = Convert.ToInt32(textBox1.Text);
                bandocRepo.deleteById(Mabd);

                dataGridView1.DataSource = bandocRepo.getAll();
                fixSizeColumns();
                reset();
                MessageBox.Show("Xóa thành công");
            }
            catch(MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //reset hàm sử dụng (Thêm, xóa thàng công, reset)
        private void reset()
        {
            button1.Enabled = true;
            button3.Enabled = false;
            butto4.Enabled = false;
            button7.Enabled = false;
            textBox2.Text = "";
            textBox4.Text = "";
            textBox1.Text = bandocRepo.getIden().ToString();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if(row.Cells[1].Value != null)
                s += row.Cells[1].Value.ToString() + " ";
            }
            MessageBox.Show(s);
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
           
=======
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable tbBd = bandocRepo.findById(Convert.ToInt32(textBox1.Text));
            Bandoc a = new Bandoc();
            a.maBd = tbBd.Rows[0].Field<int>(0);
            a.tenBd = tbBd.Rows[0].Field<string>(1);
            a.gioiTinh = tbBd.Rows[0].Field<string>(2);
            a.diachi = tbBd.Rows[0].Field<string>(3);
            a.ngaySinh = tbBd.Rows[0].Field<DateTime>(4);



            FormChitietbandoc b = new FormChitietbandoc(   a    );
            b.FormBorderStyle = FormBorderStyle.FixedSingle;
            b.StartPosition = FormStartPosition.CenterScreen;
            b.Show();
        }
<<<<<<< HEAD

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5) {
                button1.Enabled = false;
                //TextBox[] listtextbox = { textBox1, textBox2, textBox3, textBox4, textBox6 };
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                radioButton1.Checked = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()=="Nam" ? true : false;
                radioButton2.Checked = !radioButton1.Checked;
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                button3.Enabled = true;
                butto4.Enabled = true;
                button7.Enabled = true;
            }

            if(e.ColumnIndex == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa bạn đọc này không ?", "Xóa bạn đọc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 720106e3e565ca7ceb8a7bac963c967253790dc6
    }
}
