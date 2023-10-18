using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace gymsy.UserControls.AdminControls
{
    public partial class DashboardAdminControl : UserControl
    {
        public DashboardAdminControl()
        {
            InitializeComponent();

            InitilizeChar();
            InitilizeCharPie();
        }

        public void InitilizeChar()
        {
            Series series = chartGanancia.Series.FindByName("Ganancia");

            if (series != null)
            {
                // Limpia la serie (elimina todos los puntos de datos actuales)
                series.Points.Clear();

                // Agrega los nuevos datos a la serie
                series.Points.AddXY("Enero", 10000);
                series.Points.AddXY("Febrero", 15000);
                series.Points.AddXY("Marzo", 20000);
                series.Points.AddXY("Abril", 18000);
                series.Points.AddXY("Mayo", 25000);
                series.Points.AddXY("Junio", 26000);
                series.Points.AddXY("Julio", 27000);
                series.Points.AddXY("Agosto", 28000);
                series.Points.AddXY("Septiembre", 29000);
                series.Points.AddXY("Octubre", 36000);

                // Puedes agregar más puntos de datos o realizar cualquier otra modificación necesaria en la serie aquí.
            }


        }
        public void InitilizeCharPie()
        {
            Series series = chartInstructorXClientes.Series.FindByName("Series1");

            if (series != null)
            {
                // Limpia la serie (elimina todos los puntos de datos actuales)
                series.Points.Clear();

                // Agrega los nuevos datos a la serie
                series.Points.AddXY("Instructor A", 10);
                series.Points.AddXY("Instructor B", 15);
                series.Points.AddXY("Instructor C", 8);
                series.Points.AddXY("Instructor D", 12);

                // Puedes agregar más puntos de datos o realizar cualquier otra modificación necesaria en la serie aquí.
            }

        }
    }
}
