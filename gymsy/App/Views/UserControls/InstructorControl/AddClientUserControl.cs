using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace gymsy.UserControls
{
    public partial class AddClientUserControl : UserControl
    {
        private bool isEditMode = false; // Variable para saber si se esta editando o agregando un nuevo cliente


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

        private void BGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            { //Se verifica que se hayan ingresado todos los datos

                if (!this.isEditMode) //Si no se usa la vista para editar se deben guardar los datos
                {

                }
                else //La vista esta en modo edicion se deven editar los datos
                {

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Exepcion inesperada!");
                throw;
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
            if (!string.IsNullOrWhiteSpace(TBNombre.Text.Trim()))
            {
                //Se verifica que se hay ingresado un apellido
                if (!string.IsNullOrWhiteSpace(TBApellido.Text.Trim()))
                {
                    //Se verifica que se hay ingresado un telefono
                    if (!string.IsNullOrWhiteSpace(TBTelefono.Text.Trim()))
                    {
                        //Se verifica que se hay ingresado un correo
                        if (!string.IsNullOrWhiteSpace(TBUsuario.Text.Trim()))
                        {
                            //Se verifica que se hay ingresado una contraseña
                            if (!string.IsNullOrWhiteSpace(TBContraseña.Text.Trim()))
                            {
                                if (!string.IsNullOrWhiteSpace(TBRutaImagen.Text.Trim()))
                                {
                                    if (!string.IsNullOrWhiteSpace(TBPrecio.Text.Trim()))
                                    {
                                        if (!string.IsNullOrWhiteSpace(TBDescripcion.Text.Trim()))
                                        {
                                            if (!string.IsNullOrWhiteSpace(TBNombreInstructor.Text.Trim()))
                                            {

                                            } else
                                            {
                                                isValid = false;
                                            }
                                        } else
                                        {
                                            isValid = false;
                                        }

                                    } else
                                    {
                                        isValid = false;
                                    }



                                    // Ya que los campos son validos se deven ocultar los mensajes de error
                                    LNombreRequerido.Visible = false;
                                    LApellidoRequerido.Visible = false;
                                    LTelefonoRequerido.Visible = false;
                                    LCorreoRequerido.Visible = false;
                                    LContraseñaRequerido.Visible = false;



                                } else
                                {
                                    isValid = false;
                                }

                            } else
                            {
                                isValid = false;
                            }
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    else
                    {
                        
                        isValid = false;
                    }
                }
                else
                {
                    LApellidoRequerido.Visible = true;
                    isValid = false;
                }
            }
            else
            {
                LNombreRequerido.Visible = true;
                isValid = false;
            }


            return isValid;
        }

    }



}
