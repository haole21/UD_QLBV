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
    public partial class GUI_LichSuBA : Form
    {
        BUS_LichSuBA BUS_LichSuBA = new BUS_LichSuBA();
        BUS_BacSi BUS_BacSi = new BUS_BacSi();
        BUS_BenhAn BUS_BenhAn = new BUS_BenhAn();
        ET_LichSuBA ET_LichSuBA = new ET_LichSuBA();
        public GUI_LichSuBA()
        {
            InitializeComponent();
        }

        private void GUI_LichSuBA_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_LichSuBA.DataSource = BUS_LichSuBA.getDataFromKhoa();
                cbo_BacSi.DataSource = BUS_BacSi.getData();
                cbo_BacSi.ValueMember = "MABS";
                cbo_BacSi.DisplayMember = "TENBS";
                cbo_BenhAn.DataSource = BUS_BenhAn.getData();
                cbo_BenhAn.ValueMember = "MABA";
                cbo_BenhAn.DisplayMember = "MABA";
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
                ET_LichSuBA.BacSi = cbo_BacSi.SelectedValue.ToString();
                ET_LichSuBA.BenhAn = cbo_BenhAn.SelectedValue.ToString();
                ET_LichSuBA.NgayViet = Convert.ToDateTime(dtp_NgayViet.Text);
                if (BUS_LichSuBA.ThemLichSu(ET_LichSuBA) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                dgv_LichSuBA.DataSource = BUS_LichSuBA.getDataFromKhoa();
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
                ET_LichSuBA.BacSi = cbo_BacSi.SelectedValue.ToString();
                ET_LichSuBA.BenhAn = cbo_BenhAn.SelectedValue.ToString();
                ET_LichSuBA.NgayViet = Convert.ToDateTime(dtp_NgayViet.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_LichSuBA.XoaLichSu(ET_LichSuBA) == false)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                dgv_LichSuBA.DataSource = BUS_LichSuBA.getDataFromKhoa();
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
                ET_LichSuBA.BacSi = cbo_BacSi.SelectedValue.ToString();
                ET_LichSuBA.BenhAn = cbo_BenhAn.SelectedValue.ToString();
                ET_LichSuBA.NgayViet = Convert.ToDateTime(dtp_NgayViet.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi dữ liệu không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_LichSuBA.SuaLichSu(ET_LichSuBA) == false)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                dgv_LichSuBA.DataSource = BUS_LichSuBA.getDataFromKhoa();
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
                cbo_BacSi.Text = "";
                cbo_BenhAn.Text = "";
                lb_BacSi.Text = "";
                dtp_NgayViet.Text = DateTime.Now.ToString();            
                dgv_LichSuBA.DataSource = BUS_LichSuBA.getDataFromKhoa();
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
                dgv_LichSuBA.DataSource = BUS_LichSuBA.FindData(txt_Key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void dgv_LichSuBA_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_LichSuBA.CurrentCell.RowIndex;
                cbo_BacSi.SelectedValue = dgv_LichSuBA.Rows[dong].Cells[0].Value.ToString();
                cbo_BenhAn.SelectedValue = dgv_LichSuBA.Rows[dong].Cells[1].Value.ToString();
                dtp_NgayViet.Text = dgv_LichSuBA.Rows[dong].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void cbo_BacSi_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
              lb_BacSi.Text = cbo_BacSi.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

   

        private void GUI_LichSuBA_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên thuốc cần tìm";
                txt_Key.ForeColor = Color.Gray;
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
    }
}
