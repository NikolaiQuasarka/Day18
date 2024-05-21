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
    public partial class winnersResult : Form
    {
        public winnersResult(Totalizator totalizator )
        {
            InitializeComponent();
            var result = totalizator.GenerateResults();
            var Winners=totalizator.CalculateMoney(result);
            foreach( var item in Winners )
            {
                dataGridView1.Rows.Add(item.Key.Name,item.Value);
            }
            foreach( var item in result)
            {
                listBox1.Items.Add($"{item.Key} {item.Value}");
            }
        }
    }
}
