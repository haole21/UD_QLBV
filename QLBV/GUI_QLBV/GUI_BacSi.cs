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
    public partial class GUI_BacSi : Form
    {
        BUS_BacSi bus_BacSi = new BUS_BacSi();
        BUS_Khoa bus_Khoa = new BUS_Khoa();
        ET_BacSi et_BacSi = new ET_BacSi();
        public GUI_BacSi()
        {
            InitializeComponent();
        }



        private void GUI_BacSi_Load(object sender, EventArgs e)
        {
            try
            {
                string[] arrCV = new string[] { "BÁC SĨ HẠNG 1", "BÁC SĨ HẠNG 2", "BÁC SĨ HẠNG 3" };
                dgv_BacSi.DataSource = bus_BacSi.getData();
                cbo_Khoa.DataSource = bus_Khoa.getDataFromKhoa();
                cbo_Khoa.ValueMember = "MAK";
                cbo_Khoa.DisplayMember ="TENK";
                cbo_ChucVu.DataSource = arrCV;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }

        }

        private void dgv_BacSi_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_BacSi.CurrentCell.RowIndex;
                txt_ID.Text = dgv_BacSi.Rows[dong].Cells[0].Value.ToString();
                txt_Ho.Text = dgv_BacSi.Rows[dong].Cells[1].Value.ToString();
                txt_Ten.Text = dgv_BacSi.Rows[dong].Cells[2].Value.ToString();
                cbo_ChucVu.Text = dgv_BacSi.Rows[dong].Cells[3].Value.ToString();
                cbo_Khoa.SelectedValue = dgv_BacSi.Rows[dong].Cells[4].Value.ToString();
                lb_maKhoa.Text = dgv_BacSi.Rows[dong].Cells[4].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_BacSi.Id = txt_ID.Text;
                et_BacSi.Ho = txt_Ho.Text;
                et_BacSi.Ten = txt_Ten.Text;
                et_BacSi.ChucVu = cbo_ChucVu.Text;
                et_BacSi.Khoa = cbo_Khoa.Text;
                if (bus_BacSi.ThemBacSi(et_BacSi) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    dgv_BacSi.DataSource = bus_BacSi.getData();
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
                et_BacSi.Id = txt_ID.Text;
                et_BacSi.Ho = txt_Ho.Text;
                et_BacSi.Ten = txt_Ten.Text;
                et_BacSi.ChucVu = cbo_ChucVu.Text;
                et_BacSi.Khoa = cbo_Khoa.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xoá {et_BacSi.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BacSi.XoaBacSi(et_BacSi) == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    dgv_BacSi.DataSource = bus_BacSi.getData();
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
                et_BacSi.Id = txt_ID.Text;
                et_BacSi.Ho = txt_Ho.Text;
                et_BacSi.Ten = txt_Ten.Text;
                et_BacSi.ChucVu = cbo_ChucVu.Text;
                et_BacSi.Khoa = cbo_Khoa.Text;
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn sửa {et_BacSi.Id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;
                if (bus_BacSi.SuaBacSi(et_BacSi) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    dgv_BacSi.DataSource = bus_BacSi.getData();
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
            cbo_ChucVu.Text = null;
            cbo_Khoa.Text = ""; 
            txt_ID.Focus();
            lb_maKhoa.Text = "";
            dgv_BacSi.DataSource = bus_BacSi.getData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_BacSi.DataSource = bus_BacSi.FindData(txt_key.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi : {ex}", "Thông báo Lỗi"); }
        }
           

        private void GUI_BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel=true;
        }

        private void cbo_Khoa_SelectedValueChanged(object sender, EventArgs e)
        {

            lb_maKhoa.Text =( cbo_Khoa.SelectedValue.ToString() == null )?"": cbo_Khoa.SelectedValue.ToString();
        }

        private void txt_key_Enter(object sender, EventArgs e)
        {
            if(txt_key.Text == "Nhập tên bác sĩ cần tìm")
            {
                txt_key.Text = "";
                txt_key.ForeColor = Color.Black;
            }
        }

        private void txt_key_Leave(object sender, EventArgs e)
        {
            if(txt_key.Text == "")
            {
                txt_key.Text = "Nhập tên bác sĩ cần tìm";
                txt_key.ForeColor = Color.Gray;
            }
        }
    }
}
