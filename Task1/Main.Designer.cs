namespace Task1
{
    partial class Main
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
            listViewUsers = new ListView();
            buttonStart = new Button();
            buttonAddUser = new Button();
            groupBox1 = new GroupBox();
            buttonAddParlay = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewUsers
            // 
            listViewUsers.Dock = DockStyle.Fill;
            listViewUsers.Location = new Point(4, 31);
            listViewUsers.Margin = new Padding(4);
            listViewUsers.MultiSelect = false;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(423, 291);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.List;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(109, 383);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(203, 53);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Начать забег";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(0, 331);
            buttonAddUser.Margin = new Padding(4);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(247, 44);
            buttonAddUser.TabIndex = 3;
            buttonAddUser.Text = "Добавить пользователя";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewUsers);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(431, 326);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пользователи";
            // 
            // buttonAddParlay
            // 
            buttonAddParlay.Location = new Point(254, 330);
            buttonAddParlay.Name = "buttonAddParlay";
            buttonAddParlay.Size = new Size(177, 45);
            buttonAddParlay.TabIndex = 10;
            buttonAddParlay.Text = "Добавить ставку";
            buttonAddParlay.UseVisualStyleBackColor = true;
            buttonAddParlay.Click += buttonAddParlay_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 454);
            Controls.Add(buttonAddParlay);
            Controls.Add(groupBox1);
            Controls.Add(buttonAddUser);
            Controls.Add(buttonStart);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ипподромный тотализатор";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewUsers;
        private Button buttonStart;
        private Button buttonAddUser;
        private GroupBox groupBox1;
        private Button buttonAddParlay;
    }
}
