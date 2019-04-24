using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3_2531322018
{
    public partial class Form1 : Form
    {
        String Usua, Pass;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Usua;
            textBox2.Text = Pass;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            if (Pass == "UTEC" && Usua == "Con")
            {
                F2.Show();
            }
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Error de LOGIN");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
