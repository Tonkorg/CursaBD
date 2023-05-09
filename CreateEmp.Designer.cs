namespace CursaBD
{
    partial class CreateEmp
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
            create_emp_spo_textBox = new TextBox();
            create_emp_name_textBox = new TextBox();
            create_emp_Lastname_textBox = new TextBox();
            create_emp_age_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            create_emp_clear_button = new Button();
            button2 = new Button();
            Create_emp_button = new Button();
            create_emp_exp_textBox = new TextBox();
            label5 = new Label();
            create_emp_phoneNumber_textBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // create_emp_spo_textBox
            // 
            create_emp_spo_textBox.Location = new Point(334, 181);
            create_emp_spo_textBox.Name = "create_emp_spo_textBox";
            create_emp_spo_textBox.Size = new Size(210, 23);
            create_emp_spo_textBox.TabIndex = 19;
            // 
            // create_emp_name_textBox
            // 
            create_emp_name_textBox.Location = new Point(61, 53);
            create_emp_name_textBox.Name = "create_emp_name_textBox";
            create_emp_name_textBox.Size = new Size(210, 23);
            create_emp_name_textBox.TabIndex = 15;
            // 
            // create_emp_Lastname_textBox
            // 
            create_emp_Lastname_textBox.Location = new Point(334, 53);
            create_emp_Lastname_textBox.Name = "create_emp_Lastname_textBox";
            create_emp_Lastname_textBox.Size = new Size(210, 23);
            create_emp_Lastname_textBox.TabIndex = 16;
            // 
            // create_emp_age_textBox
            // 
            create_emp_age_textBox.Location = new Point(61, 181);
            create_emp_age_textBox.Name = "create_emp_age_textBox";
            create_emp_age_textBox.Size = new Size(210, 23);
            create_emp_age_textBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 21;
            label1.Text = "Введите Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 35);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 22;
            label2.Text = "Введите Фамилию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 163);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 23;
            label3.Text = "Введите восраст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 163);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 25;
            label4.Text = "СПО";
            // 
            // create_emp_clear_button
            // 
            create_emp_clear_button.Location = new Point(444, 393);
            create_emp_clear_button.Name = "create_emp_clear_button";
            create_emp_clear_button.Size = new Size(100, 23);
            create_emp_clear_button.TabIndex = 27;
            create_emp_clear_button.Text = "Очистить";
            create_emp_clear_button.UseVisualStyleBackColor = true;
            create_emp_clear_button.Click += create_emp_clear_button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(97, 393);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 28;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += registr_back_button_Click;
            // 
            // Create_emp_button
            // 
            Create_emp_button.Location = new Point(254, 343);
            Create_emp_button.Name = "Create_emp_button";
            Create_emp_button.Size = new Size(132, 23);
            Create_emp_button.TabIndex = 29;
            Create_emp_button.Text = "Добавить сотрудника";
            Create_emp_button.UseVisualStyleBackColor = true;
            Create_emp_button.Click += Create_emp_button_Click;
            // 
            // create_emp_exp_textBox
            // 
            create_emp_exp_textBox.Location = new Point(61, 267);
            create_emp_exp_textBox.Name = "create_emp_exp_textBox";
            create_emp_exp_textBox.Size = new Size(210, 23);
            create_emp_exp_textBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 249);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 31;
            label5.Text = "Опыт работы";
            // 
            // create_emp_phoneNumber_textBox
            // 
            create_emp_phoneNumber_textBox.Location = new Point(334, 267);
            create_emp_phoneNumber_textBox.Name = "create_emp_phoneNumber_textBox";
            create_emp_phoneNumber_textBox.Size = new Size(210, 23);
            create_emp_phoneNumber_textBox.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 249);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 33;
            label6.Text = "Номер телефона";
            // 
            // CreateEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(create_emp_phoneNumber_textBox);
            Controls.Add(label6);
            Controls.Add(create_emp_exp_textBox);
            Controls.Add(label5);
            Controls.Add(create_emp_spo_textBox);
            Controls.Add(create_emp_name_textBox);
            Controls.Add(Create_emp_button);
            Controls.Add(create_emp_Lastname_textBox);
            Controls.Add(button2);
            Controls.Add(create_emp_age_textBox);
            Controls.Add(create_emp_clear_button);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "CreateEmp";
            Text = "CreateEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox create_emp_spo_textBox;
        private TextBox create_emp_name_textBox;
        private TextBox create_emp_Lastname_textBox;
        private TextBox create_emp_age_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button create_emp_clear_button;
        private Button button2;
        private Button Create_emp_button;
        private TextBox create_emp_exp_textBox;
        private Label label5;
        private TextBox create_emp_phoneNumber_textBox;
        private Label label6;
    }
}