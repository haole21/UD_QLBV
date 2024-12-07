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
    public partial class GUI_DieuTri : Form
    {
        BUS_DieuTri bus_DieuTri = new BUS_DieuTri();
        BUS_Khoa bus_Khoa = new BUS_Khoa();
        BUS_BenhNhan bus_BenhNhan = new BUS_BenhNhan();
        ET_DieuTri et_DieuTri = new ET_DieuTri();
        public GUI_DieuTri()
        {
            InitializeComponent();
        }

        private void GUI_DieuTri_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_DieuTri.DataSource = bus_DieuTri.getData();
                cbo_KhoaID.DataSource = bus_Khoa.getDataFromKhoa();
                cbo_KhoaID.ValueMember = "MAK";
                cbo_KhoaID.DisplayMember = "TENK";
                cbo_BenhNhanID.DataSource = bus_BenhNhan.getData();
                cbo_BenhNhanID.ValueMember = "MABN";
                cbo_BenhNhanID.DisplayMember = "MABN";
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
                et_DieuTri.MaKhoa = cbo_KhoaID.SelectedValue.ToString();
                et_DieuTri.MaBenhNhan = cbo_BenhNhanID.Text;

                if (bus_DieuTri.ThemDieuTri(et_DieuTri) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_DieuTri.DataSource = bus_DieuTri.getData();
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
                et_DieuTri.MaKhoa = cbo_KhoaID.SelectedValue.ToString();
                et_DieuTri.MaBenhNhan = cbo_BenhNhanID.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_DieuTri.XoaDieuTri(et_DieuTri) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_DieuTri.DataSource = bus_DieuTri.getData();
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



        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            cbo_KhoaID.Text = null;
            cbo_BenhNhanID.Text = null;
            cbo_KhoaID.Focus();
            dgv_DieuTri.DataSource = bus_DieuTri.getData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DieuTri_Click(object sender, EventArgs e)
        {
         
            int dong = dgv_DieuTri.CurrentCell.RowIndex;
            cbo_KhoaID.SelectedValue = dgv_DieuTri.Rows[dong].Cells[0].Value.ToString();
            cbo_BenhNhanID.Text = dgv_DieuTri.Rows[dong].Cells[1].Value.ToString();
            lb_maKhoa.Text = dgv_DieuTri.Rows[dong].Cells[0].Value.ToString();

        }

        private void GUI_DieuTri_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void cbo_KhoaID_SelectedValueChanged(object sender, EventArgs e)
        {
            lb_maKhoa.Text = cbo_KhoaID.SelectedValue.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_DieuTri.DataSource = bus_DieuTri.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
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
