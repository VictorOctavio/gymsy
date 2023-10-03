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
        public static List<Person> clients { get; set; }
        public static Person userActive { get; set; }
        public static List<Person> instructors { get; set; }

    }
}
