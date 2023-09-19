using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
using gymsy.Properties;
using gymsy.utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gymsy
{
    public partial class AuthView : Form, IAuthView
    {

        // Fields
        private string Message;
        private bool IsSuccessful;

        // Properties
        public string Nickname
        {
            get { return textBoxEmailUser.Text; }
            set { textBoxEmailUser.Text = value; }
        }
        public string Password
        {
            get { return textBoxPasswordUser.Text; }
            set { textBoxPasswordUser.Text = value; }
        }

        bool IAuthView.IsSuccessful
        {
            get { return IsSuccessful; }
            set { IsSuccessful = value; }
        }
        string IAuthView.Message
        {
            get { return Message; }
            set { Message = value; }
        }

        string IAuthView.textBoxEmailUser
        {
            get { return textBoxEmailUser.Text; }
            set { textBoxEmailUser.Text = value; }
        }
        string IAuthView.textBoxPasswordUser
        {
            get { return textBoxPasswordUser.Text; }
            set { textBoxPasswordUser.Text = value; }
        }

        // Constructor
        public AuthView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            button2.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonSignIn.Click += delegate
            {
                buttonSignIn.Visible = false;
                Spinner.Visible = true;

                // Reset errors
                labelErrorNickname.Visible = false;
                labelErrorPass.Visible = false;

                // Validate
                if (!this.IsValidTextBox()) return;

                // Delegamos funcionalidad signin
                Signin?.Invoke(this, EventArgs.Empty);

                buttonSignIn.Visible = true;
                Spinner.Visible = false;
            };


            textBoxPasswordUser.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!this.IsValidTextBox()) return;
                    Signin?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        // Events
        public event EventHandler Signin;

        // Methods
        private bool IsValidTextBox()
        {
            return Utility.IsValidTextBox(textBoxEmailUser, labelErrorNickname) && Utility.IsValidTextBox(textBoxPasswordUser, labelErrorPass);
        }
    }
}