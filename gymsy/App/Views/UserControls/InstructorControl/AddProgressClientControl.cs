using CustomControls.RJControls;
using gymsy.App.Models;
using gymsy.Context;
using gymsy.utilities;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace gymsy.App.Views.UserControls.ClientControls
{
    public partial class AddProgressClientControl : UserControl
    {

        private GymsyDbContext gymsydb = GymsyContext.GymsyContextDB;
        private OpenFileDialog fileDialog = new OpenFileDialog();
        public AddProgressClientControl()
        {
            InitializeComponent();
        }

        private void ClearTextBox ()
        {
            TbAltura.Text = "";
            TbPeso.Text = "";
            TbTitle.Text = "";
            TbNotes.Text = "";
        }

        private void BtnAddImgProgress_Click(object sender, EventArgs e)
        {
            System.Drawing.Image File;
   
            fileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File = System.Drawing.Image.FromFile(fileDialog.FileName);
                PictureBoxImg.Image = File;

            }
        }


        private bool ValidateTextBox(List<RJTextBox> textBoxList)
        {
            foreach (RJTextBox textBoxCurrent in textBoxList)
            {
                if (!Utility.IsValidTextBoxRJ(textBoxCurrent, labelError))
                {
                    return false;
                }
            }
            return true;
        }

        private void BtnSaveProgress_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Visible = false;

                List<RJTextBox> textBoxList = new List<RJTextBox>()
                {
                    TbTitle, TbAltura, TbPeso
                };

                if (!ValidateTextBox(textBoxList)) return;

                DataFisic DataFisicModel = new DataFisic();

                DataFisicModel.CreatedAt = DateTime.Now;
                DataFisicModel.IdClient = AppState.ClientActive.IdClient;
                DataFisicModel.Inactive = false;
                DataFisicModel.Title = TbTitle.Text;
                DataFisicModel.Notes = TbNotes.Text;
                DataFisicModel.Weight = float.Parse(TbPeso.Text);
                DataFisicModel.Height = float.Parse(TbAltura.Text);


                this.gymsydb.Add(DataFisicModel);
                this.gymsydb.SaveChanges();

                MessageBox.Show("Se agrego Correctamente");
                this.ClearTextBox();
                MainView.navigationControl.Display(7, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
