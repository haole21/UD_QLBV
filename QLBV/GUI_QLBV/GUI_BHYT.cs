using BUS_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public partial class GUI_BHYT : Form
    {
        BUS_BHYT bus_BHYT = new BUS_BHYT();     
        ET_BHYT et_BHYT = new ET_BHYT();
        public GUI_BHYT()
        {
            InitializeComponent();
        }

        private void GUI_BHYT_Load(object sender, EventArgs e)
        {
            try
            {
              
                dgv_BHYT.DataSource = bus_BHYT.getData();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_BHYT.Id = txt_ID.Text;
                et_BHYT.BenhNhan = txt_BenhNhanID.Text;         
                et_BHYT.NgayCap = Convert.ToDateTime(dtp_NgayCap.Text);
                et_BHYT.NgayHetHan  = Convert.ToDateTime(dtp_NgayHetHan.Text);
                if (bus_BHYT.ThemBHYT(et_BHYT) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_BHYT.DataSource = bus_BHYT.getData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                et_BHYT.Id = txt_ID.Text;
                et_BHYT.BenhNhan = txt_BenhNhanID.Text;
                et_BHYT.NgayCap = Convert.ToDateTime(dtp_NgayCap.Text);
                et_BHYT.NgayHetHan = Convert.ToDateTime(dtp_NgayHetHan.Text);
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_BHYT.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BHYT.XoaBHYT(et_BHYT) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_BHYT.DataSource = bus_BHYT.getData();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                et_BHYT.Id = txt_ID.Text;
                et_BHYT.BenhNhan = txt_BenhNhanID.Text;
                et_BHYT.NgayCap = Convert.ToDateTime(dtp_NgayCap.Text);
                et_BHYT.NgayHetHan = Convert.ToDateTime(dtp_NgayHetHan.Text);
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_BHYT.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BHYT.SuaBHYT(et_BHYT) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_BHYT.DataSource = bus_BHYT.getData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_BenhNhanID.Clear();
            dtp_NgayCap.Text = DateTime.Now.ToLongDateString();
            dtp_NgayHetHan.Text = DateTime.Now.ToLongDateString();           
            txt_ID.Focus();
            dgv_BHYT.DataSource = bus_BHYT.getData();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_BHYT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void dgv_BHYT_Click(object sender, EventArgs e)
        {
            
            try
            {
                int dong = dgv_BHYT.CurrentCell.RowIndex;
                txt_ID.Text = dgv_BHYT.Rows[dong].Cells[0].Value.ToString();
                txt_BenhNhanID.Text = dgv_BHYT.Rows[dong].Cells[1].Value.ToString();
                dtp_NgayCap.Text = Convert.ToDateTime(dgv_BHYT.Rows[dong].Cells[2].Value.ToString()).ToLongDateString();
                dtp_NgayHetHan.Text = Convert.ToDateTime(dgv_BHYT.Rows[dong].Cells[3].Value.ToString()).ToLongDateString();
         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên bệnh nhân cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập tên bệnh nhân cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_BHYT.DataSource = bus_BHYT.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }
    }
}
