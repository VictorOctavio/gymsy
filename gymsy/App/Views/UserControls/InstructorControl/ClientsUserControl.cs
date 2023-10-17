using gymsy.App.Models;
using gymsy.App.Views;
using gymsy.Context;
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
        public ClientsUserControl()
        {
            InitializeComponent();


            this.cargarPersonas();
            //Cargar DataGrid
            bool isnotDelete = true;
            this.mostrar(isnotDelete);
        }

        private void cargarPersonas()
        {
            // Limpia cualquier ordenación previa en el DataGridView
            DGUsers.Sort(DGUsers.Columns[0], ListSortDirection.Ascending);

            foreach (TrainingPlan plan in AppState.Instructor.TrainingPlans)
            {
                foreach (Client client in plan.Clients.ToArray())
                {
                    if (client.IdPersonNavigation.Inactive)
                    {
                        DGUsers.Rows.Add(client.IdPersonNavigation.Nickname, client.IdPersonNavigation.FirstName, client.IdPersonNavigation.NumberPhone, client.IdTrainingPlanNavigation.Description, client.LastExpiration, "NO");
                    
                    } else
                    {
                        DGUsers.Rows.Add(client.IdPersonNavigation.Nickname, client.IdPersonNavigation.FirstName, client.IdPersonNavigation.NumberPhone, client.IdTrainingPlanNavigation.Description, client.LastExpiration, "SI");
                    }

                    


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
            MainView.navigationControl.Display(7);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Cargar DataGrid
            mostrar(false);
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
                    if (row.Cells["delete"].Value != null && row.Cells["delete"].Value.ToString() == "SI")
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

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.mostrar(true);
        }
    }
}
