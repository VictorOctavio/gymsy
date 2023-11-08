using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.utilities
{
    internal class Utility
    {
        public static bool IsValidTextBox(TextBox textBox, Panel panelError, String text = "Completa Campos Requeridos")
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text)) return true;
            else
            {
                panelError.Visible = true;
                return false;
            };
        }


        public static bool IsValidTextBox(TextBox textBox, Label labelError)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text)) return true;
            else
            {
                labelError.Visible = true;
                return false;
            };
        }


        public static bool IsValidTextBoxRJ(RJTextBox textBox, Label labelError)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text)) return true;
            else
            {
                labelError.Visible = true;
                return false;
            };
        }

        public static bool IsValidComboBox(ComboBox comboBox, Button btnError)
        {
            if (!String.IsNullOrWhiteSpace(comboBox.Text)) return true;
            else
            {
                btnError.Visible = true;
                return false;
            };
        }


        public static void TextBoxOnlyNumbersWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the keypress
            }

            // Allow only one decimal point
            /*
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true; // Ignore the keypress
            }*/
        }

    }
}
