using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task1
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        public string name=null;
        public string Login=null;
        public string Password=null;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text!=""&&textBoxPassword.Text!=""&&textBoxName.Text!="") 
            {
                name=textBoxName.Text;
                Login=textBoxLogin.Text;
                Password=textBoxPassword.Text;
            }
            Close();
        }
    }
}
