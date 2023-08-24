using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectedColor;

        public NavigationButtons(List<Button> buttonsList, Color defaultColor, Color selectedColor) 
        {
            this.buttons = buttonsList;
            this.selectedColor = selectedColor;
            this.defaultColor = defaultColor;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = defaultColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if(button == selectedButton)
                {
                    button.BackColor = selectedColor;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = defaultColor;
                    button.ForeColor = Color.White;
                }
            }
        }
    }
}
