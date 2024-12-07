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
    public partial class GUI_DichVu : Form
    {
        BUS_DichVu bus_DichVu = new BUS_DichVu();
        ET_DichVu et_DichVu = new ET_DichVu();
        public GUI_DichVu()
        {
            InitializeComponent();
        }

        private void GUI_DichVu_Load(object sender, EventArgs e)
        {
            try
            {

                dgv_DichVu.DataSource = bus_DichVu.getData();


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
                et_DichVu.Id = txt_ID.Text;
                et_DichVu.Ten = txt_TenDV.Text;
                et_DichVu.Gia = Convert.ToDouble(txt_Gia.Text);

                if (bus_DichVu.ThemDichVu(et_DichVu) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_DichVu.DataSource = bus_DichVu.getData();
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
                et_DichVu.Id = txt_ID.Text;
                et_DichVu.Ten = txt_TenDV.Text;
                et_DichVu.Gia = Convert.ToDouble(txt_Gia.Text);
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_DichVu.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_DichVu.XoaDichVu(et_DichVu) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_DichVu.DataSource = bus_DichVu.getData();
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
                et_DichVu.Id = txt_ID.Text;
                et_DichVu.Ten = txt_TenDV.Text;
                et_DichVu.Gia = Convert.ToDouble(txt_Gia.Text);
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_DichVu.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_DichVu.SuaDichVu(et_DichVu) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_DichVu.DataSource = bus_DichVu.getData();
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
            txt_TenDV.Clear();
            txt_Gia.Clear();
            txt_ID.Focus();
            dgv_DichVu.DataSource = bus_DichVu.getData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DichVu_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_DichVu.CurrentCell.RowIndex;
                txt_ID.Text = dgv_DichVu.Rows[dong].Cells[0].Value.ToString();
                txt_TenDV.Text = dgv_DichVu.Rows[dong].Cells[1].Value.ToString();
                txt_Gia.Text = dgv_DichVu.Rows[dong].Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_DichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_DichVu.DataSource = bus_DichVu.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên dịch vụ cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {

            if (txt_Key.Text == "Nhập tên dịch vụ cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }
    }
}
