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
    public partial class GUI_Khoa : Form
    {
        BUS_Khoa BUS_Khoa = new BUS_Khoa();
        ET_Khoa ET_Khoa = new ET_Khoa();
        public GUI_Khoa()
        {
            InitializeComponent();
        }

        private void GUI_Khoa_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Khoa.Id = txt_ID.Text;
                ET_Khoa.Name = txt_Ten.Text;
                if (BUS_Khoa.ThemKhoa(ET_Khoa) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                dgv_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Khoa.Id = txt_ID.Text;
                ET_Khoa.Name = txt_Ten.Text;
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_Khoa.XoaKhoa(ET_Khoa) == false)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                dgv_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Khoa.Id = txt_ID.Text;
                ET_Khoa.Name = txt_Ten.Text;
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi dữ liệu không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_Khoa.SuaKhoa(ET_Khoa) == false)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                dgv_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txt_ID.Clear();
                txt_Ten.Clear();
                dgv_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Khoa.DataSource = BUS_Khoa.FindData(txt_key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void dgv_Khoa_Click(object sender, EventArgs e)
        {
            int dong = dgv_Khoa.CurrentCell.RowIndex;
            txt_ID.Text = dgv_Khoa.Rows[dong].Cells[0].Value.ToString();
            txt_Ten.Text = dgv_Khoa.Rows[dong].Cells[1].Value.ToString();
        }

        private void txt_key_Enter(object sender, EventArgs e)
        {
         
            if (txt_key.Text == "Nhập tên khoa cần tìm")
            {
                txt_key.Text = "";
                txt_key.ForeColor = Color.Black;
            }
        }

        private void txt_key_Leave(object sender, EventArgs e)
        {
            if (txt_key.Text == "")
            {
                txt_key.Text = "Nhập tên khoa cần tìm";
                txt_key.ForeColor = Color.Gray;
            }
        }
    }
}
