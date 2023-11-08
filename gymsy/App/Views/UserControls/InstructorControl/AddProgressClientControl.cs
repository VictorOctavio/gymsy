using CustomControls.RJControls;
using gymsy.App.Models;
using gymsy.Context;
using gymsy.utilities;
using Microsoft.Win32;
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
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

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

        private void JustNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxOnlyNumbersWithDecimal(sender, e);
        }

        private void ClearTextBox()
        {
            TbAltura.Text = "";
            TbPeso.Text = "";
            TbTitle.Text = "";
            TbNotes.Text = "";
            this.fileDialog = new OpenFileDialog();
            PictureBoxImg.Image = PictureBoxImg.InitialImage;
        }

        private void BtnAddImgProgress_Click(object sender, EventArgs e)
        {
            System.Drawing.Image File;

            fileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png; *.jfif";

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
                    TbTitle, TbAltura, TbPeso, TbNotes
                };

                // Validar texts box
                if (!ValidateTextBox(textBoxList)) return;


                // Verifica la extensión del archivo seleccionado
                string extension = System.IO.Path.GetExtension(fileDialog.FileName).ToLower();
                if (!(extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".jfif"))
                {
                    MessageBox.Show("Agrega una imagen al registro!");
                    return;
                }


                // Save image 
                System.Drawing.Image File;
                File = System.Drawing.Image.FromFile(fileDialog.FileName);

                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string directoryPublic = Path.GetFullPath(Path.Combine(directory, @"..\..\..\App\Public"));

                string RandomName = Guid.NewGuid().ToString();
                string NameImage = $"{RandomName}{extension}";
                string rutaCompleta = Path.Combine(directoryPublic, NameImage);
                File.Save(rutaCompleta, ImageFormat.Png);



                DataFisic DataFisicModel = new DataFisic();
                DataFisicModel.CreatedAt = DateTime.Now;
                DataFisicModel.IdClient = AppState.ClientActive.IdClient;
                DataFisicModel.Inactive = false;
                DataFisicModel.Title = TbTitle.Text;
                DataFisicModel.Notes = TbNotes.Text;
                DataFisicModel.Weight = float.Parse(TbPeso.Text);
                DataFisicModel.Height = float.Parse(TbAltura.Text);

                var DataFisicSave = this.gymsydb.Add(DataFisicModel);
                this.gymsydb.SaveChanges();

                if (DataFisicSave != null)
                {
                    Models.Image ImageModel = new Models.Image();
                    ImageModel.ImageUrl = NameImage;
                    ImageModel.IdDataFisic = DataFisicSave.Entity.IdDataFisic;
                    ImageModel.Inactive = false;

                    this.gymsydb.Add(ImageModel);
                    this.gymsydb.SaveChanges();


                    MessageBox.Show("Se agrego Correctamente");
                }

                
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
