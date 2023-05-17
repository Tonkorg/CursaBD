namespace CursaBD
{
    partial class BaseAdmin
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
            monthCalendar1 = new MonthCalendar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Main_edit_button = new Button();
            main_number = new Label();
            main_LastName = new Label();
            Main_name = new Label();
            create_emp_button = new TabPage();
            edit_emp_button = new Button();
            create_child_button = new Button();
            CD = new DataGridView();
            NameS = new DataGridViewTextBoxColumn();
            LastNameS = new DataGridViewTextBoxColumn();
            AgeS = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Groups = new DataGridViewTextBoxColumn();
            Exp = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            AverageAge = new DataGridViewTextBoxColumn();
            CountChild = new DataGridViewTextBoxColumn();
            Voz = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            Main_edit_child_button = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            SexS = new DataGridViewTextBoxColumn();
            SensS = new DataGridViewTextBoxColumn();
            Otr = new DataGridViewTextBoxColumn();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            create_emp_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CD).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(801, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(create_emp_button);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(787, 451);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Main_edit_button);
            tabPage1.Controls.Add(main_number);
            tabPage1.Controls.Add(main_LastName);
            tabPage1.Controls.Add(Main_name);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(779, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Основная информация";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Main_edit_button
            // 
            Main_edit_button.Location = new Point(297, 385);
            Main_edit_button.Name = "Main_edit_button";
            Main_edit_button.Size = new Size(118, 23);
            Main_edit_button.TabIndex = 3;
            Main_edit_button.Text = "Редактировать профиль";
            Main_edit_button.UseVisualStyleBackColor = true;
            Main_edit_button.Click += Main_edit_button_Click;
            // 
            // main_number
            // 
            main_number.AutoSize = true;
            main_number.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            main_number.Location = new Point(9, 155);
            main_number.Name = "main_number";
            main_number.Size = new Size(158, 50);
            main_number.TabIndex = 2;
            main_number.Text = "label3";
            // 
            // main_LastName
            // 
            main_LastName.AutoSize = true;
            main_LastName.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            main_LastName.Location = new Point(9, 91);
            main_LastName.Name = "main_LastName";
            main_LastName.Size = new Size(156, 50);
            main_LastName.TabIndex = 1;
            main_LastName.Text = "label2";
            // 
            // Main_name
            // 
            Main_name.AutoSize = true;
            Main_name.BackColor = Color.Transparent;
            Main_name.BorderStyle = BorderStyle.FixedSingle;
            Main_name.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Main_name.Location = new Point(9, 28);
            Main_name.Name = "Main_name";
            Main_name.Size = new Size(246, 52);
            Main_name.TabIndex = 0;
            Main_name.Text = "main_name";
            // 
            // create_emp_button
            // 
            create_emp_button.Controls.Add(edit_emp_button);
            create_emp_button.Controls.Add(create_child_button);
            create_emp_button.Controls.Add(CD);
            create_emp_button.Location = new Point(4, 24);
            create_emp_button.Name = "create_emp_button";
            create_emp_button.Padding = new Padding(3);
            create_emp_button.Size = new Size(779, 423);
            create_emp_button.TabIndex = 1;
            create_emp_button.Text = "Информация о сотрудниках";
            create_emp_button.UseVisualStyleBackColor = true;
            // 
            // edit_emp_button
            // 
            edit_emp_button.Location = new Point(359, 372);
            edit_emp_button.Name = "edit_emp_button";
            edit_emp_button.Size = new Size(144, 23);
            edit_emp_button.TabIndex = 8;
            edit_emp_button.Text = "Редактировать";
            edit_emp_button.UseVisualStyleBackColor = true;
            edit_emp_button.Click += edit_emp_button_Click;
            // 
            // create_child_button
            // 
            create_child_button.Location = new Point(532, 372);
            create_child_button.Name = "create_child_button";
            create_child_button.Size = new Size(165, 23);
            create_child_button.TabIndex = 7;
            create_child_button.Text = "Добавить сотрудника";
            create_child_button.UseVisualStyleBackColor = true;
            create_child_button.Click += create_child_button_Click;
            // 
            // CD
            // 
            CD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CD.Columns.AddRange(new DataGridViewColumn[] { NameS, LastNameS, AgeS, PhoneNumber, Groups, Exp });
            CD.Location = new Point(3, 23);
            CD.Name = "CD";
            CD.RowTemplate.Height = 25;
            CD.Size = new Size(758, 298);
            CD.TabIndex = 6;
            CD.CellContentClick += CD_CellContentClick;
            // 
            // NameS
            // 
            NameS.HeaderText = "Имя";
            NameS.Name = "NameS";
            NameS.ReadOnly = true;
            NameS.Width = 120;
            // 
            // LastNameS
            // 
            LastNameS.HeaderText = "Фамилия";
            LastNameS.Name = "LastNameS";
            LastNameS.ReadOnly = true;
            LastNameS.Width = 120;
            // 
            // AgeS
            // 
            AgeS.DataPropertyName = "Age";
            AgeS.HeaderText = "Возраст";
            AgeS.Name = "AgeS";
            AgeS.ReadOnly = true;
            AgeS.Width = 120;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Номер телефона";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 120;
            // 
            // Groups
            // 
            Groups.HeaderText = "СПО";
            Groups.Name = "Groups";
            Groups.ReadOnly = true;
            Groups.Width = 120;
            // 
            // Exp
            // 
            Exp.HeaderText = "Опыт работы";
            Exp.Name = "Exp";
            Exp.Width = 120;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(779, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Информация о лагере";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(255, 368);
            button2.Name = "button2";
            button2.Size = new Size(165, 23);
            button2.TabIndex = 8;
            button2.Text = "Редактировать отряд";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, AverageAge, CountChild, Voz });
            dataGridView1.Location = new Point(39, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 298);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "Номер";
            Number.Name = "Number";
            // 
            // AverageAge
            // 
            AverageAge.HeaderText = "Средний возраст";
            AverageAge.Name = "AverageAge";
            // 
            // CountChild
            // 
            CountChild.HeaderText = "Количество детей";
            CountChild.Name = "CountChild";
            // 
            // Voz
            // 
            Voz.HeaderText = "Вожатые";
            Voz.Name = "Voz";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Main_edit_child_button);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(779, 423);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Информация о детях";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main_edit_child_button
            // 
            Main_edit_child_button.Location = new Point(338, 351);
            Main_edit_child_button.Name = "Main_edit_child_button";
            Main_edit_child_button.Size = new Size(197, 23);
            Main_edit_child_button.TabIndex = 11;
            Main_edit_child_button.Text = "Редактировать";
            Main_edit_child_button.UseVisualStyleBackColor = true;
            Main_edit_child_button.Click += Main_edit_child_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(541, 351);
            button1.Name = "button1";
            button1.Size = new Size(218, 23);
            button1.TabIndex = 10;
            button1.Text = "Добавить ребенка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, SexS, SensS, Otr });
            dataGridView2.Location = new Point(133, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(640, 298);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Имя";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // SexS
            // 
            SexS.HeaderText = "Пол";
            SexS.Name = "SexS";
            SexS.ReadOnly = true;
            // 
            // SensS
            // 
            SensS.HeaderText = "Аллергия";
            SensS.Name = "SensS";
            SensS.ReadOnly = true;
            // 
            // Otr
            // 
            Otr.HeaderText = "Отряд";
            Otr.Name = "Otr";
            // 
            // button4
            // 
            button4.Location = new Point(786, 523);
            button4.Name = "button4";
            button4.Size = new Size(165, 23);
            button4.TabIndex = 10;
            button4.Text = "Закрыть смену";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BaseAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 558);
            Controls.Add(button4);
            Controls.Add(monthCalendar1);
            Controls.Add(tabControl1);
            Name = "BaseAdmin";
            Text = "BaseAdmin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            create_emp_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CD).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button Main_edit_button;
        private Label main_number;
        private Label main_LastName;
        private Label Main_name;
        private TabPage create_emp_button;
        private Button edit_emp_button;
        private Button create_child_button;
        private DataGridView CD;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn NameS;
        private DataGridViewTextBoxColumn LastNameS;
        private DataGridViewTextBoxColumn AgeS;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Groups;
        private DataGridViewTextBoxColumn Exp;
        private TabPage tabPage2;
        private Button Main_edit_child_button;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn SexS;
        private DataGridViewTextBoxColumn SensS;
        private DataGridViewTextBoxColumn Otr;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn AverageAge;
        private DataGridViewTextBoxColumn CountChild;
        private DataGridViewTextBoxColumn Voz;
        private Button button2;
        private Button button4;
    }
}