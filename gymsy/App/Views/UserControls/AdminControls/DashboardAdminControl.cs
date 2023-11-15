using gymsy.App.Models;
using gymsy.Context;
using Microsoft.EntityFrameworkCore;
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

        private GymsyDbContext dbContext;

        public DashboardAdminControl()
        {
            this.dbContext = GymsyContext.GymsyContextDB;
            InitializeComponent();
            InitilizeChar();
            InitilizeCharPie();
            InitializeDataGridPays();
        }

        private void InitializeDataGridPays()
        {

            var ultimosPagos = this.dbContext.Pays
            .OrderByDescending(p => p.CreatedAt)
            .Take(5) // Puedes ajustar la cantidad de pagos que deseas obtener
            .Include(p => p.Remitente)
            .ToList();

            DataGridViewRow row = this.DataGridPays.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;

            foreach (Pay pay in ultimosPagos)
            {
                DataGridPays.Rows.Add(
                    pay.IdPay,
                    pay.CreatedAt,
                    $"$ {pay.Amount}",
                    $"{pay.Remitente.LastName}, {pay.Remitente.FirstName}"
                );
            }
        }

        public void InitilizeChar()
        {
            Series series = ChartAdmin.Series.FindByName("Ganancia");

            if (series != null)
            {
                // Limpia la serie (elimina todos los puntos de datos actuales)
                series.Points.Clear();
                series.LegendText = "Ganacia por Mes";
                series.BorderColor = Color.DarkOrange;
                series.BorderWidth = 3;
                series.BackSecondaryColor = Color.White;
                series.BorderDashStyle = ChartDashStyle.Solid; // punteado o solido ...
                series.Color = Color.Transparent;

                List<string> listMonths = new List<string>
                {
                    "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nob", "Dec"
                };

                var resultado = dbContext.Pays
                 .GroupBy(p => new { Mes = p.CreatedAt.Month, Anio = p.CreatedAt.Year })
                 .Select(g => new
                 {
                     Mes = g.Key.Mes,
                     Anio = g.Key.Anio,
                     SumaPagos = g.Sum(p => p.Amount)
                 })
                 .Select(item => new
                 {
                     Mes = item.Mes,
                     Amount = item.SumaPagos
                 })
                 .ToArray();

                // Crear un arreglo con todos los meses del año y establecer el monto en 0 para aquellos meses sin pagos
                var mesesCompletos = Enumerable.Range(1, 12)
                    .Select(mes => resultado.FirstOrDefault(r => r.Mes == mes) ?? new { Mes = mes, Amount = 0.0 })
                    .ToArray();

                // Trabaja con 'resultado' según sea necesario
                foreach (var data in mesesCompletos)
                {
                    series.Points.AddXY(listMonths[data.Mes - 1], data.Amount);
                    series.LegendToolTip = $"Ganancia obtenida por mes";
                }
            }
        }

        public void InitilizeCharPie()
        {
            Series series = chartInstructorXClientes.Series.FindByName("Series1");

            if (series != null)
            {
                // Limpia la serie (elimina todos los puntos de datos actuales)
                series.Points.Clear();
                series.LabelForeColor = Color.White;
                series.LabelBackColor = Color.Transparent;
                series.BorderColor = Color.White;
                series.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                series.MarkerStyle = MarkerStyle.Cross;

                var resultado = dbContext.Instructors
                    .Select(instructor => new
                    {
                        Instructor = instructor,
                        CantidadClientes = instructor.TrainingPlans.SelectMany(plan => plan.Clients).Count()
                    })
                    .ToList();

                // Agrega los nuevos datos a la serie
                foreach (var data in resultado)
                {
                    if(data.CantidadClientes > 0)
                    {
                        series.Points.AddXY($"{data.Instructor.IdPersonNavigation.FirstName} - {data.CantidadClientes} Clientes.", data.CantidadClientes);
                        series.LegendToolTip = $"{data.Instructor.IdPersonNavigation.LastName}, {data.Instructor.IdPersonNavigation.FirstName} - {data.CantidadClientes} Clientes.";

                    }
                }
            }

        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                chartInstructorXClientes.SaveImage(Path.Combine(downloadsFolder, "grafico_torta_admin.png"), ChartImageFormat.Png); ;
                ChartAdmin.SaveImage(Path.Combine(downloadsFolder, "grafico_fun_admin.png"), ChartImageFormat.Png);

                // Crear el contenido HTML
                string htmlContent = $@"
                <html>
                <head>
                    <title>Gráfico GYMSY</title>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            height: 95vh;
                            display: flex;
                            justify-content: center;
                            align-items: center;
                            background-image: linear-gradient(to right, #6a11cb 0%, #2575fc 100%);
                        }}

                        h3{{    
                            text-align: center:
                            color: white;
                        }}

                        .graficos {{
                            width: 80%;
                            margin: 0 auto;
                            padding: 30px;
                            border-radius: 5px;
                            background-color: rgb(255, 255, 255, .15);
                            box-shadow: 2px 1px 34px 2px rgba(255,255,255,0.5);
                            display: grid;
                            grid-template-columns: repeat(2, 1fr);
                            grid-template-rows: auto;
                            grid-gap: 20px;
        
                        }}
                        
                        .graficoFun{{
                            grid-column: 1 / 3;

                        }}

                        .ImgGraficoFun{{
                            width: 100%;
                            max-height: 400px;
                            object-fit: contain;
                        }}

                        .graficoTorta{{
                            border: 1px solid #ccc;
                            padding: 15px;
                        }}

                        .listClients{{
                            border: 1px solid #ccc;
                            padding: 15px;
                        }}
                    </style>
                </head>
                <body>
                    
                    
                    <div class='graficos'>
                       
                         <div class='graficoFun'>
                            <h2 style='color:white; text-align:center'>Cantidad de clientes por mes</h2>
                            <img class='ImgGraficoFun' src='grafico_fun_admin.png' alt='Gráfico'>
                        </div>

                         <div  class='graficoTorta'>
                            <h2 style='color:white; text-align:center'>Clientes por Instructor</h2>
                            <img src='grafico_torta_admin.png' alt='Gráfico'>
                        </div>

                        <div class='listClients'>
                            <h2 style='color:white; text-align:center'>Grafico ...</h2>
                            <-
                        </div>
                    </div>
                   
                </body>
                </html>";

                string htmlFilePath = Path.Combine(downloadsFolder, "grafico.html");

                // Guardar el contenido HTML en un archivo
                System.IO.File.WriteAllText(htmlFilePath, htmlContent);

                MessageBox.Show("Se ha generado un HTML en Documentos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

