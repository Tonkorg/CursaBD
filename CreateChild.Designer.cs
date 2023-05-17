namespace CursaBD
{
    partial class CreateChild
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
            comboBox1 = new ComboBox();
            registr_regist_button = new Button();
            registr_back_button = new Button();
            registr_clear_button = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            registr_name = new Label();
            child_Age_textBox = new TextBox();
            child_lastName_textBox = new TextBox();
            child_name_textBox = new TextBox();
            child_sens_textBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 106);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 31;
            label3.Text = "Пол";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "М", "Ж" });
            comboBox1.Location = new Point(506, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 30;
            // 
            // registr_regist_button
            // 
            registr_regist_button.Location = new Point(208, 272);
            registr_regist_button.Name = "registr_regist_button";
            registr_regist_button.Size = new Size(132, 23);
            registr_regist_button.TabIndex = 29;
            registr_regist_button.Text = "Добавить ребенка";
            registr_regist_button.UseVisualStyleBackColor = true;
            registr_regist_button.Click += registr_regist_button_Click;
            // 
            // registr_back_button
            // 
            registr_back_button.Location = new Point(45, 325);
            registr_back_button.Name = "registr_back_button";
            registr_back_button.Size = new Size(97, 23);
            registr_back_button.TabIndex = 28;
            registr_back_button.Text = "Назад";
            registr_back_button.UseVisualStyleBackColor = true;
            registr_back_button.Click += registr_back_button_Click;
            // 
            // registr_clear_button
            // 
            registr_clear_button.Location = new Point(405, 325);
            registr_clear_button.Name = "registr_clear_button";
            registr_clear_button.Size = new Size(100, 23);
            registr_clear_button.TabIndex = 27;
            registr_clear_button.Text = "Очистить";
            registr_clear_button.UseVisualStyleBackColor = true;
            registr_clear_button.Click += registr_clear_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 176);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 25;
            label4.Text = "Есть ли аллергия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 176);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 23;
            label2.Text = "Введите возраст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 48);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 22;
            label1.Text = "Введите Фамилию";
            // 
            // registr_name
            // 
            registr_name.AutoSize = true;
            registr_name.Location = new Point(78, 48);
            registr_name.Name = "registr_name";
            registr_name.Size = new Size(77, 15);
            registr_name.TabIndex = 21;
            registr_name.Text = "Введите Имя";
            // 
            // child_Age_textBox
            // 
            child_Age_textBox.Location = new Point(22, 194);
            child_Age_textBox.Name = "child_Age_textBox";
            child_Age_textBox.Size = new Size(210, 23);
            child_Age_textBox.TabIndex = 17;
            // 
            // child_lastName_textBox
            // 
            child_lastName_textBox.Location = new Point(295, 66);
            child_lastName_textBox.Name = "child_lastName_textBox";
            child_lastName_textBox.Size = new Size(210, 23);
            child_lastName_textBox.TabIndex = 16;
            // 
            // child_name_textBox
            // 
            child_name_textBox.Location = new Point(22, 66);
            child_name_textBox.Name = "child_name_textBox";
            child_name_textBox.Size = new Size(210, 23);
            child_name_textBox.TabIndex = 15;
            // 
            // child_sens_textBox
            // 
            child_sens_textBox.Location = new Point(295, 194);
            child_sens_textBox.Name = "child_sens_textBox";
            child_sens_textBox.Size = new Size(210, 23);
            child_sens_textBox.TabIndex = 19;
            // 
            // CreateChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 361);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(registr_regist_button);
            Controls.Add(registr_back_button);
            Controls.Add(registr_clear_button);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registr_name);
            Controls.Add(child_sens_textBox);
            Controls.Add(child_Age_textBox);
            Controls.Add(child_lastName_textBox);
            Controls.Add(child_name_textBox);
            Name = "CreateChild";
            Text = "CreateChild";
            Load += CreateChild_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBox1;
        private Button registr_regist_button;
        private Button registr_back_button;
        private Button registr_clear_button;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label registr_name;
        private TextBox child_Age_textBox;
        private TextBox child_lastName_textBox;
        private TextBox child_name_textBox;
        private TextBox child_sens_textBox;
    }
}