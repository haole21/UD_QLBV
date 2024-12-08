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
    public partial class GUI_Thuoc : Form
    {
        BUS_Thuoc bus_Thuoc = new BUS_Thuoc();
        ET_Thuoc et_Thuoc = new ET_Thuoc();
        public GUI_Thuoc()
        {
            InitializeComponent();
        }

        private void GUI_Thuoc_Load(object sender, EventArgs e)
        {
            try
            {
                
                dgv_Thuoc.DataSource = bus_Thuoc.getDataFromThuoc();
              
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
                et_Thuoc.Id = txt_ID.Text;
                et_Thuoc.Gia = Convert.ToDouble(txt_Gia.Text);
                et_Thuoc.Ten = txt_Ten.Text;
                et_Thuoc.Sl =  Convert.ToInt32(txt_SL.Text);              
                if (bus_Thuoc.ThemThuoc(et_Thuoc) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_Thuoc.DataSource = bus_Thuoc.getDataFromThuoc();
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
                et_Thuoc.Id = txt_ID.Text;
                et_Thuoc.Gia = Convert.ToDouble(txt_Gia.Text);
                et_Thuoc.Ten = txt_Ten.Text;
                et_Thuoc.Sl = Convert.ToInt32(txt_SL.Text);
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_Thuoc.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_Thuoc.XoaThuoc(et_Thuoc) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_Thuoc.DataSource = bus_Thuoc.getDataFromThuoc();
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
                et_Thuoc.Id = txt_ID.Text;
                et_Thuoc.Gia = Convert.ToDouble(txt_Gia.Text);
                et_Thuoc.Ten = txt_Ten.Text;
                et_Thuoc.Sl = Convert.ToInt32(txt_SL.Text);
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_Thuoc.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_Thuoc.SuaThuoc(et_Thuoc) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_Thuoc.DataSource = bus_Thuoc.getDataFromThuoc();
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
            txt_Gia.Clear();
            txt_Ten.Clear();
            txt_SL.Clear();
            txt_ID.Focus();
            dgv_Thuoc.DataSource = bus_Thuoc.getDataFromThuoc();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Thuoc.DataSource = bus_Thuoc.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Thuoc_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_Thuoc.CurrentCell.RowIndex;
                txt_ID.Text = dgv_Thuoc.Rows[dong].Cells[0].Value.ToString();
                txt_Ten.Text = dgv_Thuoc.Rows[dong].Cells[1].Value.ToString();
                txt_SL.Text = dgv_Thuoc.Rows[dong].Cells[2].Value.ToString();
                txt_Gia.Text = dgv_Thuoc.Rows[dong].Cells[3].Value.ToString();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập tên thuốc cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên thuốc cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }

        private void GUI_Thuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }
    }
}
