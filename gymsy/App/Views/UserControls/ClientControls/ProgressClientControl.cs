using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
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

namespace gymsy.UserControls.ClientControls
{
    public partial class ProgressClientControl : UserControl
    {

        public ProgressClientControl()
        {
            InitializeComponent();
        }

        public void updateProgressActive(DataFisic DataFisicActive)
        {
            TBRegDescription.Text = DataFisicActive.Notes;
            TBRegFecha.Text = DataFisicActive.CreatedAt.ToString("dd/MM/yyyy");
        }

        public void UpdateComponent()
        {

            int edad = DateTime.Now.Year - AppState.ClientActive.IdPersonNavigation.Birthday.Year;
            TimeSpan TimeTraning = AppState.ClientActive.IdPersonNavigation.CreatedAt - DateTime.Now;

            TBDescripcionClient.Text = $"{AppState.ClientActive.IdPersonNavigation.FirstName + " " + AppState.ClientActive.IdPersonNavigation.LastName}, " +
            $"{edad} años comenzo a enrenarse hace {TimeTraning.Days} días, " +
            $"cuenta con {AppState.ClientActive.DataFisics.Count()} registros guardados";


            if (AppState.ClientActive.DataFisics.Count() > 0)
            {
                PanelMessageCount.Visible = false;

                foreach (var DataFisic in AppState.ClientActive.DataFisics)
                {
                    TimeSpan diferencia = DateTime.Now - DataFisic.CreatedAt;
                    String formart = $"Hace {diferencia.Days} dias";
                    dataGridProgress.Rows.Add(DataFisic.IdDataFisic, formart, null, $"{DataFisic.Weight} KG", DataFisic.Title);
                }

                updateProgressActive(AppState.ClientActive.DataFisics.First());
            }
            else
            {
                PanelMessageCount.Visible = true;
            }

        }

        public override void Refresh()
        {
            if (AppState.ClientActive != null)
            {
                dataGridProgress.Rows.Clear();
                this.UpdateComponent();
            }
        }

        private void btnAddProgress_Click(object sender, EventArgs e)
        {
            MainView.navigationControl.Display(8);
        }

        private void dataGridProgress_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                // Se ha hecho clic en una celda válida
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                object IdDfSelected = dataGridProgress.Rows[rowIndex].Cells[0].Value;

                var ListDataFisics = AppState.ClientActive.DataFisics.ToList();

                DataFisic DataFisicSelected = ListDataFisics.Find(df => IdDfSelected.Equals(df.IdDataFisic));

                if (DataFisicSelected != null)
                {
                    updateProgressActive(DataFisicSelected);
                }
            }
        }
    }
}
