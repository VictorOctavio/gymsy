using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gymsy
{
    public partial class LoginDesing : Form
    {
        public LoginDesing()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1("admin");
            form1.Show();
            return;

            //se captura un error en caso de haberlo
            try
            {
                // Validar que los campos no estén vacíos o solo con espacios
                if (string.IsNullOrWhiteSpace(textBoxEmailUser.Text) || string.IsNullOrWhiteSpace(textBoxPasswordUser.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Si no verifica el formato de correo electronico
                    if (!IsValidEmail(textBoxEmailUser.Text))
                    {
                        //Mostrar un mensaje de error debajo del textBox

                    }
                    else
                    {

                        //No hubo error debe procederse a validar en la base de datos

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmailUser_TextChanged(object sender, EventArgs e)
        {
            //se captura un error en caso de haberlo
            try
            {

            }
            catch (Exception ex)
            {//Se muestra un menaje de que ocurrio algo inesperado
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para validar el formato del correo electrónico utilizando expresiones regulares.
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void textBoxPasswordUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
