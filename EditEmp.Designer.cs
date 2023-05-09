namespace CursaBD
{
    partial class EditEmp
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
            button1 = new Button();
            edit_emp_name_textBox = new TextBox();
            edit_emp_Lastname_textBox = new TextBox();
            edit_emp_age_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            edit_emp_phoneNumber_textBox = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            edit_emp_SPO_textBox = new TextBox();
            exp_label = new Label();
            edit_emp_exp_textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(321, 169);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 38;
            button1.Text = "Очистить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // edit_emp_name_textBox
            // 
            edit_emp_name_textBox.Location = new Point(36, 40);
            edit_emp_name_textBox.Name = "edit_emp_name_textBox";
            edit_emp_name_textBox.Size = new Size(210, 23);
            edit_emp_name_textBox.TabIndex = 28;
            edit_emp_name_textBox.Click += edit_emp_name_textBox_TextChanged;
            // 
            // edit_emp_Lastname_textBox
            // 
            edit_emp_Lastname_textBox.Location = new Point(36, 121);
            edit_emp_Lastname_textBox.Name = "edit_emp_Lastname_textBox";
            edit_emp_Lastname_textBox.Size = new Size(210, 23);
            edit_emp_Lastname_textBox.TabIndex = 29;
            edit_emp_Lastname_textBox.Click += edit_emp_Lastname_textBox_TextChanged;
            // 
            // edit_emp_age_textBox
            // 
            edit_emp_age_textBox.Location = new Point(36, 205);
            edit_emp_age_textBox.Name = "edit_emp_age_textBox";
            edit_emp_age_textBox.Size = new Size(210, 23);
            edit_emp_age_textBox.TabIndex = 30;
            edit_emp_age_textBox.Click += edit_emp_age_textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 31;
            label1.Text = "Введите Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 103);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 32;
            label2.Text = "Введите Фамилию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 177);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 33;
            label3.Text = "Введите возраст";
            // 
            // edit_emp_phoneNumber_textBox
            // 
            edit_emp_phoneNumber_textBox.Location = new Point(36, 275);
            edit_emp_phoneNumber_textBox.Name = "edit_emp_phoneNumber_textBox";
            edit_emp_phoneNumber_textBox.Size = new Size(210, 23);
            edit_emp_phoneNumber_textBox.TabIndex = 34;
            edit_emp_phoneNumber_textBox.Click += edit_emp_phoneNumber_textBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 257);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 36;
            label4.Text = "Номер телефона";
            // 
            // button2
            // 
            button2.Location = new Point(321, 223);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 39;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += registr_back_button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(321, 95);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 40;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 324);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 42;
            label5.Text = "СПО";
            // 
            // edit_emp_SPO_textBox
            // 
            edit_emp_SPO_textBox.Location = new Point(36, 342);
            edit_emp_SPO_textBox.Name = "edit_emp_SPO_textBox";
            edit_emp_SPO_textBox.Size = new Size(210, 23);
            edit_emp_SPO_textBox.TabIndex = 41;
            edit_emp_SPO_textBox.Click += edit_emp_SPO_textBox_TextChanged;
            // 
            // exp_label
            // 
            exp_label.AutoSize = true;
            exp_label.Location = new Point(118, 389);
            exp_label.Name = "exp_label";
            exp_label.Size = new Size(37, 15);
            exp_label.TabIndex = 44;
            exp_label.Text = "Опыт";
            // 
            // edit_emp_exp_textBox
            // 
            edit_emp_exp_textBox.Location = new Point(36, 407);
            edit_emp_exp_textBox.Name = "edit_emp_exp_textBox";
            edit_emp_exp_textBox.Size = new Size(210, 23);
            edit_emp_exp_textBox.TabIndex = 43;
            // 
            // EditEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(exp_label);
            Controls.Add(edit_emp_exp_textBox);
            Controls.Add(label5);
            Controls.Add(edit_emp_SPO_textBox);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(edit_emp_name_textBox);
            Controls.Add(edit_emp_Lastname_textBox);
            Controls.Add(label4);
            Controls.Add(edit_emp_age_textBox);
            Controls.Add(edit_emp_phoneNumber_textBox);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditEmp";
            Text = "EditEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox edit_emp_name_textBox;
        private TextBox edit_emp_Lastname_textBox;
        private TextBox edit_emp_age_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox edit_emp_phoneNumber_textBox;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox edit_emp_SPO_textBox;
        private Label exp_label;
        private TextBox edit_emp_exp_textBox;
    }
}