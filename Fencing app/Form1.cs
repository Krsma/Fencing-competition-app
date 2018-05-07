using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fencing_app
{
   
    public partial class Form1 : Form
    {
        List<fencer> competitors = new List<fencer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string weapon = listBox1.GetItemText(listBox1.SelectedItem);
            string categ = listBox2.GetItemText(listBox2.SelectedItem);
            fencer competitor = new fencer(textBox1.Text, textBox2.Text, weapon, categ);
            listBox3.Items.Add(competitor.ToString());
            competitors.Add(competitor);
                
        }
    }
}
