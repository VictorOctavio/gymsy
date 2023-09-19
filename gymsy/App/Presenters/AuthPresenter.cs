using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
using gymsy.Context;
using gymsy.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.App.Presenters
{
    public class AuthPresenter
    {
        private IAuthView authView;
        private GymsyDbContext gymsydb;

        public AuthPresenter(IAuthView authView, GymsyDbContext gymsydb) {
            
            this.authView = authView;
            this.gymsydb = gymsydb;

            // Subscribe event handler methods to view events
            this.authView.Signin += Signin;

            // Show view
            this.authView.Show();
        }

        private void Signin(object? sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(this.authView.Nickname + " - " + this.gymsydb.Peoples.Count());
                
                // Signin to database
                var peopleFound = this.gymsydb.Peoples
                                              .Where(people => people.Nickname == this.authView.Nickname)
                                              .First();

                // validar existencia del usuario
                if (peopleFound != null) {

                    //- Validar clave
                    if(peopleFound.Password != this.authView.Password)
                    {
                        MessageBox.Show("Email o contraseña incorrecta");
                        this.authView.IsSuccessful = false;
                        this.authView.Message = "Error inesperdado";
                    }
                    else
                    {

                        // Open form
                        IMainView view = new MainView(peopleFound);
                        new MainPresenter(view, gymsydb);
                        view.Show();

                    }
                }

            }
            catch {
               MessageBox.Show("Email o contraseña incorrecta");
               this.authView.IsSuccessful = false;
               this.authView.Message = "Error inesperdado";
            }
        }
    }
}