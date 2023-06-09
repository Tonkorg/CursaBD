﻿namespace CursaBD
{
    partial class Base
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Main_edit_button = new Button();
            main_number = new Label();
            main_LastName = new Label();
            Main_name = new Label();
            tabPage2 = new TabPage();
            Main_edit_child_button = new Button();
            create_child_button = new Button();
            CD = new DataGridView();
            NameS = new DataGridViewTextBoxColumn();
            LastNameS = new DataGridViewTextBoxColumn();
            AgeS = new DataGridViewTextBoxColumn();
            SexS = new DataGridViewTextBoxColumn();
            SensS = new DataGridViewTextBoxColumn();
            childBindingSource = new BindingSource(components);
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(787, 451);
            tabControl1.TabIndex = 3;
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
            main_number.Location = new Point(6, 152);
            main_number.Name = "main_number";
            main_number.Size = new Size(158, 50);
            main_number.TabIndex = 2;
            main_number.Text = "label3";
            // 
            // main_LastName
            // 
            main_LastName.AutoSize = true;
            main_LastName.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            main_LastName.Location = new Point(6, 88);
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
            Main_name.Location = new Point(6, 25);
            Main_name.Name = "Main_name";
            Main_name.Size = new Size(246, 52);
            Main_name.TabIndex = 0;
            Main_name.Text = "main_name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Main_edit_child_button);
            tabPage2.Controls.Add(create_child_button);
            tabPage2.Controls.Add(CD);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(779, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Информация о детях";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main_edit_child_button
            // 
            Main_edit_child_button.Location = new Point(359, 372);
            Main_edit_child_button.Name = "Main_edit_child_button";
            Main_edit_child_button.Size = new Size(144, 23);
            Main_edit_child_button.TabIndex = 8;
            Main_edit_child_button.Text = "Редактировать";
            Main_edit_child_button.UseVisualStyleBackColor = true;
            Main_edit_child_button.Click += Edit_child_Click;
            // 
            // create_child_button
            // 
            create_child_button.Location = new Point(532, 372);
            create_child_button.Name = "create_child_button";
            create_child_button.Size = new Size(165, 23);
            create_child_button.TabIndex = 7;
            create_child_button.Text = "Добавить ребенка";
            create_child_button.UseVisualStyleBackColor = true;
            create_child_button.Click += button1_Click;
            // 
            // CD
            // 
            CD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CD.Columns.AddRange(new DataGridViewColumn[] { NameS, LastNameS, AgeS, SexS, SensS });
            CD.Location = new Point(199, 27);
            CD.Name = "CD";
            CD.RowTemplate.Height = 25;
            CD.Size = new Size(542, 298);
            CD.TabIndex = 6;
            CD.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameS
            // 
            NameS.HeaderText = "Имя";
            NameS.Name = "NameS";
            NameS.ReadOnly = true;
            // 
            // LastNameS
            // 
            LastNameS.HeaderText = "Фамилия";
            LastNameS.Name = "LastNameS";
            LastNameS.ReadOnly = true;
            // 
            // AgeS
            // 
            AgeS.DataPropertyName = "Age";
            AgeS.HeaderText = "Возраст";
            AgeS.Name = "AgeS";
            AgeS.ReadOnly = true;
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
            // childBindingSource
            // 
            childBindingSource.DataSource = typeof(Child);
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(791, 2);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(694, 501);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 5;
            button1.Text = "Заказать путевку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 563);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(tabControl1);
            Name = "Base";
            Text = "Основная страница";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CD).EndInit();
            ((System.ComponentModel.ISupportInitialize)childBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label main_number;
        private Label main_LastName;
        private Label Main_name;
        private TabPage tabPage2;
        private MonthCalendar monthCalendar1;
        private Button Main_edit_button;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView CD;
        private BindingSource childBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sensDataGridViewTextBoxColumn;
        private Button create_child_button;
        private Button Main_edit_child_button;
        private DataGridViewTextBoxColumn NameS;
        private DataGridViewTextBoxColumn LastNameS;
        private DataGridViewTextBoxColumn AgeS;
        private DataGridViewTextBoxColumn SexS;
        private DataGridViewTextBoxColumn SensS;
        private Button button1;
    }
}