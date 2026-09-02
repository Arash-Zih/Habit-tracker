namespace Habit_tracker
{
    partial class AddHabitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHabit = new TextBox();
            label3 = new Label();
            txtTime = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nazanin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(171, 27);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 0;
            label1.Text = "عادت جدید من";
            // 
            // txtHabit
            // 
            txtHabit.Location = new Point(41, 30);
            txtHabit.Multiline = true;
            txtHabit.Name = "txtHabit";
            txtHabit.Size = new Size(83, 28);
            txtHabit.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nazanin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label3.Location = new Point(141, 68);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 4;
            label3.Text = "زمان انجام این عادت";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(41, 71);
            txtTime.Multiline = true;
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(83, 28);
            txtTime.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Nazanin", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnSave.Location = new Point(164, 111);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 38);
            btnSave.TabIndex = 6;
            btnSave.Text = "ثبت عادت جدید";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Nazanin", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnExit.Location = new Point(2, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "ثبت عادت جدید";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // AddHabitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(297, 152);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtTime);
            Controls.Add(label3);
            Controls.Add(txtHabit);
            Controls.Add(label1);
            Name = "AddHabitForm";
            Text = "AddHabitForm";
            Load += AddHabitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHabit;
        private Label label3;
        private TextBox txtTime;
        private Button btnSave;
        private Button btnExit;
    }
}