using gymsy.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.App.Views.Interfaces
{
    public interface IMainView
    {
        Person person { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Methods
        void Show();
        event EventHandler FormClosed;
       
        // Navigation
        event EventHandler SettingView;
    }
}
