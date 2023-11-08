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
                string rutaDeCopiaDeSeguridad = AppState.pathDestinationFolder + AppState.nameCarpetBackUp;

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
    }
}
