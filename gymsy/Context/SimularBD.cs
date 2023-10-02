using gymsy.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.Context
{
    internal static class SimularBD
    {
        static int idInstructor = 1;
        static int idClient = 1;
        static int idAdmin = 1;
        static int idPerson = 1;
        static int idRol = 1;
        static int idTrainingPlan = 1;
        static int idPay = 1;
        static int idWallet = 1;
        static int idDataFisic = 1;
      
       public static List<Person> persons = new List<Person>();
       public static List<Instructor> instructors = new List<Instructor>();
       public static List<Client> clients = new List<Client>();
       public static List<Admin> admins = new List<Admin>();
       public static List<Rol> roles = new List<Rol>();
       public static List<TrainingPlan> trainingPlans = new List<TrainingPlan>();
       

      public static void cargarListas()
        {
            // Creamos cinco instancias de la clase Person con todos los atributos cargados
            Person person1 = new Person
            {
                IdPerson = idPerson,
                Nickname = "user1",
                FirstName = "John",
                Avatar = "avatar1.jpg",
                Password = "password1",
                CreatedAt = DateTime.Now,
                LastName = "Doe",
                CBU = "CBU1",
                NumberPhone = "123-456-7890",
                Birthday = new DateTime(1990, 1, 1),
                Gender = "M",
                RolId = 3,
                Inactive = false
            };

            Client cliente1 = new Client { 
                IdClient = idClient,
                LastExpiration = DateTime.Now.AddMonths(1),//Se le añade un mes mas a la fecha actual
                Inactive = false,
                IdPerson = person1.IdPerson,
                IdTrainingPlan = 1,
                IdPersonNavigation = person1,
                IdTrainingPlanNavigation = trainingPlans[0]
            };



            persons.Add(person1);
            clients.Add(cliente1);
            

            Person person2 = new Person
            {
                IdPerson = idPerson++,
                Nickname = "user2",
                FirstName = "Alice",
                Avatar = "avatar2.jpg",
                Password = "password2",
                CreatedAt = DateTime.Now,
                LastName = "Smith",
                CBU = "CBU2",
                NumberPhone = "987-654-3210",
                Birthday = new DateTime(1985, 3, 15),
                Gender = "F",
                RolId = 3,
                Inactive = false
            };

            Client cliente2 = new Client
            {
                IdClient = idClient,
                LastExpiration = DateTime.Now.AddMonths(1),//Se le añade un mes mas a la fecha actual
                Inactive = false,
                IdPerson = person1.IdPerson,
                IdTrainingPlan = 1,
                IdPersonNavigation = person1,
                IdTrainingPlanNavigation = trainingPlans[0]
            };

            persons.Add(person2);
            clients.Add(cliente2);

            Person person3 = new Person
            {
                IdPerson = idPerson++,
                Nickname = "user3",
                FirstName = "Bob",
                Avatar = "avatar3.jpg",
                Password = "password3",
                CreatedAt = DateTime.Now,
                LastName = "Johnson",
                CBU = "CBU3",
                NumberPhone = "555-555-5555",
                Birthday = new DateTime(1995, 7, 10),
                Gender = "M",
                RolId = 3,
                Inactive = true
            };
            Client cliente3 = new Client
            {
                IdClient = idClient,
                LastExpiration = DateTime.Now.AddMonths(1),//Se le añade un mes mas a la fecha actual
                Inactive = false,
                IdPerson = person1.IdPerson,
                IdTrainingPlan = 1,
                IdPersonNavigation = person1,
                IdTrainingPlanNavigation = trainingPlans[0]
            };

            persons.Add(person3);
            clients.Add(cliente3);


            Person person4 = new Person
            {
                IdPerson = idPerson++,
                Nickname = "user4",
                FirstName = "Eve",
                Avatar = "avatar4.jpg",
                Password = "password4",
                CreatedAt = DateTime.Now,
                LastName = "Adams",
                CBU = "CBU4",
                NumberPhone = "111-222-3333",
                Birthday = new DateTime(1988, 5, 20),
                Gender = "F",
                RolId = 2,
                Inactive = false
            };

            persons.Add(person4);


            Person person5 = new Person
            {
                IdPerson = idPerson++,
                Nickname = "user5",
                FirstName = "Charlie",
                Avatar = "avatar5.jpg",
                Password = "password5",
                CreatedAt = DateTime.Now,
                LastName = "Brown",
                CBU = "CBU5",
                NumberPhone = "777-888-9999",
                Birthday = new DateTime(1992, 9, 5),
                Gender = "M",
                RolId = 2,
                Inactive = false
            };

            persons.Add(person5);
            

            


        }

    }
}
