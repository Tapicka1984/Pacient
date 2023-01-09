using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text != string.Empty) || (textBox2.Text != string.Empty) || (textBox3.Text != string.Empty) || (textBox4.Text != string.Empty))
            {
                Osoba Osoba = new Osoba(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                MessageBox.Show(Osoba.BMI());
            }
        }
    }
}
