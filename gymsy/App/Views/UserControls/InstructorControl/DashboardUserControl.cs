using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace gymsy.UserControls
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();
            InitializeGrid();
            InitilizeChar();


        }

        public void InitilizeChar()
        {
            /*
            // Crear una nueva área de gráfico
            ChartArea area = new ChartArea();
            chartInstructor.ChartAreas.Add(area);


            // Crear una serie de datos
            Series series = chartInstructor.Series["Ganancia"];
            series.ChartType = SeriesChartType.Area;

            // Agregar datos a la serie
            series.Points.AddXY("Enero", 10);
            series.Points.AddXY("Febrero", 15);
            series.Points.AddXY("Marzo", 20);
            series.Points.AddXY("Abril", 18);
            series.Points.AddXY("Mayo", 25);
            series.Points.AddXY("Junio", 26);
            series.Points.AddXY("Julio", 27);
            series.Points.AddXY("Agosto", 28);
            series.Points.AddXY("Septiembre", 29);
            series.Points.AddXY("Octubre", 36);

            //chartInstructor.Series[1].Points.AddXY("Octubre", 36);
            // Agregar la serie al gráfico
            chartInstructor.Series.Add(series);
            */
            // Busca la serie existente por su nombre
            Series series = chartInstructor.Series.FindByName("Ganancia");

            if (series != null)
            {
                // Limpia la serie (elimina todos los puntos de datos actuales)
                series.Points.Clear();

                // Agrega los nuevos datos a la serie
                series.Points.AddXY("Enero", 10);
                series.Points.AddXY("Febrero", 15);
                series.Points.AddXY("Marzo", 20);
                series.Points.AddXY("Abril", 18);
                series.Points.AddXY("Mayo", 25);
                series.Points.AddXY("Junio", 26);
                series.Points.AddXY("Julio", 27);
                series.Points.AddXY("Agosto", 28);
                series.Points.AddXY("Septiembre", 29);
                series.Points.AddXY("Octubre", 36);

                // Puedes agregar más puntos de datos o realizar cualquier otra modificación necesaria en la serie aquí.
            }


        }
        public void InitializeGrid()
        {
            dataGridView2.Rows.Add(0, "Mauro Zarate", "22/11/2023", null);
            dataGridView2.Rows.Add(1, "Dario Benedetto", "22/11/2023", null);
            dataGridView2.Rows.Add(2, "Juan Ramirez", "22/11/2023", null);
            dataGridView2.Rows.Add(3, "Mauro Zarate", "22/11/2023", null);

            dataGridView1.Rows.Add(0, "Mauro Zarate", "22/11/2023", null);
            dataGridView1.Rows.Add(1, "Dario Benedetto", "22/11/2023", null);
            dataGridView1.Rows.Add(2, "Juan Ramirez", "22/11/2023", null);
            dataGridView1.Rows.Add(3, "Mauro Zarate", "22/11/2023", null);

        }


    }
}
