using gymsy.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.Context
{
    public static class AppState
    {
        public static Person person { get; set; }
        public static List<TrainingPlan> planes { get; set; }
        public static Array planess { get; set; }
        public static List<Person> clients { get; set; }
        public static List<Person> persons { get; set; }
        public static Person userActive { get; set; }
        public static List<Person> instructors { get; set; }

        public static List<Client> clientesDeRes { get; set; }

        // Now
        public static Instructor Instructor { get; set; }
        public static Client ClientActive { get; set; }

        public static Instructor InstructorActive { get; set; }

        public static bool isModeAdd { get; set; } = false;

       
        public static string pathDestinationFolder { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public static string nameCarpetImageClient { get; set; } = "\\Gymsy\\ClientImage";
        public static string nameCarpetImageInstructor { get; set; } = "\\Gymsy\\InstructorImage";

        public static string nameCarpetBackUp { get; set; } = "\\Gymsy\\BackUp";
        public static bool needRefreshClientsUserControl { get; set; } = false;

        public static bool isModeEdit { get; set; } = false;

        public static int auxIdClient = 0;



    }
}
