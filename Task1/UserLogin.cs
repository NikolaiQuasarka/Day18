using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Classes;

namespace Task1
{
    public partial class UserLogin : Form
    {
        public UserLogin(Totalizator totalizator)
        {
            InitializeComponent();
            this.totalizator = totalizator;
        }
        Totalizator totalizator;
        public int result = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (totalizator.FindUser(textBoxLogin.Text, textBoxPassoword.Text)&&listBox1.SelectedItems.Count==1&&
                int.TryParse(textBoxParlaySum.Text,out int sum))
            {
                totalizator.currentUser.AddParlay(new Parlay(listBox1.SelectedItem.ToString(), sum));
                result++;
                Close();
            }
        }
    }
}
