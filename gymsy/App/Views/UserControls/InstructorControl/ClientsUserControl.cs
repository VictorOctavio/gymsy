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


namespace gymsy.UserControls
{
    public partial class ClientsUserControl : UserControl
    {

        private int indexRowSelect = 0;
        private List<Client> clients = new List<Client>();
        private List<TrainingPlan> planes = new List<TrainingPlan>();

        public ClientsUserControl()
        {
            InitializeComponent();

            //Cargar DataGrid
            cargarPersonas();
        }

        private void cargarPersonas()
        {

            foreach (TrainingPlan plan in AppState.Instructor.TrainingPlans.ToArray())
            {
                planes.Add(plan);

                foreach (Client client in plan.Clients.ToArray())
                {
                    clients.Add(client);

                    // Expiration 
                    TimeSpan diferencia = client.LastExpiration - DateTime.Now;

                    string ColumnExpirationMsg = diferencia.Days > 0 ?
                        ("En " + diferencia.Days + " días") : ("Hace " + diferencia.Days * -1 + " días");

                    if (client.IdPersonNavigation.Avatar.Length > 0)
                    {
                        Avatar.Image = Resources.wallet_free;
                    }

                    DGUsers.Rows.Add(
                        client.IdClient,
                        null,
                        string.Format("{0:yyyy-MM-dd}", client.IdPersonNavigation.CreatedAt),
                        client.IdPersonNavigation.FirstName + " " + client.IdPersonNavigation.LastName,
                        client.IdPersonNavigation.NumberPhone,
                        client.IdTrainingPlanNavigation.Description,
                        ColumnExpirationMsg
                        );
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

        private void BEliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar este usuario?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {



                MessageBox.Show("El usuario ha sido eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                MessageBox.Show("La eliminación del usuario ha sido cancelada.", "Eliminación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void rjButton2_Click(object sender, EventArgs e)
        {
            //Cargar DataGrid
            //cargarPersonas(SimularBD.persons, false);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Cargar DataGrid
            cargarPersonas();
        }

        private void DGUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                // Se ha hecho clic en una celda válida
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                object IdClientSelected = DGUsers.Rows[rowIndex].Cells[0].Value;

                Client clientSelected = this.clients.Find(cl => IdClientSelected.Equals(cl.IdClient));

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
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DGUsers.Cursor = Cursors.Hand;
            }
            else
            {
                DGUsers.Cursor = Cursors.Default;
            }
        }
    }
}
