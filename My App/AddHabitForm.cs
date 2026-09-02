using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Habit_tracker.models;

namespace Habit_tracker
{
    public partial class AddHabitForm : Form
    {
        public AddHabitForm()
        {
            InitializeComponent();

            btnExit.Text = "<";
            btnExit.Font = new Font("Tahoma", 14, FontStyle.Bold);
            btnExit.BackColor = Color.PowderBlue;
            btnExit.ForeColor = Color.DarkGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;

        }



        private void AddHabitForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtHabit.Text.Trim();
            string time = txtTime.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("لطفاً نام عادت را وارد کنید");
                return;
            }

            Habit newHabit = new Habit(name, time);
            HabitManager.AddHabit(newHabit);

            this.Close();
        }
    }
}
