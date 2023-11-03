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
using Twilio.TwiML.Voice;
using gymsy.App.Models;
using Pay = gymsy.App.Models.Pay;

namespace gymsy.UserControls
{
    public partial class WalletUserControl : UserControl
    {

        private GymsyDbContext gymsydb = GymsyContext.GymsyContextDB;
        private IEnumerable<Pay> PaysList;

        public WalletUserControl()
        {
            InitializeComponent();
            InitializeData();
            InitializeGridTransactions();
        }

        private void InitializeData()
        {
            if (AppState.person.Wallets.Count > 0)
            {
                TbAmount.Text = $"$ {AppState.person.Wallets.First().Retirable}";
                TbTotalAmount.Text = $"$ {AppState.person.Wallets.First().Total}";
            }
            this.PaysList = AppState.person.PayDestinatarios.ToArray()
                    .Concat(AppState.person.PayRemitentes.ToArray());

            AppState.persons.ForEach(per =>
            {
                if (per.RolId != 3 && per.IdPerson != AppState.person.IdPerson)
                {
                    comboBoxInstructors.Items.Add(new { Text = per.FirstName, Value = per.IdPerson });
                }
            });

        }

        private void InitializeGridTransactions()
        {
            // Concatenar pagos realizados y entrantes
            if (PaysList.Count() > 0)
            {

                dataGridTransactions.Visible = true;
                PanelMsg.Visible = false;

                foreach (Pay pay in PaysList)
                {
                    TimeSpan diferencia = (DateTime.Now - pay.CreatedAt);
                    String formart = $"Hace {diferencia.Days} dias";
                    int destinoId = pay.RemitenteId == AppState.person.IdPerson ? pay.DestinatarioId : pay.RemitenteId;

                    dataGridTransactions.Rows.Add(
                        pay.IdPay,
                        formart,
                        pay.IdPayTypeNavigation.Name,
                        $"$ {pay.Amount}",
                        $"Destino: {destinoId}"
                    );
                }

                dataGridTransactions.Refresh();
            }
            else
            {
                PanelMsg.Visible = true;
            }

        }

        private void AddTransaction(Pay pay)
        {
            TimeSpan diferencia = (DateTime.Now - pay.CreatedAt);
            String formart = $"Hace {diferencia.Days} dias";
            int destinoId = pay.RemitenteId == AppState.person.IdPerson ? pay.DestinatarioId : pay.RemitenteId;

            dataGridTransactions.Rows.Add(
                pay.IdPay,
                formart,
                pay.IdPayTypeNavigation.Name,
                $"$ {pay.Amount}",
                $"Destino: {destinoId}"
            );
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
                if ((Double.Parse(TbAmountTran.Text) > 0) &&
                    AppState.person.Wallets.First().Retirable <= Double.Parse(TbAmountTran.Text)
                    )
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
                ModelPay.Amount = double.Parse(TbAmountTran.Text);
                ModelPay.RemitenteId = AppState.person.IdPerson;
                ModelPay.DestinatarioId = 13;
                ModelPay.IdPayType = 1;
                ModelPay.Inactive = false;

                // Resta monto de billetera
                Wallet WalletModel = AppState.person.Wallets.First();
                WalletModel.Retirable -= double.Parse(TbAmountTran.Text);

                var Pays = this.gymsydb.Pays.Add(ModelPay);
                this.gymsydb.Wallets.Update(WalletModel);

                // Update state
                this.PaysList.ToList().Add(ModelPay);

                TbAmount.Text = $"$ {WalletModel.Retirable}";
                AddTransaction(ModelPay);

                // Save
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
