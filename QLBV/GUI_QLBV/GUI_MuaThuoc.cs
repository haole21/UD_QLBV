using BUS_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public partial class GUI_MuaThuoc : Form
    {
        BUS_MuaThuoc BUS_MuaThuoc = new BUS_MuaThuoc();
        BUS_Thuoc BUS_Thuoc = new BUS_Thuoc();
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        ET_MuaThuoc ET_MuaThuoc = new ET_MuaThuoc();
        public GUI_MuaThuoc()
        {
            InitializeComponent();
        }

        private void GUI_MuaThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_MuaThuoc.DataSource = BUS_MuaThuoc.getDataFromMuaThuoc();
                cbo_Thuoc.DataSource = BUS_Thuoc.getDataFromThuoc();
                cbo_Thuoc.ValueMember = "MATHUOC";
                cbo_Thuoc.DisplayMember = "TENTHUOC";
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
                ET_MuaThuoc.Thuoc = cbo_Thuoc.SelectedValue.ToString();
                ET_MuaThuoc.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
                ET_MuaThuoc.Sl = Convert.ToInt32(txt_SL.Text);
                if (BUS_MuaThuoc.ThemMuaThuoc(ET_MuaThuoc) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                dgv_MuaThuoc.DataSource = BUS_MuaThuoc.getDataFromMuaThuoc();
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
                ET_MuaThuoc.Thuoc = cbo_Thuoc.SelectedValue.ToString();
                ET_MuaThuoc.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
                ET_MuaThuoc.Sl = Convert.ToInt32(txt_SL.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_MuaThuoc.XoaMuaThuoc(ET_MuaThuoc) == false)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                dgv_MuaThuoc.DataSource = BUS_MuaThuoc.getDataFromMuaThuoc();
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
                ET_MuaThuoc.Thuoc = cbo_Thuoc.SelectedValue.ToString();
                ET_MuaThuoc.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
                ET_MuaThuoc.Sl = Convert.ToInt32(txt_SL.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi dữ liệu không !", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No) return;
                if (BUS_MuaThuoc.SuaMuaThuoc(ET_MuaThuoc) == false)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                dgv_MuaThuoc.DataSource = BUS_MuaThuoc.getDataFromMuaThuoc();
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
                cbo_Thuoc.Text = "";
                cbo_BenhNhan.Text = "";
                lb_Thuoc.Text = "";
                lb_BenhNhan.Text = "";
                txt_SL.Clear(); 
                dgv_MuaThuoc.DataSource = BUS_MuaThuoc.getDataFromMuaThuoc();
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
                dgv_MuaThuoc.DataSource = BUS_MuaThuoc.FindData(txt_Key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void dgv_MuaThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_MuaThuoc.CurrentCell.RowIndex;
                cbo_Thuoc.SelectedValue= dgv_MuaThuoc.Rows[dong].Cells[0].Value.ToString();
                lb_Thuoc.Text = dgv_MuaThuoc.Rows[dong].Cells[0].Value.ToString();
                lb_BenhNhan.Text = dgv_MuaThuoc.Rows[dong].Cells[1].Value.ToString();
                cbo_BenhNhan.SelectedValue = dgv_MuaThuoc.Rows[dong].Cells[1].Value.ToString();
                txt_SL.Text = dgv_MuaThuoc.Rows[dong].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Key.Text == "")
                {
                    txt_Key.Text = "Nhập tên bệnh nhân cần tìm";
                    txt_Key.ForeColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txt_Key.Text == "Nhập tên bệnh nhân cần tìm")
                {
                    txt_Key.Text = "";
                    txt_Key.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void GUI_MuaThuoc_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbo_Thuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lb_Thuoc.Text = cbo_Thuoc.SelectedValue.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void cbo_BenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lb_BenhNhan.Text = cbo_BenhNhan.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }
    }
}
