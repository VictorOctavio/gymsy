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

namespace gymsy.UserControls
{
    public partial class AddClientUserControl : UserControl
    {
        private bool isEditMode = false; // Variable para saber si se esta editando o agregando un nuevo cliente


        public AddClientUserControl()
        {
            InitializeComponent();

            // Inicializar el contexto de la base de datos
            //GymsyContext dbContext = new GymsyContext();

            //Carga el comboBox con los planes
            CargarElementosComboBox();
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

        /*
          /// <summary>
        /// Se verifica que todos los textbox esten llenos
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>
      private bool IsValidTextBoxes(List<TextBox> textBoxes, List<Label> labels)
      {

          bool isValid = true; // Suponemos que todos los TextBox son válidos hasta que encontremos uno inválido

          foreach (TextBox textBox in textBoxes)
          {

              if (string.IsNullOrWhiteSpace(textBox.Text))
              {
                  isValid = false; // Si al menos uno es inválido, cambiamos el estado a falso
                  textBox.Tag = "Requerido"; // Usamos la propiedad "Tag" para marcar el TextBox como requerido
              }
              else
              {
                  textBox.Tag = null; // Si es válido, eliminamos la marca
              }
          }

          // Mostrar las etiquetas de error
          foreach (Label label in labels)
          {
              if (label.Tag != null && control.Tag.ToString() == "Requerido" && control is Label)
              {
                      label.Visible = true;
              }
              else if (label is Label)
              {
                      label.Visible = false;
              }
          }

          return isValid;
      }
        */

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
            if (!string.IsNullOrWhiteSpace(TBContraseña.Text) && TBContraseña.PlaceholderText != TBContraseña.Text)
            {
                LContraseñaRequerido.Visible = false;
            }
            else
            {
                isValid = false;
                LContraseñaRequerido.Visible = true;
                //MessageBox.Show("Con");
            }

            if (!string.IsNullOrWhiteSpace(TBRutaImagen.Text) && (TBRutaImagen.PlaceholderText != TBRutaImagen.Text))
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


            /*Cargar los planes desde la base de datos
             
            
            // Cargar la descripción de los planes desde la base de datos
            var planes = dbContext.Plan.ToList();

            // Limpiar el ComboBox antes de agregar elementos
            comboBox1.Items.Clear();

            foreach (var plan in planes)
            {
                // Agregar la descripción del plan al ComboBox
                comboBox1.Items.Add(plan.Descripcion);
            }

            // Establecer un elemento predeterminado seleccionado (opcional)
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                MostrarInformacionSeleccionada(0); // Mostrar información relacionada al elemento predeterminado
            }
             
             
             */

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

                    if (!this.isEditMode) //Si no se usa la vista para editar se deben guardar los datos
                    {
                        MessageBox.Show("Se Guardaron correcctamente los datos");
                    }
                    else //La vista esta en modo edicion se deven editar los datos
                    {
                        MessageBox.Show("Se Editaron correcctamente los datos");
                    }

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
    }



}
