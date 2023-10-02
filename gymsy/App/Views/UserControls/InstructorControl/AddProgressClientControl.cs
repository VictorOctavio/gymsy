using CustomControls.RJControls;
using gymsy.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.App.Views.UserControls.ClientControls
{
    public partial class AddProgressClientControl : UserControl
    {
        public AddProgressClientControl()
        {
            InitializeComponent();
        }

        private void BtnAddImgProgress_Click(object sender, EventArgs e)
        {
            
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
          
            labelError.Visible = false;

            List<RJTextBox> textBoxList = new List<RJTextBox>()
            {
                TbTitle, TbAltura,TbPeso
            };

            if (!ValidateTextBox(textBoxList)) return;
          
            MessageBox.Show("Se agrego");
        }
    }
}
