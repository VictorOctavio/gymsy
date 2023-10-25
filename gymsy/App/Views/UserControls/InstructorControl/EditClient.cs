using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using gymsy.Context;
using gymsy.App.Models;

namespace gymsy.UserControls
{
    public partial class EditClient : UserControl
    {
        private int indexRowSelect = 0;

        public EditClient()
        {
            InitializeComponent();

            //Se carga el cliente
            this.CargarCliente();
            //Carga el comboBox con los planes
            this.CargarElementosComboBox();

        }

        private void CargarCliente()
        {
            if(AppState.ClientActive != null)
            {
                TBNombre.Text = AppState.ClientActive.IdPersonNavigation.FirstName;
                TBApellido.Text = AppState.ClientActive.IdPersonNavigation.LastName;
                TBTelefono.Text = AppState.ClientActive.IdPersonNavigation.NumberPhone;
                TBUsuario.Text = AppState.ClientActive.IdPersonNavigation.Nickname;
                //Que hacer con la contraseña?
                //TBContraseña.Text = AppState.ClientActive.IdPersonNavigation.;
                TBRutaImagen.Text = AppState.ClientActive.IdPersonNavigation.Avatar;
                if(AppState.ClientActive.IdPersonNavigation.Gender == "M" || AppState.ClientActive.IdPersonNavigation.Gender == "m")
                {
                    RBMasculino.Checked = true;
                } else
                {
                    RBFemenino.Checked = true;
                }
                DPFechaNacimiento.Value = AppState.ClientActive.IdPersonNavigation.Birthday;



            }
            
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


        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se cancela el evento KeyPress para que no se escriba nada en el textbox
            e.Handled = true;
        }

        private void BTAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Seleccione la imagen";
                // Configurar el filtro de archivos para mostrar solo imágenes
                openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

                // Mostrar el cuadro de diálogo
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Obtener la ruta del archivo seleccionado
                        string rutaImagen = openFileDialog1.FileName;

                        // Mostrar la imagen en el PictureBox
                        IPImagenUsuario.Image = System.Drawing.Image.FromFile(rutaImagen);
                        //se escribe en textbox la ruta de la imagen
                        TBRutaImagen.Text = rutaImagen;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir la imagen: " + ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Exepcion Inesperado");
            }

        }



        private bool isValidTextsBoxesMostrarError()
        {
            bool isValid = true;

            //Se verifica que se hay ingresado un nombre
            if (!string.IsNullOrWhiteSpace(TBNombre.Text) && TBNombre.PlaceholderText != TBNombre.Text)
            {
                LNombreRequerido.Visible = false;
            }
            else
            {
                LNombreRequerido.Visible = true;
                isValid = false;
            }

            //Se verifica que se hay ingresado un apellido
            if (!string.IsNullOrWhiteSpace(TBApellido.Text) && TBApellido.PlaceholderText != TBApellido.Text)
            {
                LApellidoRequerido.Visible = false;
            }
            else
            {
                LApellidoRequerido.Visible = true;
                isValid = false;
            }

            //Se verifica que se hay ingresado un telefono
            if (!string.IsNullOrWhiteSpace(TBTelefono.Text) && TBTelefono.PlaceholderText != TBTelefono.Text)
            {
                LTelefonoRequerido.Visible = false;
            }
            else
            {

                isValid = false;
                LTelefonoRequerido.Visible = true;
            }

            //Se verifica que se hay ingresado un correo
            if (!string.IsNullOrWhiteSpace(TBUsuario.Text) && TBUsuario.PlaceholderText != TBUsuario.Text)
            {
                LUsurioRequerido.Visible = false;
            }
            else
            {
                isValid = false;
                LUsurioRequerido.Visible = true;
            }

            //Se verifica que se hay ingresado una contraseña
            if (!string.IsNullOrWhiteSpace(TBContraseña.Text))
            {
                LContraseñaRequerido.Visible = false;
            }
            else
            {
                isValid = false;
                LContraseñaRequerido.Visible = true;
                //MessageBox.Show("Con");
            }

            if (!string.IsNullOrWhiteSpace(TBRutaImagen.Text))
            {
                LRuraImagen.Visible = false;

            }
            else
            {
                isValid = false;
                LRuraImagen.Visible = true;

                //MessageBox.Show("Debe seleccionar una imagen");
            }

            /*
            if (string.IsNullOrWhiteSpace(TBPrecio.Text.Trim()) || string.IsNullOrWhiteSpace(TBDescripcion.Text.Trim()) || string.IsNullOrWhiteSpace(TBNombreInstructor.Text.Trim()))
            {
                LPlanRequerido.Visible = false;

            }
            else
            {
                isValid = false;
                LPlanRequerido.Visible = true;
            }
            */

            return isValid;
        }
        private void CargarElementosComboBox()
        {



            // Puedes agregar elementos al ComboBox de diferentes maneras.
            // En este ejemplo, los agregaremos manualmente:

            // Método 1: Agregar elementos uno por uno
            CBPlanes.Items.Add("Complemento");
            CBPlanes.Items.Add("Complemento+KickBoxing");
            CBPlanes.Items.Add("Complemento+PersonalTraining");

            // Método 2: Agregar una matriz de elementos
            string[] elementos = { "Elemento 4", "Elemento 5", "Elemento 6" };
            CBPlanes.Items.AddRange(elementos);

            // También puedes cargar elementos desde una lista o cualquier otra fuente de datos.

            // Establece un elemento predeterminado seleccionado (opcional)
            CBPlanes.SelectedIndex = 0;

            TBPrecio.Text = "260.99";
            TBDescripcion.Text = "Complemento";
            TBNombreInstructor.Text = "Juan Perez";

        }

        private void TBPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Se cancela el evento KeyPress para que no se escriba nada en el textbox
            e.Handled = true;
        }

        private void TBDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se cancela el evento KeyPress para que no se escriba nada en el textbox
            e.Handled = true;
        }

        private void TBNombreInstructor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se cancela el evento KeyPress para que no se escriba nada en el textbox
            e.Handled = true;
        }

        private void BGuardarCliente_Click_1(object sender, EventArgs e)
        {
            try
            { //Se verifica que se hayan ingresado todos los datos
                bool isValidTextBoxes = isValidTextsBoxesMostrarError();
                if (isValidTextBoxes)
                {



                    MessageBox.Show("Se Editaron correcctamente los datos");
                    this.restablecerTextBoxes();
                    MainView.navigationControl.Display(1);
                                

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Exepcion inesperada!");
                throw;
            }
        }

        private void CBPlanes_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            TBPrecio.Text = "299.99";
            TBDescripcion.Text = "Complemento++";
            TBNombreInstructor.Text = "Juansito Perez";
        }

        private void restablecerTextBoxes()
        {
            TBNombre.Text = "";
            TBApellido.Text = "";
            TBTelefono.Text = "";
            TBUsuario.Text = "";
            TBContraseña.Text = "";
            TBRutaImagen.Text = "";
            RBMasculino.Checked = true;
        }


    }



}
