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
    public partial class GUI_BenhNhan : Form
    {
        BUS_BenhNhan bus_BenhNhan = new BUS_BenhNhan();
        BUS_PhongDieuTri bus_PhongDieuTri = new BUS_PhongDieuTri();
        ET_BenhNhan et_BenhNhan = new ET_BenhNhan();
        public GUI_BenhNhan()
        {
            InitializeComponent();
        }

        private void GUI_BenhNhan_Load(object sender, EventArgs e)
        {
            try
            {
                string[] arrCV = new string[] { "BÁC SĨ HẠNG 1", "BÁC SĨ HẠNG 2", "BÁC SĨ HẠNG 3" };
                dgv_BenhNhan.DataSource = bus_BenhNhan.getData();
                cbo_PhongDieuTri.DataSource = bus_PhongDieuTri.getDataFromPhongDieuTri();
                cbo_PhongDieuTri.ValueMember = "MAPDT";
                cbo_PhongDieuTri.DisplayMember = "MAPDT";

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
                et_BenhNhan.Id = txt_ID.Text;
                et_BenhNhan.Ho = txt_Ho.Text;
                et_BenhNhan.Ten = txt_Ten.Text;
                et_BenhNhan.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_BenhNhan.DiaChi = txt_DiaChi.Text;
                et_BenhNhan.Dth = txt_DTH.Text;
                et_BenhNhan.Phai = cbo_Phai.Text;
                et_BenhNhan.PhongDieuTri = cbo_PhongDieuTri.Text;
                if (bus_BenhNhan.ThemBenhNhan(et_BenhNhan) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_BenhNhan.DataSource = bus_BenhNhan.getData();
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
                et_BenhNhan.Id = txt_ID.Text;
                et_BenhNhan.Ho = txt_Ho.Text;
                et_BenhNhan.Ten = txt_Ten.Text;
                et_BenhNhan.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_BenhNhan.DiaChi = txt_DiaChi.Text;
                et_BenhNhan.Dth = txt_DTH.Text;
                et_BenhNhan.Phai = cbo_Phai.Text;
                et_BenhNhan.PhongDieuTri = cbo_PhongDieuTri.Text;

                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_BenhNhan.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BenhNhan.XoaBenhNhan(et_BenhNhan) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_BenhNhan.DataSource = bus_BenhNhan.getData();
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
                et_BenhNhan.Id = txt_ID.Text;
                et_BenhNhan.Ho = txt_Ho.Text;
                et_BenhNhan.Ten = txt_Ten.Text;
                et_BenhNhan.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_BenhNhan.DiaChi = txt_DiaChi.Text;
                et_BenhNhan.Dth = txt_DTH.Text;
                et_BenhNhan.Phai = (cbo_Phai.Text == "") ? "" : cbo_Phai.Text;
                et_BenhNhan.PhongDieuTri = cbo_PhongDieuTri.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_BenhNhan.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BenhNhan.SuaBenhNhan(et_BenhNhan) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_BenhNhan.DataSource = bus_BenhNhan.getData();
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
            txt_Ho.Clear();
            txt_Ten.Clear();
            txt_DTH.Clear();
            txt_DiaChi.Clear();
            dtp_NgaySinh.Text = DateTime.Now.ToLongDateString();
            cbo_Phai.Text = null;
            cbo_PhongDieuTri.Text = null;
            txt_ID.Focus();
            dgv_BenhNhan.DataSource = bus_BenhNhan.getData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_BenhNhan.DataSource = bus_BenhNhan.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void dgv_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_BenhNhan.CurrentCell.RowIndex;
                txt_ID.Text = dgv_BenhNhan.Rows[dong].Cells[0].Value.ToString();
                txt_Ho.Text = dgv_BenhNhan.Rows[dong].Cells[1].Value.ToString();
                txt_Ten.Text = dgv_BenhNhan.Rows[dong].Cells[2].Value.ToString();
                txt_DTH.Text = dgv_BenhNhan.Rows[dong].Cells[3].Value.ToString(); ;
                txt_DiaChi.Text = dgv_BenhNhan.Rows[dong].Cells[4].Value.ToString();
                dtp_NgaySinh.Text = Convert.ToDateTime(dgv_BenhNhan.Rows[dong].Cells[5].Value.ToString()).ToLongDateString();
                cbo_Phai.Text = dgv_BenhNhan.Rows[dong].Cells[6].Value.ToString();
                cbo_PhongDieuTri.Text = dgv_BenhNhan.Rows[dong].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }


        }

        private void GUI_BenhNhan_FormClosing(object sender, FormClosingEventArgs e)
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
