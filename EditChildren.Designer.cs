namespace CursaBD
{
    partial class EditChildren
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
            edit_name_textBox = new TextBox();
            edit_lastName_textBox = new TextBox();
            edit_phoneNumber_textBox = new TextBox();
            registr_name = new Label();
            label1 = new Label();
            label3 = new Label();
            edit_old_password_textBox = new TextBox();
            edit_new_password_textBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            registr_clear_button = new Button();
            registr_back_button = new Button();
            registr_regist_button = new Button();
            SuspendLayout();
            // 
            // edit_name_textBox
            // 
            edit_name_textBox.Location = new Point(92, 62);
            edit_name_textBox.Name = "edit_name_textBox";
            edit_name_textBox.Size = new Size(210, 23);
            edit_name_textBox.TabIndex = 28;
            // 
            // edit_lastName_textBox
            // 
            edit_lastName_textBox.Location = new Point(369, 62);
            edit_lastName_textBox.Name = "edit_lastName_textBox";
            edit_lastName_textBox.Size = new Size(210, 23);
            edit_lastName_textBox.TabIndex = 29;
            // 
            // edit_phoneNumber_textBox
            // 
            edit_phoneNumber_textBox.Location = new Point(238, 142);
            edit_phoneNumber_textBox.Name = "edit_phoneNumber_textBox";
            edit_phoneNumber_textBox.Size = new Size(210, 23);
            edit_phoneNumber_textBox.TabIndex = 30;
            // 
            // registr_name
            // 
            registr_name.AutoSize = true;
            registr_name.Location = new Point(148, 44);
            registr_name.Name = "registr_name";
            registr_name.Size = new Size(77, 15);
            registr_name.TabIndex = 31;
            registr_name.Text = "Введите Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 44);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 32;
            label1.Text = "Введите Фамилию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 124);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 33;
            label3.Text = "Введите номер телефона";
            // 
            // edit_old_password_textBox
            // 
            edit_old_password_textBox.Location = new Point(92, 287);
            edit_old_password_textBox.Name = "edit_old_password_textBox";
            edit_old_password_textBox.Size = new Size(210, 23);
            edit_old_password_textBox.TabIndex = 34;
            // 
            // edit_new_password_textBox
            // 
            edit_new_password_textBox.Location = new Point(409, 287);
            edit_new_password_textBox.Name = "edit_new_password_textBox";
            edit_new_password_textBox.Size = new Size(210, 23);
            edit_new_password_textBox.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 269);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 36;
            label2.Text = "Введите старый пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 269);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 37;
            label5.Text = "Введите новый пароль";
            // 
            // registr_clear_button
            // 
            registr_clear_button.Location = new Point(390, 368);
            registr_clear_button.Name = "registr_clear_button";
            registr_clear_button.Size = new Size(100, 23);
            registr_clear_button.TabIndex = 38;
            registr_clear_button.Text = "Очистить";
            registr_clear_button.UseVisualStyleBackColor = true;
            // 
            // registr_back_button
            // 
            registr_back_button.Location = new Point(664, 406);
            registr_back_button.Name = "registr_back_button";
            registr_back_button.Size = new Size(97, 23);
            registr_back_button.TabIndex = 39;
            registr_back_button.Text = "Назад";
            registr_back_button.UseVisualStyleBackColor = true;
            // 
            // registr_regist_button
            // 
            registr_regist_button.Location = new Point(170, 368);
            registr_regist_button.Name = "registr_regist_button";
            registr_regist_button.Size = new Size(132, 23);
            registr_regist_button.TabIndex = 40;
            registr_regist_button.Text = "Изменить";
            registr_regist_button.UseVisualStyleBackColor = true;
            // 
            // EditChildren
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "EditChildren";
            Text = "EditChildren";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox edit_name_textBox;
        private TextBox edit_lastName_textBox;
        private TextBox edit_phoneNumber_textBox;
        private Label registr_name;
        private Label label1;
        private Label label3;
        private TextBox edit_old_password_textBox;
        private TextBox edit_new_password_textBox;
        private Label label2;
        private Label label5;
        private Button registr_clear_button;
        private Button registr_back_button;
        private Button registr_regist_button;
    }
}