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
        List<fencer> epee_participants = new List<fencer>();
        List<fencer> foil_participants = new List<fencer>();
        List<fencer> sabre_participants = new List<fencer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string weapon = listBox1.GetItemText(listBox1.SelectedItem);
            string categ = listBox2.GetItemText(listBox2.SelectedItem);
            fencer competitor = new fencer(textBox1.Text, textBox2.Text, weapon, categ);
            if (weapon == "Epee")
            {
                epee_participants.Add(competitor);
            }
            else if (weapon == "Foil")
            {
                foil_participants.Add(competitor);
            }
            else if (weapon == "Sabre")
            {
                sabre_participants.Add(competitor);
            }
            
            listBox3.Items.Add(competitor.ToString());
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (listBox1.SelectedIndex == 0)
            {
                foreach (fencer comp in epee_participants)
                {
                    listBox3.Items.Add(comp.ToString());
                }

            }
            else if (listBox1.SelectedIndex == 1)
            {
                foreach (fencer comp in foil_participants)
                {
                    listBox3.Items.Add(comp.ToString());
                }
            }
            else if (listBox1.SelectedIndex == 2)
            {
                foreach (fencer comp in sabre_participants)
                {
                    listBox3.Items.Add(comp.ToString());
                }

            }
        }
    }
}
