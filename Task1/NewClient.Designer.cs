namespace Task1
{
    partial class NewClient
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
            textBoxName = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(110, 35);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(271, 34);
            textBoxName.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(110, 93);
            textBoxLogin.Margin = new Padding(4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(271, 34);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(110, 159);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(271, 34);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 3;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 4;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 5;
            label3.Text = "Пароль:";
            // 
            // button1
            // 
            button1.Location = new Point(137, 248);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewClient
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 321);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            name = "NewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новый пользователь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        public TextBox textBoxName;
        public TextBox textBoxLogin;
        public TextBox textBoxPassword;
    }
}