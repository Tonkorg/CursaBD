namespace CursaBD
{
    partial class EnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            textBox1 = new TextBox();
            enter_login = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            enter_password = new Label();
            label3 = new Label();
            enter_registr_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(697, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 0;
            // 
            // enter_login
            // 
            enter_login.AutoSize = true;
            enter_login.Location = new Point(914, 64);
            enter_login.Name = "enter_login";
            enter_login.Size = new Size(41, 15);
            enter_login.TabIndex = 1;
            enter_login.Text = "Логин";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(727, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Сообщество в социальных сетях";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(727, 164);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 3;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(570, 429);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(697, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 5;
            // 
            // enter_password
            // 
            enter_password.AutoSize = true;
            enter_password.Location = new Point(914, 122);
            enter_password.Name = "enter_password";
            enter_password.Size = new Size(49, 15);
            enter_password.TabIndex = 6;
            enter_password.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(676, 295);
            label3.Name = "label3";
            label3.Size = new Size(240, 15);
            label3.TabIndex = 7;
            label3.Text = "Нет еще аккаунта?   Зарегистрируй новый";
            // 
            // enter_registr_button
            // 
            enter_registr_button.Location = new Point(741, 327);
            enter_registr_button.Name = "enter_registr_button";
            enter_registr_button.Size = new Size(111, 23);
            enter_registr_button.TabIndex = 8;
            enter_registr_button.Text = "Регистрация";
            enter_registr_button.UseVisualStyleBackColor = true;
            enter_registr_button.Click += enter_registr_button_Click;
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 450);
            Controls.Add(enter_registr_button);
            Controls.Add(label3);
            Controls.Add(enter_password);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(enter_login);
            Controls.Add(textBox1);
            Name = "EnterForm";
            Text = "EnterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label enter_login;
        private LinkLabel linkLabel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label enter_password;
        private Label label3;
        private Button enter_registr_button;
    }
}