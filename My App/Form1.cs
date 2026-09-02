using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Habit_tracker.models;
using System.Globalization;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;



namespace Habit_tracker
{
    public partial class Form1 : Form
    {
        int percent = 0;
        int done = 0;
        private string[] tips;
        private Random rand = new Random();
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
            LoadTips();

        }

        private void LoadTips()
        {
            if (File.Exists("tips.txt"))
                tips = File.ReadAllLines("tips.txt");
            else
                tips = new[] { "نکته‌ای وجود ندارد!" };
        }
        private async Task ShowNextTip()
        {
            string tip = tips[rand.Next(tips.Length)];
            lblTip.Text = "";

            foreach (char c in tip)
            {
                lblTip.Text += c;
                await Task.Delay(50); // سرعت تایپ
            }
        }



        #region Design Function
        private void StyleGrid()
        {
            DataGridHabit.BackgroundColor = Color.White;
            DataGridHabit.BorderStyle = BorderStyle.None;
            DataGridHabit.GridColor = Color.LightGray;

            DataGridHabit.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            DataGridHabit.DefaultCellStyle.SelectionForeColor = Color.Black;

            DataGridHabit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridHabit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ارتفاع ردیف‌ها
            DataGridHabit.RowTemplate.Height = 40;
        }
        private void RoundPanel(Panel panel, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }
        #endregion

