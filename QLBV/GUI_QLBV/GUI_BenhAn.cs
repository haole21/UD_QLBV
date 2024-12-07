using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBV;
using ET_QLBV;

namespace GUI_QLBV
{
    public partial class GUI_BenhAn : Form
    {
        BUS_BenhAn bus_BenhAn = new BUS_BenhAn();
        ET_BenhAn et_BenhAn = new ET_BenhAn();
        public GUI_BenhAn()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_BenhAn.Id = txt_ID.Text;
                et_BenhAn.MaBenhNhan = txt_BenhNhanID.Text;
                et_BenhAn.KetQua = txt_KetQua.Text;

                if (bus_BenhAn.ThemBenhAn(et_BenhAn) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_BenhAn.DataSource = bus_BenhAn.getData();
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
                et_BenhAn.Id = txt_ID.Text;
                et_BenhAn.MaBenhNhan = txt_BenhNhanID.Text;
                et_BenhAn.KetQua = txt_KetQua.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_BenhAn.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BenhAn.XoaBenhAn(et_BenhAn) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_BenhAn.DataSource = bus_BenhAn.getData();
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
                et_BenhAn.Id = txt_ID.Text;
                et_BenhAn.MaBenhNhan = txt_BenhNhanID.Text;
                et_BenhAn.KetQua = txt_KetQua.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_BenhAn.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BenhAn.SuaBenhAn(et_BenhAn) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_BenhAn.DataSource = bus_BenhAn.getData();
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
            txt_KetQua.Clear();
            txt_Key.Clear();
            txt_ID.Focus();
            dgv_BenhAn.DataSource = bus_BenhAn.getData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_BenhAn_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_BenhAn.DataSource = bus_BenhAn.getData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_BenhAn_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_BenhAn.DataSource = bus_BenhAn.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void dgv_BenhNhan_Click(object sender, EventArgs e)
        {
            int dong = dgv_BenhAn.CurrentCell.RowIndex;
            txt_ID.Text = dgv_BenhAn.Rows[dong].Cells[0].Value.ToString();
            txt_BenhNhanID.Text = dgv_BenhAn.Rows[dong].Cells[1].Value.ToString();
            txt_KetQua.Text = dgv_BenhAn.Rows[dong].Cells[2].Value.ToString();
        }

        private void GUI_BenhAn_FormClosing(object sender, FormClosingEventArgs e)
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
