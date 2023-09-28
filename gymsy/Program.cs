using gymsy.App.Models;
using gymsy.App.Presenters;
using gymsy.App.Views.Interfaces;
using gymsy.Context;
using gymsy.Properties;
using Microsoft.EntityFrameworkCore;

namespace gymsy
{
    internal static class Program
    {
        /// <summary>
        /// [STAThread]
        /// Es en los system dialogs si no lanzaran exepciones
        /// </summary>
        [STAThread]
        static void Main()
        {


             //Config & Conect to database
            string stringConnection = Resources.stringConnection;
            DbContextOptionsBuilder<GymsyDbContext> optionsBuilder = new();

            GymsyDbContext GymsyContextDb = new(
               optionsBuilder.UseSqlServer(stringConnection).Options
            );

            GymsyContext.GymsyContextDB = GymsyContextDb!;
            ApplicationConfiguration.Initialize();

            IAuthView view = new AuthView();
            new AuthPresenter(view, GymsyContextDb);
          
            Application.Run((Form)view);
        }
    }
}