using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
using gymsy.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.App.Presenters
{
    public class MainPresenter
    {

        private IMainView mainView;
        private GymsyDbContext gymsydb;

        public MainPresenter(IMainView mainView, GymsyDbContext gymsyDb){
            
            this.mainView = mainView;
            this.gymsydb = gymsyDb;

            // subscribe

            // Show view
            this.mainView.Show();
        }


        // implements
        void SettingView ()
        {
            
        }

    }
}
