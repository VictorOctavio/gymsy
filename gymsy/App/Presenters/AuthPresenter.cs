using gymsy.App.Models;
using gymsy.App.Views.Interfaces;
using gymsy.Context;
using gymsy.Properties;
using gymsy.utilities;
using gymsy.Utilities;
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

                // Signin to database
                var peopleFound = this.gymsydb.People
                                              .Where(p => p.Nickname == this.authView.Nickname)
                                              .First();

                // validar existencia del usuario
                if (peopleFound != null)
                {

                    //- Validar password
                    if (!Bcrypt.ComparePassowrd(this.authView.Password, peopleFound.Password))
                    {
                        this.authView.IsSuccessful = false;
                        this.authView.Message = "Nickname o Contraseña Incorrecto";
                        this.authView.HandleResponseDBMessage();
                        return;
                    }
                    else
                    {

                        this.authView.IsSuccessful = true;
                        this.authView.Message = "Hola, " + peopleFound.FirstName + " :)";
                        this.authView.HandleResponseDBMessage();
                        this.authView.Refresh();

                        // Delay
                        Thread.Sleep(2000);

                        // Update global state
                        AppState.person = peopleFound;

                        this.asignMethods(peopleFound);

                        //this.authView.Hide();

                        // Open form
                        IMainView view = new MainView();
                        new MainPresenter(view, this.gymsydb);

                        view.Show();

                        return;
                    }
                }
                else return;
            }
            catch (Exception ex)
            {
               this.authView.IsSuccessful = false;
               this.authView.Message = "Error inesperdado";
               this.authView.HandleResponseDBMessage();
                // Muestra un MessageBox con el mensaje de error
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.authView.Loading = false;
            }
        }


        private void asignMethods(Person personFound)
        {
            try
            {
                switch (personFound.RolId)
                {
                    // this person is admin
                    case 1:
                       
                        var instructorsFound = this.gymsydb.People
                                                .Where(person => person.RolId == 2)
                                                .ToList();

                        AppState.instructors = instructorsFound;
                        break;

                    // this person is instructor
                    case 2:

                        var instructorFound = this.gymsydb.Instructors
                                                .Where(instructor => instructor.IdPerson == personFound.IdPerson)
                                                .First();

                        var planesFound = this.gymsydb.TrainingPlans
                                                 .Where(plan => plan.IdInstructor == instructorFound.IdInstructor)
                                                 .ToList();

                        AppState.planes = planesFound;

                        break;

                    // this person is client
                    case 3:
                        // Code to execute if expression matches value1
                        break;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Algo ha salido mal :(");
            }
           
        }

    }
}