        #region taeen vazieat method
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataGridHabit.Columns[e.ColumnIndex].Name == "وضعیت" && e.Value != null)
            {
                string value = e.Value.ToString();

                if (value == "انجام نشده")
                {
                    e.CellStyle.BackColor = Color.FromArgb(220, 50, 50); // قرمز تیره
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (value == "انجام شده")
                {
                    e.CellStyle.BackColor = Color.FromArgb(80, 200, 120); // سبز روشن
                    e.CellStyle.ForeColor = Color.Black;
                }
                //DataGridHabit.ClearSelection();
            }
        }
        #endregion

        #region checkbox method

        private void DataGridHabit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool isChecked = (bool)(DataGridHabit.Rows[e.RowIndex].Cells[0].Value ?? false);

                if (isChecked)
                {
                    DataGridHabit.Rows[e.RowIndex].Cells[3].Value = "انجام شده";
                    
                }
                    
                else
                {
                    DataGridHabit.Rows[e.RowIndex].Cells[3].Value = "انجام نشده";
                    
                }

                UpdateProgress();
                DataGridHabit.Invalidate();
            }
            
        }

        #endregion

        #region Date function

        private void ShowPersianDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime now = DateTime.Now;

            int year = pc.GetYear(now);
            int month = pc.GetMonth(now);
            int day = pc.GetDayOfMonth(now);
            DayOfWeek dayOfWeek = pc.GetDayOfWeek(now);

            string[] persianDays = {
        "یکشنبه", "دوشنبه", "سه‌شنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه"
    };

            string[] persianMonths = {
        "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور",
        "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"
    };


            string persianDayName = persianDays[(int)dayOfWeek];

            string formattedDate = $"{persianDayName} {day} {persianMonths[month - 1]} {year}";
            LblDate.Text = formattedDate;
        }
        #endregion

        private void UpdateProgress()
        {
            int total = DataGridHabit.Rows.Count;
            int done = DataGridHabit.Rows.Cast<DataGridViewRow>()
                         .Count(row => row.Cells[3].Value?.ToString() == "انجام شده");

            int percent = total == 0 ? 0 : (int)((done / (double)total) * 100);
            label2.Text = percent + "%";

            // بروزرسانی نمودار  
            pieChart1.Series = new ISeries[]
            {
        new PieSeries<double> { Values = new double[] { done }, Name = " Completed", Fill = new SolidColorPaint(SKColors.Green) },
        new PieSeries<double> { Values = new double[] { total - done }, Name = " not completed", Fill = new SolidColorPaint(SKColors.Red) }
            };
        }




        private void DataGridHabit_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridHabit.IsCurrentCellDirty)
                DataGridHabit.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Jadval adat
            DataGridHabit.ColumnCount = 4;
            DataGridHabit.RowHeadersVisible = false;
            DataGridHabit.AllowUserToAddRows = false;
            DataGridHabit.AllowUserToResizeColumns = false;
            DataGridHabit.AllowUserToResizeRows = false;
            DataGridHabit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //DataGridHabit.ReadOnly = true;
            DataGridHabit.EnableHeadersVisualStyles = false;
            DataGridHabit.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            DataGridHabit.ColumnHeadersDefaultCellStyle.Font = new Font("Vazirmatn", 10, FontStyle.Bold);
            DataGridHabit.DefaultCellStyle.Font = new Font("Vazirmatn", 9);
            DataGridHabit.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridHabit.RowHeadersVisible = false;
            DataGridHabit.EnableHeadersVisualStyles = false;
            DataGridHabit.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            DataGridHabit.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;


            // ستون‌ها
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Width = 50;
            DataGridHabit.Columns.Insert(0, chk);

            DataGridHabit.Columns[1].Name = "عادت";
            DataGridHabit.Columns[2].Name = "زمان";
            DataGridHabit.Columns[3].Name = "وضعیت";


            HabitManager.LoadToDataGrid(DataGridHabit);
            StyleGrid();
            RoundPanel(PanelGrid, 40);
            RoundPanel(PanelAmar, 40);
            DataGridHabit.CellFormatting += dataGridView1_CellFormatting;

            DataGridHabit.CellValueChanged += DataGridHabit_CellValueChanged;
            DataGridHabit.CurrentCellDirtyStateChanged += DataGridHabit_CurrentCellDirtyStateChanged;
            #endregion

            #region BtnAdd

            btnAdd.Text = "+";
            btnAdd.Font = new Font("Tahoma", 18, FontStyle.Bold);
            btnAdd.Size = new Size(40, 40);
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;

            GraphicsPath circle = new GraphicsPath();
            circle.AddEllipse(0, 0, btnAdd.Width, btnAdd.Height);
            btnAdd.Region = new Region(circle);
            #endregion

            #region BtnDelete

            btnDelete.Text = "-";
            btnDelete.Font = new Font("Tahoma", 20, FontStyle.Bold);
            btnDelete.Size = new Size(40, 40);
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;

            GraphicsPath circleDel = new GraphicsPath();
            circleDel.AddEllipse(0, 0, btnDelete.Width, btnDelete.Height);
            btnDelete.Region = new Region(circleDel);

            #endregion

            #region tips

            //tips تنظیمات لیبل
            lblTip.Text = "";
            lblTip.Font = new Font("Vazirmatn", 16, FontStyle.Italic);
            lblTip.ForeColor = Color.DarkSlateGray;
            lblTip.AutoSize = false;
            lblTip.TextAlign = ContentAlignment.MiddleCenter;
            RoundPanel(panelTip, 60);

            // اجرای اولیه
            await ShowNextTip();

            // هر 7 ثانیه اجرا بشه
            
            timer.Interval = 7000; 
            timer.Tick += async (s, args) =>
            {

                await ShowNextTip();
            };
            timer.Start();

            #endregion
            
            ShowPersianDate();

            


            DataGridHabit.ClearSelection();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            AddHabitForm frm = new AddHabitForm();
            frm.ShowDialog();
            HabitManager.LoadToDataGrid(DataGridHabit);
           



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridHabit.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک عادت را برای حذف انتخاب کنید");
                return;
            }

            var row = DataGridHabit.SelectedRows[0];

            string habitName = row.Cells[1].Value?.ToString();
            string habitTime = row.Cells[2].Value?.ToString();

            HabitManager.DeleteHabit(habitName, habitTime);
            HabitManager.LoadToDataGrid(DataGridHabit);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DataGridHabit.ClearSelection();
        }
        #region mode
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            if(isDarkMode==false)
            {
                this.BackColor = Color.FromArgb(58,58,58);
                modPic.Image = Image.FromFile("images/moon.png");
            }
            else
            {
                this.BackColor = Color.LightSteelBlue;
                modPic.Image = Image.FromFile("images/sun.png");
            }
        }
        #endregion
    }
}
