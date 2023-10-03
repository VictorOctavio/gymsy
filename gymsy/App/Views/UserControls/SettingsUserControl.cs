using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
using gymsy.Context;
using gymsy.utilities;
using gymsy.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace gymsy.UserControls
{
    public partial class SettingsUserControl : UserControl, ISettingView
    {
        Person person;
        GymsyDbContext dbContext;
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SettingsUserControl()
        {
            this.person = AppState.person;
            this.dbContext = GymsyContext.GymsyContextDB;

            InitializeComponent();
            InitializeDataComponent();
        }

        private void InitializeDataComponent()
        {
            TbFirstName.Text = person.FirstName;
            TbLastName.Text = person.LastName;
            TbCBU.Text = person.CBU;
            TbPhone.Text = person.NumberPhone;
        }

        Person ISettingView.person
        {
            get { return person; }
            set { person = value; }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {

            panelError.Visible = false;

            // Validate textbox is not null
            List<TextBox> textBoxList = new List<TextBox>()
            {
                TbFirstName, TbLastName, TbCBU, TbPhone
            };
            if (!this.ValidateTextBox(textBoxList)) return;

            // Update global state
            this.person.FirstName = TbFirstName.Text;
            this.person.LastName = TbLastName.Text;
            this.person.CBU = TbCBU.Text;
            this.person.NumberPhone = TbPhone.Text;

            try
            {

                DialogResult confirmAction = MessageBox.Show("Estas seguro de actualizar cambios?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's choice
                if (confirmAction == DialogResult.Yes)
                {
                    updatedDbDataUser();
                }
                
            }
            catch (Exception ex)
            {
                panelError.Visible = true;
            }


        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            panelError.Visible = false;

            List<TextBox> textBoxList = new List<TextBox>()
            {
                tbCurrentPassword, tbNewPassword
            };

            // Validate textbox password is not null
            if (!ValidateTextBox(textBoxList)) return;

            try
            {

                DialogResult confirmAction = MessageBox.Show("Estas seguro de actualizar cambios?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's choice
                if (confirmAction == DialogResult.Yes)
                {
                    updateDbPasswordUser();
                }
              
            }
            catch (Exception ex)
            {
                panelError.Visible = true;
            }
        }

        // Change avatar user
        private void BtnEditAvatar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxAvatar.Text);
        }

        // Validate text box not null
        private bool ValidateTextBox(List<TextBox> textBoxList)
        {
            foreach (TextBox textBoxCurrent in textBoxList)
            {
                if (!Utility.IsValidTextBox(textBoxCurrent, panelError))
                {
                    return false;
                }
            }
            return true;
        }

        // Close panel error
        private void PanelErrorBtnClose_Click(object sender, EventArgs e)
        {
            panelError.Visible = false;
        }

        private void updatedDbDataUser()
        {
            try
            {
                var personUpdated = this.dbContext.People
                                .Where(people => people.IdPerson == this.person.IdPerson)
                                .First();
                personUpdated = this.person;
                this.dbContext.SaveChanges();

                MessageBox.Show("Actualizo Correctamente");
            }
            catch(Exception ex)
            {
                panelError.Visible = true;
                panelErrorText.Text = ex.Message;
            }
            
        }

        private void updateDbPasswordUser()
        {
            try
            {
                var personUpdated = this.dbContext.People
                               .Where(people => people.IdPerson == this.person.IdPerson)
                               .First();

                if (personUpdated != null)
                {
                    if (Bcrypt.ComparePassowrd(tbCurrentPassword.Text, personUpdated.Password))
                    {
                        string encryptNewPass = Bcrypt.HashPassoword(tbNewPassword.Text);
                        personUpdated.Password = encryptNewPass;

                        this.dbContext.SaveChanges();

                        MessageBox.Show("Actualizo Correctamente tu Clave :)");
                    }
                    else
                    {
                        LbErrorChangePass.Text = "Contraseña Incorrecta :(";
                        LbErrorChangePass.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                panelError.Visible = true;
                panelErrorText.Text = ex.Message;
            }

        }
    }
}
