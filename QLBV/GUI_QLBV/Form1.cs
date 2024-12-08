using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_QLBV
{
    public partial class frm_main : Form
    {
      
        ChildrenForm child = new ChildrenForm();
     
       
        GUI_BHYT gui_BHYT = new GUI_BHYT();
       
        public frm_main()
        {
            InitializeComponent();
        }
        private void quảnLýBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {

            child.LoadChildrenFormInPanel(new GUI_BacSi(), pnl_main);
        }

        private void quảnLýBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BenhAn(), pnl_main);
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BenhNhan(), pnl_main);
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel( new GUI_DichVu(), pnl_main);
        }

        private void quảnLýĐiềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_DieuTri(), pnl_main);
        }

        private void mànHìnhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (child.CurrentForm != null)
            {
                child.CurrentForm.Close();
            }
        }

        private void quảnLýBảoHiểmYTếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_BHYT(), pnl_main);
        }

        private void quảnLýHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_HoaDon(), pnl_main);
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_KhamBenh(), pnl_main);
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_Khoa(), pnl_main);
        }

        private void quảnLýKhoaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_KhoaNV(), pnl_main);
        }

        private void quảnLýLịchSửBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_LichSuBA(), pnl_main);
        }

        private void quảnLýMuaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new GUI_MuaThuoc(), pnl_main);
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) e.Cancel = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu xảy ra lỗi gì xin bạn hãy liên hệ với email của chúng tôi Teamwork@gmail.com", "Thông báo");
        }

        private void nhânViênĐiềuDưỡngHiệnĐangCôngTácTạiBệnhViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new frm_InDanhSachNhanVien(),pnl_main);
        }

        private void nhữngBệnhNhânĐangCònĐiềuTrịTạiBệnhViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new frm_DanhSachBenhNhanDangDuocDieuTri(), pnl_main);
        }

        private void danhSáchBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new frm_InDanhSachBacSi(),pnl_main);
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new frm_InThongTinBenhNhan(),pnl_main);
        }

        private void danhSáchKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.LoadChildrenFormInPanel(new frm_InDanhSachBenhNhanDiKhamBenh(),pnl_main);
        }
    }
    
   
    
}
