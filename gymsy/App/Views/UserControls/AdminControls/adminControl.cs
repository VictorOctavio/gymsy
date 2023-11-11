using gymsy.App.Models;
using gymsy.Context;
using gymsy.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace gymsy.App.Views.UserControls.AdminControls
{
    public partial class adminControl : UserControl
    {
        private GymsyDbContext dbContext;
        public adminControl()
        {
            //Se trae el contexto de la base de datos
            this.dbContext = GymsyContext.GymsyContextDB;
            InitializeComponent();
        }

        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaDeCopiaDeSeguridad = "C:\\backup";

                if (!Directory.Exists(rutaDeCopiaDeSeguridad))
                {
                    Directory.CreateDirectory(rutaDeCopiaDeSeguridad);
                }

                rutaDeCopiaDeSeguridad += "\\" + $"Backup_{DateTime.Now.ToString("yyyyMMddHHmmss")}.bak";

                using (var connection = new SqlConnection(Resources.stringConnection))
                {
                    connection.Open();
                    using (var command = new SqlCommand($"BACKUP DATABASE [gymsy] TO DISK = '{rutaDeCopiaDeSeguridad}'", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Copia de seguridad creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la copia de seguridad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BRestaurarDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBRutaArchivo.Text))
            {
                MessageBox.Show("Por favor, cargue la ruta del archivo.");
            }
            else
            {
                this.RealizarRestauracion(TBRutaArchivo.Text);
            }
        }

        public void RealizarRestauracion(string backupPath)
        {
            string databaseName;
            string connectionString;

            using (var context = this.dbContext)
            {
                connectionString = Resources.stringConnection;
                databaseName = "gymsy";
            }

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlsingleuser = $"ALTER DATABASE {databaseName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using (SqlCommand singleusercommand = new SqlCommand(sqlsingleuser, connection))
                    {
                        singleusercommand.ExecuteNonQuery();
                    }
                    string sqlUseMaster = "USE master;";
                    using (SqlCommand useMasterCommand = new SqlCommand(sqlUseMaster, connection))
                    {
                        useMasterCommand.ExecuteNonQuery();
                    }
                    string sqlRestore = $"RESTORE DATABASE {databaseName} FROM DISK = '{backupPath}';";

                    using (SqlCommand restoreCommand = new SqlCommand(sqlRestore, connection))
                    {
                        restoreCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Restauración completada con éxito.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message);
            }
        }

        private void BBuscarArchivo_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos .bak|*.bak";

            // Muestra el cuadro de diálogo para seleccionar un archivo .bak
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string rutaArchivo = openFileDialog.FileName;


                    // Muestra el contenido en el TextBox
                    TBRutaArchivo.Text = rutaArchivo;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar el archivo .bak: " + ex.Message);
                }
            }
        }
    }
}
