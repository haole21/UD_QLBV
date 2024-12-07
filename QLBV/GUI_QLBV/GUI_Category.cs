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
    public partial class GUI_Category : Form
    {
        ChildrenForm child = new ChildrenForm();
        frm_main frm_main = new frm_main();
        GUI_BacSi gui_BacSi = new GUI_BacSi();
        public GUI_Category()
        {
            InitializeComponent();
        }

        private void rdbtn_BacSi_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
