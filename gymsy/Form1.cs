using gymsy.UserControls;

namespace gymsy
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        bool sidebarExpand;
        bool btnAddExpand;

        // Set colors buttons
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedColor = Color.DarkCyan;

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new DashboardUserControl(), new ClientsUserControl(), new PaymentsUserControl(), new SettingsUserControl(),
              new AddClientUserControl(), new AddPlanUserControl()
            };

            navigationControl = new NavigationControl(userControls, mainWrapper);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnNavDashboard, btnNavPayments, btnNavClients, btnNavAddClient, btnNavAddPlan};

            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedColor);
            navigationButtons.Highlight(btnNavDashboard);
        }


        // Navigation BTNS
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(btnNavDashboard);
        }

        private void btnNavClients_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(btnNavClients);
        }

        private void btnNavPayments_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(btnNavPayments);
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(btnNavSettings);
        }

        private void btnNavAddPlan_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
            navigationButtons.Highlight(btnNavAddPlan);
        }

        private void btnNavAddClient_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(btnNavAddClient);
        }




        // TIMERS
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAddTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnAddTimer_Tick(object sender, EventArgs e)
        {
            if (btnAddExpand)
            {
                panelBtnAdd.Height -= 10;
                if (panelBtnAdd.Height == panelBtnAdd.MinimumSize.Height)
                {
                    btnAddExpand = false;
                    btnAddTimer.Stop();
                }
            }
            else
            {
                panelBtnAdd.Height += 10;
                if (panelBtnAdd.Height == panelBtnAdd.MaximumSize.Height)
                {
                    btnAddExpand = true;
                    btnAddTimer.Stop();
                }
            }
        }


        // SIGNOUT SESSION BTN
        private void btnNavSignout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}