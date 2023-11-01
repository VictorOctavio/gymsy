using gymsy.App.Models;
using gymsy.Context;
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

        private GymsyDbContext gymsydb = GymsyContext.GymsyContextDB;

        public WalletUserControl()
        {
            InitializeComponent();
            InitializeGridTransactions();
            InitializeData();
        }

        private void InitializeData()
        {
            if (AppState.person.Wallets.Count > 0)
            {
                TbAmount.Text = $"$ {AppState.person.Wallets.First().Retirable}";
                TbTotalAmount.Text = $"$ {AppState.person.Wallets.First().Total}";
            }
        }

        private void InitializeGridTransactions()
        {
            if (!AppState.person.Equals(null))
            {

                var Pays = AppState.person.PayDestinatarios
                    .Concat(AppState.person.PayRemitentes).ToArray();

                if (Pays.Length > 0)
                {
                    dataGridTransactions.Rows.Add(0, "01/07/23", "Tranferencia", "$ 27000", "Destino: Luka Romero [Instructor]");
                    dataGridTransactions.Rows.Add(1, "01/06/23", "Retiro", "$ 17500", "Destino: Tú");
                }
                else
                {
                    PanelMsg.Visible = true;
                }
            }
        }

        private void TextBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxOnlyNumbersWithDecimal(sender, e);
        }

        private void BtnNewTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                // Ocultar errores anteriores
                labelTransactionError.Visible = false;

                // Validamos dinero disponible en su billetera
                if (!CheckAvailableMoney(float.Parse(TbAmountTransaction.Text)))
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

                // se hace la transaccion
                Pay ModelPay = new Pay();
                ModelPay.CreatedAt = DateTime.Now;
                ModelPay.Amount = float.Parse(TbAmount.Text);
                ModelPay.RemitenteId = AppState.person.IdPerson;
                ModelPay.DestinatarioId = 1;
                ModelPay.IdPayType = 1;
                ModelPay.Inactive = false;

                this.gymsydb.Pays.Add(ModelPay);
                this.gymsydb.SaveChanges();

                PanelInvoiceWallet.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (!CheckAvailableMoney(float.Parse(textBoxWithdraw.Text)))
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

        private bool CheckAvailableMoney(float money = 0)
        {
            return float.Parse(TbAmount.Text) >= money;
        }

        private void BtnCloseInvoice_Click(object sender, EventArgs e)
        {
            PanelInvoiceWallet.Visible = false;
        }

        
    }
}
