using gymsy.App.Models;
using gymsy.Context;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.UserControls.AdminControls
{
    public partial class AddInstructorControl : UserControl
    {
        private bool isEditMode = false; // Variable para saber si se esta editando o agregando 
        public AddInstructorControl()
        {
            InitializeComponent();
        }

        private void BGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            { //Se verifica que se hayan ingresado todos los datos
                bool isValidTextBoxes = isValidTextsBoxesMostrarError();
                if (isValidTextBoxes)
                {

                    if (!this.isEditMode) //Si no se usa la vista para editar se deben guardar los datos
                    {
                        string nombre = TBNombre.Text;
                        string apellido = TBApellido.Text;
                        string telefono = TBTelefono.Text;
                        string usuario = TBUsuario.Text;
                        string contraseña = TBContraseña.Text;
                        string rutaImagen = TBRutaImagen.Text;

                        string sexo = "";

                        if (RBMasculino.Checked)
                        {
                            sexo = "M";
                        }
                        else
                        {
                            sexo = "F";
                        }





                        Person persona = new Person
                        {
                            IdPerson = SimularBD.idPerson,
                            Nickname = usuario,
                            FirstName = nombre,
                            Avatar = rutaImagen,
                            Password = contraseña,
                            CreatedAt = DateTime.Now,
                            LastName = apellido,
                            CBU = "CBU5",
                            NumberPhone = telefono,
                            Birthday = DateTime.Now.AddMonths(1),
                            Gender = sexo,
                            RolId = 3,
                            Inactive = false
                        };

                        SimularBD.persons.Add(persona);
                        SimularBD.idPerson++;


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
                        IPImagenInstructor.Image = System.Drawing.Image.FromFile(rutaImagen);
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
    }
}
