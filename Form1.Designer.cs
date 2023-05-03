namespace CursaBD
{
    partial class registr_form
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
            registr_name_textBox = new TextBox();
            registr_lastName_textBox = new TextBox();
            registr_password_textBox = new TextBox();
            registr_password_confirm_textBox = new TextBox();
            registr_login_textBox = new TextBox();
            registr_phoneNumber_textBox = new TextBox();
            registr_name = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            registr_clear_button = new Button();
            registr_back_button = new Button();
            registr_regist_button = new Button();
            SuspendLayout();
            // 
            // registr_name_textBox
            // 
            registr_name_textBox.Location = new Point(32, 69);
            registr_name_textBox.Name = "registr_name_textBox";
            registr_name_textBox.Size = new Size(210, 23);
            registr_name_textBox.TabIndex = 0;
            // 
            // registr_lastName_textBox
            // 
            registr_lastName_textBox.Location = new Point(32, 197);
            registr_lastName_textBox.Name = "registr_lastName_textBox";
            registr_lastName_textBox.Size = new Size(210, 23);
            registr_lastName_textBox.TabIndex = 1;
            // 
            // registr_password_textBox
            // 
            registr_password_textBox.Location = new Point(32, 311);
            registr_password_textBox.Name = "registr_password_textBox";
            registr_password_textBox.Size = new Size(210, 23);
            registr_password_textBox.TabIndex = 2;
            registr_password_textBox.TextChanged += textBox3_TextChanged;
            // 
            // registr_password_confirm_textBox
            // 
            registr_password_confirm_textBox.Location = new Point(349, 311);
            registr_password_confirm_textBox.Name = "registr_password_confirm_textBox";
            registr_password_confirm_textBox.Size = new Size(210, 23);
            registr_password_confirm_textBox.TabIndex = 5;
            // 
            // registr_login_textBox
            // 
            registr_login_textBox.Location = new Point(349, 197);
            registr_login_textBox.Name = "registr_login_textBox";
            registr_login_textBox.Size = new Size(210, 23);
            registr_login_textBox.TabIndex = 4;
            // 
            // registr_phoneNumber_textBox
            // 
            registr_phoneNumber_textBox.Location = new Point(349, 69);
            registr_phoneNumber_textBox.Name = "registr_phoneNumber_textBox";
            registr_phoneNumber_textBox.Size = new Size(210, 23);
            registr_phoneNumber_textBox.TabIndex = 3;
            // 
            // registr_name
            // 
            registr_name.AutoSize = true;
            registr_name.Location = new Point(88, 51);
            registr_name.Name = "registr_name";
            registr_name.Size = new Size(77, 15);
            registr_name.TabIndex = 6;
            registr_name.Text = "Введите Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 179);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 7;
            label1.Text = "Введите Фамилию";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 293);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 8;
            label2.Text = "Введите пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 51);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 9;
            label3.Text = "Введите номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 179);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 10;
            label4.Text = "Введите логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 293);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 11;
            label5.Text = "Подтвердите пароль";
            // 
            // registr_clear_button
            // 
            registr_clear_button.Location = new Point(546, 383);
            registr_clear_button.Name = "registr_clear_button";
            registr_clear_button.Size = new Size(100, 23);
            registr_clear_button.TabIndex = 12;
            registr_clear_button.Text = "Очистить";
            registr_clear_button.UseVisualStyleBackColor = true;
            registr_clear_button.Click += registr_clear_button_Click;
            // 
            // registr_back_button
            // 
            registr_back_button.Location = new Point(691, 383);
            registr_back_button.Name = "registr_back_button";
            registr_back_button.Size = new Size(97, 23);
            registr_back_button.TabIndex = 13;
            registr_back_button.Text = "Назад";
            registr_back_button.UseVisualStyleBackColor = true;
            registr_back_button.Click += registr_back_button_Click;
            // 
            // registr_regist_button
            // 
            registr_regist_button.Location = new Point(656, 197);
            registr_regist_button.Name = "registr_regist_button";
            registr_regist_button.Size = new Size(132, 23);
            registr_regist_button.TabIndex = 14;
            registr_regist_button.Text = "Зарегистрироваться";
            registr_regist_button.UseVisualStyleBackColor = true;
            registr_regist_button.Click += registr_regist_button_Click;
            // 
            // registr_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registr_regist_button);
            Controls.Add(registr_back_button);
            Controls.Add(registr_clear_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registr_name);
            Controls.Add(registr_password_confirm_textBox);
            Controls.Add(registr_login_textBox);
            Controls.Add(registr_phoneNumber_textBox);
            Controls.Add(registr_password_textBox);
            Controls.Add(registr_lastName_textBox);
            Controls.Add(registr_name_textBox);
            Name = "registr_form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox registr_name_textBox;
        private TextBox registr_lastName_textBox;
        private TextBox registr_password_textBox;
        private TextBox registr_password_confirm_textBox;
        private TextBox registr_login_textBox;
        private TextBox registr_phoneNumber_textBox;
        private Label registr_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registr_clear_button;
        private Button registr_back_button;
        private Button registr_regist_button;
    }
}