using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_tracker.models
{
    public static class HabitManager
    {
        private static string filePath = "habits.txt";

        public static List<Habit> LoadHabits()
        {
            var habits = new List<Habit>();
            if (!File.Exists(filePath)) return habits;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var habit = Habit.FromString(line);
                if (habit != null)
                    habits.Add(habit);
            }
            return habits;
        }

        public static void AddHabit(Habit habit)
        {
            var line = $"{habit.Name}|{habit.Time}";
            File.AppendAllLines(filePath, new[] { line });
        }

        public static void LoadToDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var habits = LoadHabits();
            foreach (var h in habits)
            {
                dgv.Rows.Add(false, h.Name, h.Time, "انجام نشده");
            }
        }

        public static void DeleteHabit(string name, string time)
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            var newLines = lines
                .Where(line =>
                {
                    var parts = line.Split('|');
                    return !(parts.Length >= 2 && parts[0] == name && parts[1] == time);
                })
                .ToList();

            File.WriteAllLines(filePath, newLines);
        }

    }


}
