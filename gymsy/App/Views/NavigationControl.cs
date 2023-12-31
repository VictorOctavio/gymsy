﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsy.App.Views
{
    public class NavigationControl
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                // set every UserControl's dock style to fill so that it will occupy the space inside the panel
                userControlList[i].Dock = DockStyle.Fill;

                // add all the UserControl inside the panel
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void Display(int index, bool refresh = false)
        {
            if (index < userControlList.Count())

                if (refresh)
                {
                    userControlList[index].Refresh();
                }

                userControlList[index].BringToFront(); // render the selected UserControl

                return;
            }
        }


    }

