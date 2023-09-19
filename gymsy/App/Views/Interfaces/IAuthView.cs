using System;
using System.Collections.Generic;
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

        string textBoxEmailUser { get; set; }
        string textBoxPasswordUser { get; set; }

        // Events
        event EventHandler Signin;

        // Methods
        void Show();
    }
}
