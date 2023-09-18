using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.UserControls
{
    public partial class AddClientUserControl : UserControl
    {
        public AddClientUserControl()
        {
            InitializeComponent();
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una letra del alfabeto
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                // Si no es una letra, ni la tecla de retroceso ni la tecla espacio, suprime la pulsación
                e.Handled = true;
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una letra del alfabeto
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                // Si no es una letra, ni la tecla de retroceso ni la tecla espacio, suprime la pulsación
                e.Handled = true;
            }
        }

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se cancela el evento KeyPress para que no se escriba nada en el textbox
            e.Handled = true;
        }

        private void TBDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se cancela el evento KeyPress para que no se escriba nada en el textbox
            e.Handled = true;
        }
    }
}
