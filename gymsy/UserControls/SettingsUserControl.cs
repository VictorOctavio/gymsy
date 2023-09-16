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
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            // Validate textbox is not null
            List<TextBox> textBoxList = new List<TextBox>()
            {
                tbName, tbSurname, tbNickname, tbEmail
            };
            if (!this.ValidateTextBox(textBoxList)) return;


            MessageBox.Show("Data correcta");
        }




        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            List<TextBox> textBoxList = new List<TextBox>()
            {
                tbCurrentPassword, tbNewPassword
            };

            // Validate textbox password is not null
            if (!ValidateTextBox(textBoxList)) return;

        }

        // Change avatar user
        private void btnEditAvatar_Click(object sender, EventArgs e)
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
        private void panelErrorBtnClose_Click(object sender, EventArgs e)
        {
            panelError.Visible = false;
        }

        private void settingsWrapper_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
