using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
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
using TextBox = System.Windows.Forms.TextBox;

namespace gymsy.UserControls
{
    public partial class SettingsUserControl : UserControl, ISettingView
    {
        Person person;
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SettingsUserControl(Person person)
        {
            this.person = person;
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

            // Validate textbox is not null
            List<TextBox> textBoxList = new List<TextBox>()
            {
                TbFirstName, TbLastName, TbCBU, TbPhone
            };
            if (!this.ValidateTextBox(textBoxList)) return;


            MessageBox.Show("Data correcta");
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {

            List<TextBox> textBoxList = new List<TextBox>()
            {
                tbCurrentPassword, tbNewPassword
            };

            // Validate textbox password is not null
            if (!ValidateTextBox(textBoxList)) return;

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

        private void SettingsWrapper_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
