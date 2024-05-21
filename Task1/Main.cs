using System.ComponentModel;
using System.Text.Json;
using Task1.Classes;

namespace Task1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            totalizator = new Totalizator();
        }
        Classes.Totalizator totalizator;

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (newClient.name != null)
                {
                    totalizator.AddUser(newClient.name, newClient.Login, newClient.Password);
                    listViewUsers.Items.Add(newClient.name);
                }
            };
            newClient.ShowDialog();
        }

        private void buttonAddParlay_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin(totalizator);
            userLogin.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                if (userLogin.result == 1)
                {

                }
            };
            userLogin.ShowDialog();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            winnersResult winnersResult = new winnersResult(totalizator);
            winnersResult.ShowDialog();
        }
    }
}
