namespace CursaBD
{
    partial class UserEdit
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
            label3 = new Label();
            label1 = new Label();
            registr_name = new Label();
            edit_phoneNumber_textBox = new TextBox();
            edit_lastName_textBox = new TextBox();
            edit_name_textBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            edit_new_password_textBox = new TextBox();
            edit_old_password_textBox = new TextBox();
            registr_regist_button = new Button();
            registr_back_button = new Button();
            registr_clear_button = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 102);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 17;
            label3.Text = "Введите номер телефона";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 16;
            label1.Text = "Введите Фамилию";
            // 
            // registr_name
            // 
            registr_name.AutoSize = true;
            registr_name.Location = new Point(83, 22);
            registr_name.Name = "registr_name";
            registr_name.Size = new Size(77, 15);
            registr_name.TabIndex = 15;
            registr_name.Text = "Введите Имя";
            // 
            // edit_phoneNumber_textBox
            // 
            edit_phoneNumber_textBox.Location = new Point(173, 120);
            edit_phoneNumber_textBox.Name = "edit_phoneNumber_textBox";
            edit_phoneNumber_textBox.Size = new Size(210, 23);
            edit_phoneNumber_textBox.TabIndex = 13;
            edit_phoneNumber_textBox.Click += edit_phoneNumber_textBox_TextChanged;
            // 
            // edit_lastName_textBox
            // 
            edit_lastName_textBox.Location = new Point(304, 40);
            edit_lastName_textBox.Name = "edit_lastName_textBox";
            edit_lastName_textBox.Size = new Size(210, 23);
            edit_lastName_textBox.TabIndex = 12;
            edit_lastName_textBox.Click += edit_lastName_textBox_TextChanged;
            // 
            // edit_name_textBox
            // 
            edit_name_textBox.Location = new Point(27, 40);
            edit_name_textBox.Name = "edit_name_textBox";
            edit_name_textBox.Size = new Size(210, 23);
            edit_name_textBox.TabIndex = 11;
            edit_name_textBox.Click += edit_name_textBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 247);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 22;
            label5.Text = "Введите новый пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 247);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 21;
            label2.Text = "Введите старый пароль";
            // 
            // edit_new_password_textBox
            // 
            edit_new_password_textBox.Location = new Point(344, 265);
            edit_new_password_textBox.Name = "edit_new_password_textBox";
            edit_new_password_textBox.Size = new Size(210, 23);
            edit_new_password_textBox.TabIndex = 20;
            // 
            // edit_old_password_textBox
            // 
            edit_old_password_textBox.Location = new Point(27, 265);
            edit_old_password_textBox.Name = "edit_old_password_textBox";
            edit_old_password_textBox.Size = new Size(210, 23);
            edit_old_password_textBox.TabIndex = 19;
            // 
            // registr_regist_button
            // 
            registr_regist_button.Location = new Point(105, 346);
            registr_regist_button.Name = "registr_regist_button";
            registr_regist_button.Size = new Size(132, 23);
            registr_regist_button.TabIndex = 25;
            registr_regist_button.Text = "Изменить";
            registr_regist_button.UseVisualStyleBackColor = true;
            registr_regist_button.Click += registr_regist_button_Click;
            // 
            // registr_back_button
            // 
            registr_back_button.Location = new Point(546, 362);
            registr_back_button.Name = "registr_back_button";
            registr_back_button.Size = new Size(97, 23);
            registr_back_button.TabIndex = 24;
            registr_back_button.Text = "Назад";
            registr_back_button.UseVisualStyleBackColor = true;
            // 
            // registr_clear_button
            // 
            registr_clear_button.Location = new Point(325, 346);
            registr_clear_button.Name = "registr_clear_button";
            registr_clear_button.Size = new Size(100, 23);
            registr_clear_button.TabIndex = 23;
            registr_clear_button.Text = "Очистить";
            registr_clear_button.UseVisualStyleBackColor = true;
            registr_clear_button.Click += registr_clear_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(140, 193);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 27;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += edit_edit_button_info_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 193);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 26;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += edit_clear_info_button_Click;
            // 
            // UserEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 408);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(registr_regist_button);
            Controls.Add(registr_back_button);
            Controls.Add(registr_clear_button);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(edit_new_password_textBox);
            Controls.Add(edit_old_password_textBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(registr_name);
            Controls.Add(edit_phoneNumber_textBox);
            Controls.Add(edit_lastName_textBox);
            Controls.Add(edit_name_textBox);
            Name = "UserEdit";
            Text = "UserEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Label registr_name;
        private TextBox edit_phoneNumber_textBox;
        private TextBox edit_lastName_textBox;
        private TextBox edit_name_textBox;
        private Label label5;
        private Label label2;
        private TextBox edit_new_password_textBox;
        private TextBox edit_old_password_textBox;
        private Button registr_regist_button;
        private Button registr_back_button;
        private Button registr_clear_button;
        private Button button1;
        private Button button2;
    }
}