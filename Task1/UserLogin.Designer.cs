namespace Task1
{
    partial class UserLogin
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
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassoword = new TextBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            textBoxParlaySum = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(106, 380);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(167, 41);
            button1.TabIndex = 0;
            button1.Text = "Сделать ставку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 2;
            label2.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(148, 29);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(125, 34);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassoword
            // 
            textBoxPassoword.Location = new Point(148, 84);
            textBoxPassoword.Name = "textBoxPassoword";
            textBoxPassoword.PasswordChar = '*';
            textBoxPassoword.Size = new Size(125, 34);
            textBoxPassoword.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 209);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите, на какую лошадь сделать ставку:";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "Белый Ветер ", "Черная Молния", "Золотая Искра", "Серебряный Ручей", "Красный Закат", "Синяя Волна", "Зеленый Луг" });
            listBox1.Location = new Point(3, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(361, 144);
            listBox1.TabIndex = 0;
            // 
            // textBoxParlaySum
            // 
            textBoxParlaySum.Location = new Point(251, 339);
            textBoxParlaySum.Name = "textBoxParlaySum";
            textBoxParlaySum.Size = new Size(125, 34);
            textBoxParlaySum.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 342);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 7;
            label3.Text = "Укажите сумму ставки:";
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 446);
            Controls.Add(label3);
            Controls.Add(textBoxParlaySum);
            Controls.Add(groupBox1);
            Controls.Add(textBoxPassoword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassoword;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox textBoxParlaySum;
        private Label label3;
    }
}