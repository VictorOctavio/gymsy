using gymsy.utilities;
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
    public partial class WalletUserControl : UserControl
    {
        public WalletUserControl()
        {
            InitializeComponent();
            InitializeGridTransactions();
        }

        private void InitializeGridTransactions()
        {
            dataGridTransactions.Rows.Add(0, "01/07/23", "Tranferencia", "$ 27000", "Destino: Luka Romero [Instructor]");
            dataGridTransactions.Rows.Add(1, "01/06/23", "Retiro", "$ 17500", "Destino: Tú");
        }

        private void TextBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxOnlyNumbersWithDecimal(sender, e);
        }

        private void BtnNewTransaction_Click(object sender, EventArgs e)
        {
            // Ocultar errores anteriores
            labelTransactionError.Visible = false;

            try
            {

                // Validamos dinero disponible en su billetera
                if (!CheckAvailableMoney(Double.Parse(textBoxAmount.Text)))
                {
                    labelTransactionError.Text = "Fondos insuficientes";
                    labelTransactionError.Visible = true;
                    return;
                }

                // Validamos instructor
                if (!Utility.IsValidComboBox(comboBoxInstructors, labelTransactionError))
                {
                    labelTransactionError.Text = "Necesitas seleccionar 1 instructor";
                    return;
                }

                PanelInvoiceWallet.Visible = true;
            }
            catch
            {
                labelTransactionError.Text = "Error Inesperado";
                labelTransactionError.Visible = true;
            }
        }

        private void BtnNewWithdraw_Click(object sender, EventArgs e)
        {
            // Ocultar errores anteriores
            labelErrorWithdraw.Visible = false;

            try
            {

                // Validamos dinero disponible en su billetera
                if (!CheckAvailableMoney(Double.Parse(textBoxWithdraw.Text)))
                {
                    labelErrorWithdraw.Text = "Fondos insuficientes";
                    labelErrorWithdraw.Visible = true;
                    return;
                }

            }
            catch
            {
                labelErrorWithdraw.Text = "Error Inesperado";
                labelErrorWithdraw.Visible = true;
            }

            PanelInvoiceWallet.Visible = true;
        }

        private bool CheckAvailableMoney(double money = 0)
        {
            double wallet = 25600.65;
            return wallet >= money;
        }

        private void BtnCloseInvoice_Click(object sender, EventArgs e)
        {
            PanelInvoiceWallet.Visible = false;
        }

        
    }
}
