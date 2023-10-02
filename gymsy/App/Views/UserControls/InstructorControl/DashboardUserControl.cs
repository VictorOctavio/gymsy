using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.UserControls
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();
            InitializeGrid();
       

        }

        public void InitializeGrid()
        {
            dataGridView2.Rows.Add(0, "Mauro Zarate", "22/11/2023", null);
            dataGridView2.Rows.Add(1, "Dario Benedetto", "22/11/2023", null);
            dataGridView2.Rows.Add(2, "Juan Ramirez", "22/11/2023", null);
            dataGridView2.Rows.Add(3, "Mauro Zarate", "22/11/2023", null);

            dataGridView1.Rows.Add(0, "Mauro Zarate", "22/11/2023", null);
            dataGridView1.Rows.Add(1, "Dario Benedetto", "22/11/2023", null);
            dataGridView1.Rows.Add(2, "Juan Ramirez", "22/11/2023", null);
            dataGridView1.Rows.Add(3, "Mauro Zarate", "22/11/2023", null);

        }

    }
}
