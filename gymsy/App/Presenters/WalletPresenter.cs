using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.App.Presenters
{
    public class WalletPresenter
    {

        private IWalletView walletView;
        private GymsyDbContext gymsydb;
        //GymsyDbContext gymsyDb
        public WalletPresenter(IWalletView walletView)
        {

            this.walletView = walletView;
 //           this.gymsydb = gymsyDb;

            // subscribe

            // Show view
            this.walletView.Show();
        }



    }
}
