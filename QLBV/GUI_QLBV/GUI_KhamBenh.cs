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
    public partial class GUI_KhamBenh : Form
    {
        BUS_KhamBenh BUS_KhamBenh = new BUS_KhamBenh();
        BUS_BacSi BUS_BacSi = new BUS_BacSi();
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        ET_KhamBenh ET_KhamBenh = new ET_KhamBenh();
        public GUI_KhamBenh()
        {
            InitializeComponent();
        }

        private void GUI_KhamBenh_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_KhamBenh.DataSource = BUS_KhamBenh.getDataFromKhamBenh();
                cbo_BacSi.DataSource = BUS_BacSi.getData();
                cbo_BacSi.ValueMember = "MABS";
                cbo_BacSi.DisplayMember = "TENBS";
                cbo_BenhNhan.DataSource = BUS_BenhNhan.getData();
                cbo_BenhNhan.ValueMember = "MABN";
                cbo_BenhNhan.DisplayMember = "TENBN";
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
                ET_KhamBenh.BacSi = cbo_BacSi.SelectedValue.ToString();
                ET_KhamBenh.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
                ET_KhamBenh.NgayKham = Convert.ToDateTime(dtp_NgayKham.Text);
                if (BUS_KhamBenh.ThemKhamBenh(ET_KhamBenh) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                dgv_KhamBenh.DataSource = BUS_KhamBenh.getDataFromKhamBenh();
            }
            catch (Exception ex)
            { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhamBenh.BacSi = cbo_BacSi.SelectedValue.ToString();
                ET_KhamBenh.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
                ET_KhamBenh.NgayKham = Convert.ToDateTime(dtp_NgayKham.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_KhamBenh.XoaKhamBenh(ET_KhamBenh) == false)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                dgv_KhamBenh.DataSource = BUS_KhamBenh.getDataFromKhamBenh();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhamBenh.BacSi = cbo_BacSi.SelectedValue.ToString();
                ET_KhamBenh.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
                ET_KhamBenh.NgayKham = Convert.ToDateTime(dtp_NgayKham.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi dữ liệu không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_KhamBenh.SuaKhamBenh(ET_KhamBenh) == false)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                dgv_KhamBenh.DataSource = BUS_KhamBenh.getDataFromKhamBenh();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                cbo_BacSi.Text = "";
                cbo_BenhNhan.Text = "";
                lb_BacSi.Text = "";
                lb_BenhNhan.Text = "";
                dtp_NgayKham.Text = DateTime.Now.ToString();
                dgv_KhamBenh.DataSource = BUS_KhamBenh.getDataFromKhamBenh();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_KhamBenh.DataSource = BUS_KhamBenh.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }


        private void dgv_KhamBenh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_KhamBenh.CurrentCell.RowIndex;
                cbo_BacSi.SelectedValue = dgv_KhamBenh.Rows[dong].Cells[0].Value.ToString();
                cbo_BenhNhan.SelectedValue = dgv_KhamBenh.Rows[dong].Cells[1].Value.ToString();
                dtp_NgayKham.Text = dgv_KhamBenh.Rows[dong].Cells[2].Value.ToString();
                lb_BacSi.Text = dgv_KhamBenh.Rows[dong].Cells[0].Value.ToString();
                lb_BenhNhan.Text = dgv_KhamBenh.Rows[dong].Cells[1].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }


        private void cbo_BacSi_SelectedValueChanged(object sender, EventArgs e)
        {
            lb_BacSi.Text = cbo_BacSi.SelectedValue.ToString();

        }

        private void cbo_BenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            lb_BenhNhan.Text = cbo_BenhNhan.SelectedValue.ToString();
        }

        private void GUI_KhamBenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
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
    }
}
