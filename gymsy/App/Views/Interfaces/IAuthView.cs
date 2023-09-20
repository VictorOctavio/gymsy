using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.App.Views.Interfaces
{
    public interface IAuthView
    {
        // Properties
        string Nickname { get; set; }
        string Password { get; set; }

        bool IsSuccessful { get; set; }
        string Message { get; set; }
        bool Loading { get; set; }

        // Events
        event EventHandler Signin;
  
        // Methods
        void Show();
        void Close();
        void Hide();
        void Refresh();
        void HandleResponseDBMessage();
    }
}
