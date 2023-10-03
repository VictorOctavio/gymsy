using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.UserControls.AdminControls
{
    public partial class InstructorsAdminControl : UserControl
    {
        public InstructorsAdminControl()
        {
            InitializeComponent();
            initializeDataGrid();
        }

        private void initializeDataGrid()
        {
            dataGridInstructors.Rows.Add("Mac Milla", "34321423", 14, "12/06/2019");
            dataGridInstructors.Rows.Add("Robert William", "34436423", 13, "12/06/2016");
            dataGridInstructors.Rows.Add("Alex", "34342312", 12, "12/06/2017");
        }
    }
}
