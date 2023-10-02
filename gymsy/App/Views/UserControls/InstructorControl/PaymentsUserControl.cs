using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.UserControls
{
    public partial class PaymentsUserControl : UserControl
    {
        public PaymentsUserControl()
        {
            InitializeComponent();
            InitializeGridProgress();
        }

        private void InitializeGridProgress()
        {
            dataGridPayments.Rows.Add(0, "12/07/23", "pago cuota", "$8222", "Martin Zalazar Pago Cuota (1 mes)");
            dataGridPayments.Rows.Add(1, "11/07/23", "pago cuota", "$8222", "Ramon Gutierrez Pago Cuota (1 mes)");
            dataGridPayments.Rows.Add(2, "08/17/23", "pago cuota", "$7500", "Roman Martinez Pago Cuota (1 mes)");
            dataGridPayments.Rows.Add(3, "01/06/23", "pago cuota", "$7500", "Fernando Gago Pago Cuota (1 mes)");
        }


    }
}
