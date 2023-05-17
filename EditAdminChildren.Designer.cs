namespace CursaBD
{
    partial class EditAdminChildren
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
            registr_regist_button = new Button();
            registr_back_button = new Button();
            registr_clear_button = new Button();
            label2 = new Label();
            edit_child_sens_textBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            registr_name = new Label();
            edit_child_age_textBox = new TextBox();
            edit_child_lastName_textBox = new TextBox();
            edit_child_name_textBox = new TextBox();
            label4 = new Label();
            Otr_textBox = new TextBox();
            SuspendLayout();
            // 
            // registr_regist_button
            // 
            registr_regist_button.Location = new Point(367, 100);
            registr_regist_button.Name = "registr_regist_button";
            registr_regist_button.Size = new Size(132, 23);
            registr_regist_button.TabIndex = 51;
            registr_regist_button.Text = "Изменить";
            registr_regist_button.UseVisualStyleBackColor = true;
            // 
            // registr_back_button
            // 
            registr_back_button.Location = new Point(367, 228);
            registr_back_button.Name = "registr_back_button";
            registr_back_button.Size = new Size(132, 23);
            registr_back_button.TabIndex = 50;
            registr_back_button.Text = "Назад";
            registr_back_button.UseVisualStyleBackColor = true;
            registr_back_button.Click += registr_back_button_Click;
            // 
            // registr_clear_button
            // 
            registr_clear_button.Location = new Point(367, 174);
            registr_clear_button.Name = "registr_clear_button";
            registr_clear_button.Size = new Size(132, 23);
            registr_clear_button.TabIndex = 49;
            registr_clear_button.Text = "Очистить";
            registr_clear_button.UseVisualStyleBackColor = true;
            registr_clear_button.Click += registr_clear_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 262);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 48;
            label2.Text = "Есть ли аллергия";
            // 
            // edit_child_sens_textBox
            // 
            edit_child_sens_textBox.Location = new Point(82, 280);
            edit_child_sens_textBox.Name = "edit_child_sens_textBox";
            edit_child_sens_textBox.Size = new Size(210, 23);
            edit_child_sens_textBox.TabIndex = 47;
            edit_child_sens_textBox.Click += edit_child_sens_textBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 182);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 46;
            label3.Text = "Введите возраст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 108);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 45;
            label1.Text = "Введите Фамилию";
            // 
            // registr_name
            // 
            registr_name.AutoSize = true;
            registr_name.Location = new Point(144, 27);
            registr_name.Name = "registr_name";
            registr_name.Size = new Size(77, 15);
            registr_name.TabIndex = 44;
            registr_name.Text = "Введите Имя";
            // 
            // edit_child_age_textBox
            // 
            edit_child_age_textBox.Location = new Point(82, 210);
            edit_child_age_textBox.Name = "edit_child_age_textBox";
            edit_child_age_textBox.Size = new Size(210, 23);
            edit_child_age_textBox.TabIndex = 43;
            edit_child_age_textBox.Click += edit_child_age_textBox_TextChanged;
            // 
            // edit_child_lastName_textBox
            // 
            edit_child_lastName_textBox.Location = new Point(82, 126);
            edit_child_lastName_textBox.Name = "edit_child_lastName_textBox";
            edit_child_lastName_textBox.Size = new Size(210, 23);
            edit_child_lastName_textBox.TabIndex = 42;
            edit_child_lastName_textBox.Click += edit_child_lastName_textBox_TextChanged;
            // 
            // edit_child_name_textBox
            // 
            edit_child_name_textBox.Location = new Point(82, 45);
            edit_child_name_textBox.Name = "edit_child_name_textBox";
            edit_child_name_textBox.Size = new Size(210, 23);
            edit_child_name_textBox.TabIndex = 41;
            edit_child_name_textBox.Click += edit_child_name_textBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 324);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 53;
            label4.Text = "Номер отряда";
            // 
            // Otr_textBox
            // 
            Otr_textBox.Location = new Point(82, 342);
            Otr_textBox.Name = "Otr_textBox";
            Otr_textBox.Size = new Size(210, 23);
            Otr_textBox.TabIndex = 52;
            Otr_textBox.Click += edit_child_otr_textBox_TextChanged;
            // 
            // EditAdminChildren
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 433);
            Controls.Add(label4);
            Controls.Add(Otr_textBox);
            Controls.Add(registr_regist_button);
            Controls.Add(registr_back_button);
            Controls.Add(registr_clear_button);
            Controls.Add(label2);
            Controls.Add(edit_child_sens_textBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(registr_name);
            Controls.Add(edit_child_age_textBox);
            Controls.Add(edit_child_lastName_textBox);
            Controls.Add(edit_child_name_textBox);
            Name = "EditAdminChildren";
            Text = "EditAdminChildren";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registr_regist_button;
        private Button registr_back_button;
        private Button registr_clear_button;
        private Label label2;
        private TextBox edit_child_sens_textBox;
        private Label label3;
        private Label label1;
        private Label registr_name;
        private TextBox edit_child_age_textBox;
        private TextBox edit_child_lastName_textBox;
        private TextBox edit_child_name_textBox;
        private Label label4;
        private TextBox Otr_textBox;
    }
}