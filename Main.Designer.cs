namespace CursaBD
{
    partial class Main
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Main_edit_button = new Button();
            main_number = new Label();
            main_LastName = new Label();
            Main_name = new Label();
            tabPage2 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
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
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(779, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Информация о детях";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 30);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 107);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(779, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Информация о лагере";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(791, 2);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 563);
            Controls.Add(monthCalendar1);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "Main";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label main_number;
        private Label main_LastName;
        private Label Main_name;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MonthCalendar monthCalendar1;
        private Button Main_edit_button;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}