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
    }
}
