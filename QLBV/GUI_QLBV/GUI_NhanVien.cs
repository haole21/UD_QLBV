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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        ET_NhanVien et_NhanVien = new ET_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                string[] arrCV = new string[] { "Bảo Vệ", "Tạp Vụ", "Thu Ngân" };
                dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();         
                cbo_ChucVu.DataSource = arrCV;
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
                et_NhanVien.Id = txt_ID.Text;
                et_NhanVien.Ho = txt_Ho.Text;
                et_NhanVien.Ten = txt_Ten.Text;
                et_NhanVien.ChucVu = cbo_ChucVu.Text;
                et_NhanVien.Dth = txt_DTH.Text;
                et_NhanVien.NgayLV = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_NhanVien.Phai = Phai();
                et_NhanVien.DiaChi = txt_DiaChi.Text;
                if (bus_NhanVien.ThemNhanVien(et_NhanVien) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
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
        private string Phai()
        {
            string phai;
            if (rdb_Nam.Checked == true) phai = "NAM";
            else phai = "NỮ";
                return phai; 
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                et_NhanVien.Id = txt_ID.Text;
                et_NhanVien.Ho = txt_Ho.Text;
                et_NhanVien.Ten = txt_Ten.Text;
                et_NhanVien.ChucVu = cbo_ChucVu.Text;
                et_NhanVien.Dth = txt_DTH.Text;
                et_NhanVien.NgayLV = Convert.ToDateTime( dtp_NgayLamViec.Text);
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_NhanVien.Phai =Phai();
                et_NhanVien.DiaChi = txt_DiaChi.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_NhanVien.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_NhanVien.XoaNhanVien(et_NhanVien) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
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
                et_NhanVien.Id = txt_ID.Text;
                et_NhanVien.Ho = txt_Ho.Text;
                et_NhanVien.Ten = txt_Ten.Text;
                et_NhanVien.ChucVu = cbo_ChucVu.Text;
                et_NhanVien.Dth = txt_DTH.Text;
                et_NhanVien.NgayLV = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_NhanVien.Phai = Phai();
                et_NhanVien.DiaChi = txt_DiaChi.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_NhanVien.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_NhanVien.SuaNhanVien(et_NhanVien) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
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
            txt_DiaChi.Clear();
            txt_DTH.Clear();
            cbo_ChucVu.Text = "";
            dtp_NgayLamViec.Text = DateTime.Now.ToString(); 
            dtp_NgaySinh.Text = DateTime.Now.ToString();
            rdb_Nam.Checked = true;
            rdb_Nu.Checked = false;
            txt_ID.Focus();
          
            dgv_NhanVien.DataSource = bus_NhanVien.getDataFromNhanVien();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_NhanVien.DataSource = bus_NhanVien.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void dgv_NhanVien_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_NhanVien.CurrentCell.RowIndex;
                txt_ID.Text = dgv_NhanVien.Rows[dong].Cells[0].Value.ToString();
                txt_Ho.Text = dgv_NhanVien.Rows[dong].Cells[1].Value.ToString();
                txt_Ten.Text = dgv_NhanVien.Rows[dong].Cells[2].Value.ToString();
                txt_DTH.Text = dgv_NhanVien.Rows[dong].Cells[3].Value.ToString();
                txt_DiaChi.Text= dgv_NhanVien.Rows[dong].Cells[4].Value.ToString();
                dtp_NgaySinh.Text = dgv_NhanVien.Rows[dong].Cells[5].Value.ToString();
                if (dgv_NhanVien.Rows[dong].Cells[6].Value.ToString() == "NAM") 
                { rdb_Nam.Checked = true; rdb_Nu.Checked = false; }
                else { rdb_Nu.Checked = true; rdb_Nam.Checked= false; }
                cbo_ChucVu.Text = dgv_NhanVien.Rows[dong].Cells[7].Value.ToString();
                dtp_NgayLamViec.Text = dgv_NhanVien.Rows[dong].Cells[8].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void GUI_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void txt_Key_Enter(object sender, EventArgs e)
        {
            if (txt_Key.Text == "Nhập tên nhân viên cần tìm")
            {
                txt_Key.Text = "";
                txt_Key.ForeColor = Color.Black;
            }
        }

        private void txt_Key_Leave(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
            {
                txt_Key.Text = "Nhập tên nhân viên cần tìm";
                txt_Key.ForeColor = Color.Gray;
            }
        }
    }
}
