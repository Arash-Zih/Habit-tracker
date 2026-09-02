namespace Habit_tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LblHeader = new Label();
            LblDate = new Label();
            pictureBox1 = new PictureBox();
            modPic = new PictureBox();
            DataGridHabit = new DataGridView();
            PanelGrid = new Panel();
            PanelAmar = new Panel();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            panelTip = new Panel();
            lblTip = new Label();
            timer = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridHabit).BeginInit();
            PanelGrid.SuspendLayout();
            PanelAmar.SuspendLayout();
            panelTip.SuspendLayout();
            SuspendLayout();
            // 
            // LblHeader
            // 
            LblHeader.AutoSize = true;
            LblHeader.Font = new Font("Vazirmatn", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblHeader.Location = new Point(386, 9);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(203, 46);
            LblHeader.TabIndex = 0;
            LblHeader.Text = "لیست فعالیت ها";
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDate.ForeColor = Color.Green;
            LblDate.Location = new Point(402, 50);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(44, 21);
            LblDate.TabIndex = 1;
            LblDate.Text = "date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.searchIcon;
            pictureBox1.Location = new Point(848, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // modPic
            // 
            modPic.Image = Properties.Resources.sun;
            modPic.Location = new Point(798, 22);
            modPic.Name = "modPic";
            modPic.Size = new Size(32, 32);
            modPic.SizeMode = PictureBoxSizeMode.StretchImage;
            modPic.TabIndex = 3;
            modPic.TabStop = false;
            modPic.Click += pictureBox2_Click;
            // 
            // DataGridHabit
            // 
            DataGridHabit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridHabit.Dock = DockStyle.Fill;
            DataGridHabit.Location = new Point(0, 0);
            DataGridHabit.Name = "DataGridHabit";
            DataGridHabit.Size = new Size(560, 384);
            DataGridHabit.TabIndex = 4;
            // 
            // PanelGrid
            // 
            PanelGrid.Controls.Add(DataGridHabit);
            PanelGrid.Location = new Point(24, 90);
            PanelGrid.Name = "PanelGrid";
            PanelGrid.Size = new Size(560, 384);
            PanelGrid.TabIndex = 5;
            // 
            // PanelAmar
            // 
            PanelAmar.BackColor = SystemColors.Control;
            PanelAmar.Controls.Add(pieChart1);
            PanelAmar.Controls.Add(label3);
            PanelAmar.Controls.Add(label2);
            PanelAmar.Controls.Add(label1);
            PanelAmar.Location = new Point(641, 95);
            PanelAmar.Name = "PanelAmar";
            PanelAmar.Size = new Size(237, 379);
            PanelAmar.TabIndex = 6;
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.Transparent;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(39, 168);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(150, 150);
            pieChart1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 107);
            label3.Name = "label3";
            label3.Size = new Size(168, 27);
            label3.TabIndex = 9;
            label3.Text = ".کار های امروز انجام شده";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vazirmatn", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 54);
            label2.TabIndex = 8;
            label2.Text = "0%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vazirmatn", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 36);
            label1.TabIndex = 7;
            label1.Text = "آمار";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 68);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(95, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 68);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelTip
            // 
            panelTip.BackColor = Color.MistyRose;
            panelTip.Controls.Add(lblTip);
            panelTip.Location = new Point(24, 501);
            panelTip.Name = "panelTip";
            panelTip.Size = new Size(854, 102);
            panelTip.TabIndex = 9;
            // 
            // lblTip
            // 
            lblTip.Location = new Point(18, 11);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(823, 77);
            lblTip.TabIndex = 0;
            lblTip.Text = "lb";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(901, 615);
            Controls.Add(panelTip);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(PanelAmar);
            Controls.Add(PanelGrid);
            Controls.Add(modPic);
            Controls.Add(pictureBox1);
            Controls.Add(LblDate);
            Controls.Add(LblHeader);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridHabit).EndInit();
            PanelGrid.ResumeLayout(false);
            PanelAmar.ResumeLayout(false);
            PanelAmar.PerformLayout();
            panelTip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblHeader;
        private Label LblDate;
        private PictureBox pictureBox1;
        private PictureBox modPic;
        private DataGridView DataGridHabit;
        private Panel PanelGrid;
        private Panel PanelAmar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Panel panelTip;
        private Label lblTip;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
