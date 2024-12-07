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
    public partial class GUI_KhoaNV : Form
    {
        BUS_KhoaNV BUS_KhoaNV = new BUS_KhoaNV();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_Khoa BUS_Khoa = new BUS_Khoa();
        ET_KhoaNV ET_KhoaNV = new ET_KhoaNV();
        public GUI_KhoaNV()
        {
            InitializeComponent();
        }

        private void GUI_KhoaNV_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_KhoaNV.DataSource = BUS_KhoaNV.getDataFromKhoaNV();
                cbo_Khoa.DataSource = BUS_Khoa.getDataFromKhoa();
                cbo_Khoa.ValueMember = "MAK";
                cbo_Khoa.DisplayMember = "TENK";
                cbo_NhanVien.DataSource = BUS_NhanVien.getDataFromNhanVien();
                cbo_NhanVien.ValueMember = "MANV";
                cbo_NhanVien.DisplayMember = "TENNV";
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
                ET_KhoaNV.Khoa = cbo_Khoa.SelectedValue.ToString();
                ET_KhoaNV.NhanVien = cbo_NhanVien.SelectedValue.ToString();
                if (BUS_KhoaNV.ThemKhoaNV(ET_KhoaNV) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                dgv_KhoaNV.DataSource = BUS_KhoaNV.getDataFromKhoaNV();
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
                ET_KhoaNV.Khoa = cbo_Khoa.SelectedValue.ToString();
                ET_KhoaNV.NhanVien = cbo_NhanVien.SelectedValue.ToString();
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_KhoaNV.XoaKhoaNV(ET_KhoaNV) == false)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                dgv_KhoaNV.DataSource = BUS_KhoaNV.getDataFromKhoaNV();
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
                cbo_Khoa.Text = "";
                cbo_NhanVien.Text = "";
                lb_Khoa.Text = "";
                lb_NhanVien.Text = "";               
                dgv_KhoaNV.DataSource = BUS_KhoaNV.getDataFromKhoaNV();
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
               this.Close();
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
                dgv_KhoaNV.DataSource = BUS_KhoaNV.FindData(txt_key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void dgv_KhoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_KhoaNV.CurrentCell.RowIndex;
                cbo_Khoa.SelectedValue = dgv_KhoaNV.Rows[dong].Cells[0].Value.ToString();
                cbo_NhanVien.SelectedValue = dgv_KhoaNV.Rows[dong].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void cbo_Khoa_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lb_Khoa.Text = cbo_Khoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void cbo_NhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lb_NhanVien.Text = cbo_NhanVien.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void txt_key_Leave(object sender, EventArgs e)
        {
            if (txt_key.Text == "")
            {
                txt_key.Text = "Nhập tên nhân viên cần tìm";
                txt_key.ForeColor = Color.Gray;
            }
        }

        private void txt_key_Enter(object sender, EventArgs e)
        {
            if (txt_key.Text == "Nhập tên nhân viên cần tìm")
            {
                txt_key.Text = "";
                txt_key.ForeColor = Color.Black;
            }
        }

        private void GUI_KhoaNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }
    }
}
