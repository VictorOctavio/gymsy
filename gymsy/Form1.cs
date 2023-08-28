using gymsy.UserControls;

namespace gymsy
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        bool sidebarExpand = true;
        bool btnAddExpand = false;
        bool btnNotificationsExpand = false;

        // Set colors buttons
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedColor = Color.DarkCyan;

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        // Inicializamos el controlador con la navegacion, pasando los controles y en panel mainWrapper en donde se renderizará
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new DashboardUserControl(), new ClientsUserControl(), new PaymentsUserControl(), new SettingsUserControl(),
              new AddClientUserControl(), new AddPlanUserControl()
            };

            navigationControl = new NavigationControl(userControls, mainWrapper);
            navigationControl.Display(0);
        }

        // Inicializamos los botones asociados a la navegacion y manejamos el btn activo (HIghlight)
        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnNavDashboard, btnNavPayments, btnNavClients, btnNavAddClient, btnNavAddPlan};

            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedColor);
            navigationButtons.Highlight(btnNavDashboard);
        }


        // Handle BTN Navegatios
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




        // START TIMERS
        private void menuButton_Click(object sender, EventArgs e) // Timer despligue panel 
        {
            sidebarTimer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e) // Timer dropdown btn add
        {
            btnAddTimer.Start();
        }
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            timerNavbarNotifications.Start();
        }

        // Control timer for panel
        private void timer1_Tick(object sender, EventArgs e)
        {
            // asignamos que el sidebar ocupe la menor anchura y modificamos el padding del main
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    mainWrapper.Padding = new Padding(70, 0, 0, 0);
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            // asignamos que el sidebar ocupe la mayor anchura y modificamos el padding del main
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    mainWrapper.Padding = new Padding(260, 0, 0, 0);
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        // Control timer for dropdown btn add
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

        // Control timer for dropdown  notifications
        private void timerNavbarNotifications_Tick(object sender, EventArgs e)
        {
            if (btnNotificationsExpand)
            {
                panelNotifications.BorderStyle = BorderStyle.None;
                panelNotifications.Height -= 10;
                if (panelNotifications.Height == panelNotifications.MinimumSize.Height)
                {
                    btnNotificationsExpand = false;
                    timerNavbarNotifications.Stop();
                }
            }
            else
            {
                panelNotifications.BorderStyle = BorderStyle.FixedSingle;
                panelNotifications.Height += 10;
                if (panelNotifications.Height == panelNotifications.MaximumSize.Height)
                {
                    btnNotificationsExpand = true;
                    timerNavbarNotifications.Stop();
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