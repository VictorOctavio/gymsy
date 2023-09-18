using gymsy.Models;
using gymsy.utilities;
using Microsoft.EntityFrameworkCore;
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

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            labelErrorPass.Visible = false;
            labelErrorNickname.Visible = false;

            //se captura un error en caso de haberlo
            try
            {
                // Validar que los campos no estén vacíos o solo con espacios
                if (!Utility.IsValidTextBox(textBoxEmailUser, labelErrorNickname)
                    || !Utility.IsValidTextBox(textBoxPasswordUser, labelErrorPass)) return;
                else
                {

                    //this.Hide();
                    Form1 initForm = new Form1("instructor");
                    initForm.Show();

                }
            }
            catch (Exception ex)
            {
                labelErrorPass.Text = "Nickname o Contraseña incorrecta :( ";
                labelErrorPass.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
