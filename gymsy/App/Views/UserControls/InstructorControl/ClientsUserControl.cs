using gymsy.App.Models;
using gymsy.App.Views;
using gymsy.Context;
using gymsy.Properties;
using gymsy.UserControls.ClientControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace gymsy.UserControls
{
    public partial class ClientsUserControl : UserControl
    {
        private GymsyDbContext dbContext;
        private int indexRowSelect = 0;
        /*
         * Por defecto se muestran los usuarios que no han sido eliminados, Por lo que el modo es delete
         * lo que para los usuarios es inactivo. Es por ello que usara true y para inactivar un usuario
         * lo contrario al modo delete es decir false
         */
        private bool isModeVerNoDelete = true;

        private List<Client> clients = new List<Client>();
      

        public ClientsUserControl()
        { 
            //Se trae el contexto de la base de datos
            this.dbContext = GymsyContext.GymsyContextDB;

            InitializeComponent();


            this.cargarPersonas();
            //Cargar DataGrid
            bool isnotDelete = true;
            this.mostrar(isnotDelete);
        }


        private void DGUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                // Se ha hecho clic en una celda válida
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;


                int IdClientSelected = int.Parse(DGUsers.Rows[rowIndex].Cells["IdClient"].Value.ToString());
                
                var clientSelected = this.dbContext.Clients
                                .Where(client => client.IdClient == IdClientSelected)
                                .First();
                

         

                // Navigate to training history
                if (clientSelected != null)
                {
                    AppState.ClientActive = clientSelected;
                    MainView.navigationControl.Display(7, true);
                }

            }
            
        }

        private void DataGridViewCellEventArgs(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DGUsers.Cursor = Cursors.Hand;
            }
            else
            {
                DGUsers.Cursor = Cursors.Default;
            }
        }



        private void cargarPersonas()
        {
            // Limpia cualquier ordenación previa en el DataGridView
            DGUsers.Sort(DGUsers.Columns[0], ListSortDirection.Ascending);

            foreach (TrainingPlan plan in AppState.Instructor.TrainingPlans)
            {
                foreach (Client client in plan.Clients.ToArray())
                {

                    // Expiration 
                    TimeSpan diferencia = client.LastExpiration - DateTime.Now;

                    string ColumnExpirationMsg = diferencia.Days > 0 ?
                        ("En " + diferencia.Days + " días") : ("Hace " + diferencia.Days * -1 + " días");

                    if (client.IdPersonNavigation.Avatar.Length > 0)
                    {
                        //Avatar.Image = Resources.wallet_free;
                    }
                    DGUsers.Rows.Add(null,//imagen?
                        string.Format("{0:yyyy-MM-dd}", client.IdPersonNavigation.CreatedAt),
                        client.IdPersonNavigation.FirstName + " " + client.IdPersonNavigation.LastName,
                        client.IdPersonNavigation.NumberPhone,
                        client.IdTrainingPlanNavigation.Description,
                        ColumnExpirationMsg,
                        client.IdClient,
                        client.IdPersonNavigation.Inactive);
                }
            }

            // Actualiza la vista del DataGridView.
            DGUsers.Refresh();


        }


        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            MainView.navigationControl.Display(4);
        }

        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            //validar que se seleccino un cliente
            MainView.navigationControl.Display(4);
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            // Obtén el texto actual del TextBox sin espacios al principio ni al final
            string textoBuscado = TBBusqueda.Text.Trim();



            // Comprueba si el TextBox está vacío
            if (!string.IsNullOrEmpty(textoBuscado))
            {
                LModoBusqueda.Visible = true;
                BCancelarBusqueda.Visible = true;

                // Limpia cualquier ordenación previa en el DataGridView
                DGUsers.Sort(DGUsers.Columns[0], ListSortDirection.Ascending);
                // Recorre todas las filas del DataGridView y oculta aquellas que no coincidan con el texto buscado
                foreach (DataGridViewRow row in DGUsers.Rows)
                {
                    bool coincide = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(textoBuscado, StringComparison.OrdinalIgnoreCase))
                        {
                            coincide = true;
                            break;
                        }
                    }
                    row.Visible = coincide;
                }
            }
            else
            {
                // Si el TextBox está vacío, muestra todas las filas
                foreach (DataGridViewRow row in DGUsers.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void BCancelarBusqueda_Click(object sender, EventArgs e)
        {
            LModoBusqueda.Visible = false;
            BCancelarBusqueda.Visible = false;
            TBBusqueda.Clear();

            // Limpia cualquier ordenación previa en el DataGridView
            DGUsers.Sort(DGUsers.Columns[0], ListSortDirection.Ascending);

            // Si el TextBox está vacío, muestra todas las filas
            foreach (DataGridViewRow row in DGUsers.Rows)
            {
                row.Visible = true;
            }
        }
        /***
         * Si se activa el modo delete se entiende que se eliminara un usuario
         */
        private void BEliminarCliente_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView.
            if (DGUsers.SelectedRows.Count > 0)
            {
                //Se crearan las variables
                string pregunta = "";
                bool celdaSIoNO;
                //Se procede a cetear tanto los mensajes como las busquedas que se haran
                if (this.isModeVerNoDelete)
                {
                    pregunta = "¿Desea eliminar este usuario?";
                    celdaSIoNO = false; //Si se va a eleminar a alguien, primero debe estar no eleiminado

                }
                else
                {
                    pregunta = "¿Desea activar este usuario?";
                    celdaSIoNO = true;
                }

                DialogResult resultado = MessageBox.Show(pregunta, "Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    //se guarda su indice
                    this.indexRowSelect = DGUsers.SelectedRows[0].Index;

                    // Accede a la celda "Eliminado" de la fila seleccionada y actualiza su valor
                    DGUsers.Rows[this.indexRowSelect].Cells["delete"].Value = celdaSIoNO;


                    //Se limpia el indice
                    this.indexRowSelect = 0;

                    //Se inactiva desde la base de datosa
                    foreach (TrainingPlan plan in AppState.Instructor.TrainingPlans)
                    {
                        foreach (Client cliente in plan.Clients.ToArray())
                        {

                            if (cliente.IdPersonNavigation.IdPerson == int.Parse(DGUsers.Rows[this.indexRowSelect].Cells["IdClient"].Value.ToString())
)
                            {                                    //Se inactiva el cliente de forma en memoria ram
                                cliente.IdPersonNavigation.Inactive = !this.isModeVerNoDelete;//Si esta en modo delete se desactiva, caso contrario se activa

                                //Se busca en la base de datos a la persona
                                var personUpdated = this.dbContext.People
                                .Where(people => people.IdPerson == cliente.IdPersonNavigation.IdPerson)
                                .First();

                                //this.dbContext.Entry(cliente.IdPersonNavigation).State = EntityState.Modified;

                                //Se actualiza el estado de la persona
                                personUpdated = cliente.IdPersonNavigation;

                                //Se guardan los cambios en la base de datos
                                this.dbContext.SaveChanges();

                                //Una vez se encuetra la persona, no es necesario segir buscando
                                break;
                            }


                        }


                    }



                    //Se actualiza el datagrid con el 
                    this.mostrar(this.isModeVerNoDelete);

                    //MessageBox.Show("Se elimino correctamente el Cliente.");


                    MessageBox.Show("El usuario ha sido eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    MessageBox.Show("La eliminación del usuario ha sido cancelada.", "Eliminación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }

        }





        /***
         * Esta funcion recibe como parametro a isnotDelete que se trata de que si se recibe
         * como true se entiende que se quieren mostrar solo los usuarios que no han sido eliminados
         * de lo contrario se mostraran todos los usuarios que han sido eliminados
         * **/
        private void mostrar(bool isnotDelete)
        {
            // Limpia cualquier ordenación previa en el DataGridView
            DGUsers.Sort(DGUsers.Columns[0], ListSortDirection.Ascending);

            foreach (DataGridViewRow row in DGUsers.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells["delete"].Value != null && bool.Parse(row.Cells["delete"].Value.ToString()) == true)
                    {
                        // Si la columna "Eliminado" contiene "SI", muestra la fila.
                        row.Visible = isnotDelete;
                    }
                    else
                    {
                        // Si no contiene "SI", oculta la fila.
                        row.Visible = !isnotDelete;
                    }
                }

            }

            // Actualiza la vista del DataGridView.
            DGUsers.Refresh();


        }


        private void BVerClients_Click(object sender, EventArgs e)
        {
            this.isModeVerNoDelete = true;
            BEliminarCliente.Text = "Eliminar Cliente";
            BEliminarCliente.BackColor = Color.FromArgb(192, 0, 0);
            BEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.Trash;

            this.mostrar(true);
        }

        private void BVerClientDelete_Click(object sender, EventArgs e)
        {
            this.isModeVerNoDelete = false;
            BEliminarCliente.Text = "Activar Cliente";
            BEliminarCliente.BackColor = Color.FromArgb(255, 140, 0);
            BEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.User;


            //Cargar DataGrid
            mostrar(false);
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            MainView.navigationControl.Display(7);
        }
    }
}