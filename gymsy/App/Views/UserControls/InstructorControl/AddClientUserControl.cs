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
using System.Numerics;
using System.Reflection;

namespace gymsy.UserControls
{
    public partial class AddClientUserControl : UserControl
    {
        private bool isEditMode = false; // Variable para saber si se esta editando o agregando un nuevo cliente
        private int indexRowSelect = 0;
        private GymsyDbContext dbContext;

        public AddClientUserControl()
        {
            this.dbContext = GymsyContext.GymsyContextDB;

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
            if (!string.IsNullOrWhiteSpace(TBUsuario.Text) && this.IsNicknameUnique(TBUsuario.Text) && TBUsuario.PlaceholderText != TBUsuario.Text)
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


            if (!string.IsNullOrWhiteSpace(TBPrecio.Text) || !string.IsNullOrWhiteSpace(TBDescripcion.Text) || !string.IsNullOrWhiteSpace(TBNombreInstructor.Text))
            {
                LPlanRequerido.Visible = false;

            }
            else
            {
                isValid = false;
                LPlanRequerido.Visible = true;
            }


            return isValid;
        }
        private void CargarElementosComboBox()
        {
            try
            {
                //Ahora se cargan los demas elementos

                var trainingPlans = this.dbContext.TrainingPlans.ToList();

                var trainingPlan = trainingPlans.FirstOrDefault();

                if (trainingPlan != null)
                {
                    if(trainingPlan.IdInstructorNavigation != null)
                    {
                        LidPlan.Text = trainingPlan.IdTrainingPlan.ToString();
                        TBPrecio.Text = trainingPlan.Price.ToString();
                        TBDescripcion.Text = trainingPlan.Description;
                        TBNombreInstructor.Text = trainingPlan.IdInstructorNavigation.IdPersonNavigation.FirstName + " " + trainingPlan.IdInstructorNavigation.IdPersonNavigation.LastName;

                        CBPlanes.Items.Add(trainingPlan.Description);
                    }
                    
                }

                foreach (TrainingPlan plan in trainingPlans)
                {
                    if (!plan.Inactive && trainingPlan.IdTrainingPlan != plan.IdTrainingPlan)
                    {
                        CBPlanes.Items.Add(plan.IdTrainingPlan + "-" + plan.Description);
                    }

                }




            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


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


                    string usuario = TBUsuario.Text;

                    int idPlan = int.Parse(LidPlan.Text);
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
                        Nickname = usuario,
                        FirstName = TBNombre.Text,
                        Avatar = SaveImage(TBRutaImagen.Text),
                        Password = TBContraseña.Text,
                        CreatedAt = DateTime.Now,
                        LastName = TBApellido.Text,
                        CBU = usuario,
                        NumberPhone = TBTelefono.Text,
                        Birthday = DPFechaNacimiento.Value,
                        Gender = sexo,
                        RolId = 3,//3 es el rol de cliente
                        Inactive = false
                    };

                    //se guarda en la base de datos, primero la persona por la relacion de la llave foranea
                    this.dbContext.People.Add(persona);
                    this.dbContext.SaveChanges();

                    Client cliente = new Client
                    {
                        LastExpiration = DPVencimiento.Value,//Se le añade un mes mas a la fecha actual
                        IdPerson = persona.IdPerson,
                        IdTrainingPlan = idPlan,
                    };

                    //Se guarda en AppState
                    AppState.clients.Add(persona);



                    this.dbContext.Clients.Add(cliente);
                    this.dbContext.SaveChanges();

                    AppState.needRefreshClientsUserControl = true;
                    MessageBox.Show("Se Guardaron correcctamente los datos");
                    this.restablecerTextBoxes();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exepcion inesperada!" + ex.Message);
                throw;
            }
        }


        /**
         * Guarda en Mis domumentos la imagen seleccionada
         */
        private string SaveImage(string imagePath)
        {
            //Ruta completa para guardar la imagen en la carpeta
            string pathDestinationFolder = Path.Combine(AppState.pathDestinationFolder, AppState.nameCarpetImageClient);


            // Asegúrate de que la carpeta exista, y si no, créala
            if (!Directory.Exists(pathDestinationFolder))
            {
                Directory.CreateDirectory(AppState.pathDestinationFolder);
            }

            // Obtén la extensión de archivo de la imagen original
            string extension = Path.GetExtension(imagePath);

            // Genera un nombre de archivo único usando un GUID y la fecha/hora actual
            string uniqueFileName = Guid.NewGuid().ToString() + DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;

            // Ruta completa para guardar la imagen en la carpeta
            string destinationPath = Path.Combine(pathDestinationFolder, uniqueFileName);

            // Copia la imagen desde la ubicación original a la carpeta de destino
            File.Copy(imagePath, destinationPath, true);

            return uniqueFileName;//nombre del archivo 
        }


        private void CBPlanes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén la descripción seleccionada del ComboBox
            string selectedDescription = CBPlanes.SelectedItem.ToString();

            // Divide la descripción en ID y descripción por medio del -
            string[] parts = selectedDescription.Split('-');

            if (parts.Length == 2)
            {
                // Obtén el ID y realiza las consultas en la base de datos
                int selectedPlanId = int.Parse(parts[0]);
                string selectedPlanDescription = parts[1];

                var trainingPlan = this.dbContext.TrainingPlans
                    .Where(trainingPlan => trainingPlan.IdTrainingPlan == selectedPlanId)
                    .First();

                LidPlan.Text = trainingPlan.IdTrainingPlan.ToString();
                TBPrecio.Text = trainingPlan.Price.ToString();
                TBDescripcion.Text = trainingPlan.Description;
                TBNombreInstructor.Text = trainingPlan.IdInstructorNavigation.IdPersonNavigation.FirstName + " " + trainingPlan.IdInstructorNavigation.IdPersonNavigation.LastName;


            }
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

        // Función para verificar si el 'nickname' es único
        private bool IsNicknameUnique(string nickname)
        {
            try
            {
                // Consulta la base de datos para verificar si ya existe un registro con el mismo 'nickname'
                var existingPerson = this.dbContext.People.FirstOrDefault(p => p.Nickname == nickname);

                // Si 'existingPerson' no es nulo, significa que ya existe un registro con el mismo 'nickname'
                if (existingPerson == null)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el nombre de usuario: " + ex.Message);
                return false;
            }


        }

        public override void Refresh()
        {
            //Carga el comboBox con los planes
            this.CargarElementosComboBox();
            BBack.Visible = AppState.isModeAdd;
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            MainView.navigationControl.Display(1, true);
            AppState.isModeAdd = false;
        }

    
    }



}
