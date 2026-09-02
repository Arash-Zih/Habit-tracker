using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_tracker.models
{
    public class Habit
    {
        public string Name { get; set; }
        public string Time { get; set; }

        public Habit(string name, string time)
        {
            Name = name;
            Time = time;
        }

        public static Habit FromString(string line)
        {
            var parts = line.Split('|');
            if (parts.Length != 2) return null;

            string name = parts[0];
            string time = parts[1];

            return new Habit(name, time);
        }
    }
}

