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
    public partial class GUI_HoaDon : Form
    {
        BUS_HoaDon BUS_HoaDon = new BUS_HoaDon();
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        BUS_DichVu BUS_DichVu = new BUS_DichVu();
        BUS_Thuoc BUS_Thuoc = new BUS_Thuoc();
        ET_HoaDon ET_HoaDon = new ET_HoaDon();
        public GUI_HoaDon()
        {
            InitializeComponent();
        }

        private void GUI_HoaDon_Load(object sender, EventArgs e)
        {
        
            try
            {
                cbo_BenhNhan.DataSource =  BUS_BenhNhan.getData();
                cbo_BenhNhan.ValueMember = "MABN";
                cbo_BenhNhan.DisplayMember = "MABN";
                cbo_DichVu.DataSource = BUS_DichVu.getData();
                cbo_DichVu.ValueMember = "MADV";
                cbo_DichVu.DisplayMember = "TENDV";
                cbo_Thuoc.DataSource = BUS_Thuoc.getDataFromThuoc();
                cbo_Thuoc.ValueMember = "MATHUOC";
                cbo_Thuoc.DisplayMember = "TENTHUOC";
                dgv_HoaDon.DataSource = BUS_HoaDon.getDataFromHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo ");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ET_HoaDon.Id = txt_ID.Text;
            ET_HoaDon.BenhNhan = cbo_BenhNhan.Text;
            ET_HoaDon.Thuoc = cbo_Thuoc.Text;
            ET_HoaDon.DichVu = cbo_DichVu.Text;
            ET_HoaDon.Sl = Convert.ToInt32(txt_SL.Text);
            ET_HoaDon.ThanhTien = Convert.ToDouble(txt_ThanhTien.Text);
            if (BUS_HoaDon.ThemHoaDon(ET_HoaDon) == false)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            dgv_HoaDon.DataSource = BUS_HoaDon.getDataFromHoaDon();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ET_HoaDon.Id = txt_ID.Text;
            ET_HoaDon.BenhNhan = cbo_BenhNhan.Text;
            ET_HoaDon.Thuoc = cbo_Thuoc.Text;
            ET_HoaDon.DichVu = cbo_DichVu.Text;
            ET_HoaDon.Sl = Convert.ToInt32(txt_SL.Text);
            ET_HoaDon.ThanhTien = Convert.ToDouble(txt_ThanhTien.Text);
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No) return;
            if (BUS_HoaDon.XoaHoaDon(ET_HoaDon) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            dgv_HoaDon.DataSource = BUS_HoaDon.getDataFromHoaDon();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ET_HoaDon.Id = txt_ID.Text;
            ET_HoaDon.BenhNhan = cbo_BenhNhan.SelectedValue.ToString();
            ET_HoaDon.Thuoc = cbo_Thuoc.SelectedValue.ToString();
            ET_HoaDon.DichVu = cbo_DichVu.SelectedValue.ToString();
            ET_HoaDon.Sl = Convert.ToInt32(txt_SL.Text);
            ET_HoaDon.ThanhTien = Convert.ToDouble(txt_ThanhTien.Text);
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi dữ liệu không !", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No) return;
            if (BUS_HoaDon.SuaHoaDon(ET_HoaDon) == false)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            dgv_HoaDon.DataSource = BUS_HoaDon.getDataFromHoaDon();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            cbo_BenhNhan.Text = "";
            cbo_Thuoc.Text = "";
            cbo_DichVu.Text = "";
            txt_SL.Clear();
            txt_ThanhTien.Clear();
            dgv_HoaDon.DataSource = BUS_HoaDon.getDataFromHoaDon();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_HoaDon.DataSource = BUS_HoaDon.FindData(txt_Key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }

        private void dgv_HoaDon_Click(object sender, EventArgs e)
        {
            int dong = dgv_HoaDon.CurrentCell.RowIndex;
            txt_ID.Text = dgv_HoaDon.Rows[dong].Cells[0].Value.ToString();
            cbo_DichVu.SelectedValue = dgv_HoaDon.Rows[dong].Cells[1].Value.ToString();
            cbo_BenhNhan.SelectedValue = dgv_HoaDon.Rows[dong].Cells[2].Value.ToString();
            cbo_Thuoc.SelectedValue = dgv_HoaDon.Rows[dong].Cells[3].Value.ToString();
            txt_SL.Text = dgv_HoaDon.Rows[dong].Cells[4].Value.ToString();
            txt_ThanhTien.Text = dgv_HoaDon.Rows[dong].Cells[5].Value.ToString();
        }

        private void GUI_HoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
