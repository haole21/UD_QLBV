using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBV
{
    public class ChildrenForm
    {
        private Form currentForm;

        public Form CurrentForm { get => currentForm; set => currentForm = value; }

        public void LoadChildrenFormInPanel(Form childrenForm,Panel pnl_main)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childrenForm;
            childrenForm.TopLevel = false;
            //childrenForm.FormBorderStyle = FormBorderStyle.None;
            //childrenForm.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(childrenForm);
            pnl_main.Tag = childrenForm;
            childrenForm.BringToFront();
            //childrenForm.StartPosition = FormStartPosition.WindowsDefaultLocation; 
            childrenForm.Show();
            

        }
    }
}
