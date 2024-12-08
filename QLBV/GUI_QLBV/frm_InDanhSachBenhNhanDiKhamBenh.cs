using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using BUS_QLBV;

namespace GUI_QLBV
{
    public partial class frm_InDanhSachBenhNhanDiKhamBenh : Form
    {
        BUS_Khoa bus_Khoa = new BUS_Khoa();
        BUS_PhongKham bus_PhongKham = new BUS_PhongKham();
        private string mak;
        private string mapk;

        public string Mak { get => mak; set => mak = value; }
        public string Mapk { get => mapk; set => mapk = value; }

        public frm_InDanhSachBenhNhanDiKhamBenh()
        {
            InitializeComponent();
        }

        private void frm_InDanhSachBenhNhanDiKhamBenh_Load(object sender, EventArgs e)
        {
            cbo_Khoa.DataSource= bus_Khoa.getDataFromKhoa();
            cbo_Khoa.ValueMember = "MAK";
            cbo_Khoa.DisplayMember = "TENK";
            cbo_PK.DataSource = bus_PhongKham.getDataFromPhongKham();
            cbo_PK.ValueMember = "MAPK";
            cbo_PK.DisplayMember = "MAPK";
        }

        private void cbo_Khoa_SelectedValueChanged(object sender, EventArgs e)
        {
           mak = cbo_Khoa.SelectedValue.ToString();
        }

        private void cbo_PK_SelectedValueChanged(object sender, EventArgs e)
        {
            mapk = cbo_PK.SelectedValue.ToString();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            // khởi tạo 
            crt_DanhSachBenhNhanDiKhamBenh rp = new crt_DanhSachBenhNhanDiKhamBenh();
            // khởi tạo tham số cho crystal 
            ParameterValues para1 = new ParameterValues();
            ParameterValues para2 = new ParameterValues();
            // khai báo biến giá trị 
            ParameterDiscreteValue parValue1 = new ParameterDiscreteValue();
            ParameterDiscreteValue parValue2 = new ParameterDiscreteValue();
            // thêm giá trị vào cho biến 
            parValue1.Value = mapk;
            parValue2.Value = mak;
            // them giá trị cho viến 
            para1.Add(parValue1);
            para2.Add(parValue2);
            // gán giá trị tham số cho report 
            rp.DataDefinition.ParameterFields["@MAPK"].ApplyCurrentValues(para1);
            rp.DataDefinition.ParameterFields["@MAK"].ApplyCurrentValues(para2);
            // gán lại cho resource 
            crystalReportViewer1.ReportSource = rp; 


        }
    }
}
