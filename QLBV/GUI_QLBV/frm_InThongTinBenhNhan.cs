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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GUI_QLBV
{
    public partial class frm_InThongTinBenhNhan : Form
    {
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        public frm_InThongTinBenhNhan()
        {
            InitializeComponent();
        }

        private void cbo_BenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            // khơi tạo crystal report 
            crt_ThongTinBenhNhan rp = new crt_ThongTinBenhNhan();
            // khai báo tham số cho report 
            ParameterValues para = new ParameterValues();
            // khai báo giá trị 
            ParameterDiscreteValue parValue = new ParameterDiscreteValue();
            // gán giá trị 
            parValue.Value = cbo_BenhNhan.SelectedValue.ToString();
            // thêm giá trị vào biến 
            para.Add(parValue);
            // gán giá trị cho tham số report 
            rp.DataDefinition.ParameterFields["@MABN"].ApplyCurrentValues(para);
            // gán lại  cho report source 
            crystalReportViewer1.ReportSource = rp; 
        }

        private void frm_InThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            cbo_BenhNhan.DataSource = BUS_BenhNhan.getData();
            cbo_BenhNhan.ValueMember = "MABN";
            cbo_BenhNhan.DisplayMember = "MABN";
        }
    }
}
