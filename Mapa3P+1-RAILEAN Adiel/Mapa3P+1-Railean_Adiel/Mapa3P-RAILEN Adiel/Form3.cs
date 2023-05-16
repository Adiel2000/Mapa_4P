using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa3P_NUME_Prenume
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double n1, n2, n3, n4, n5, n6, n7, n8, 
            suma = 0, restante = 0, sumweight = 0,
             media;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);
            n5 = double.Parse(textBox5.Text);
            n6 = double.Parse(textBox6.Text);
            n7 = double.Parse(textBox7.Text);
            n8 = double.Parse(textBox8.Text);
            if (n1 < 5) 
            { restante = restante + 1; n1 = 0; }
            if (n2 < 5)
            { restante = restante + 1; n2 = 0; }
            if (n3 < 5)
            { restante = restante + 1; n3 = 0; }
            if (n4 < 5)
            { restante = restante + 1; n4 = 0; }
            if (n5 < 5)
            { restante = restante + 1; n5 = 0; }
            if (n6 < 5)
            { restante = restante + 1; n6 = 0; }
            if (n7 < 5)
            { restante = restante + 1; n7 = 0; }
            if (n8 < 5)
            { restante = restante + 1; n8 = 0; }


            media = (n1 * 5 + n2 * 4 + n3 * 6 + n4 * 3 + n5 * 3 + n6 * 3 + n7 * 4 + n8 * 2) / 30;
            textBox9.Text = Convert.ToString( media );
            textBox10.Text = Convert.ToString(restante);
        }
    }
}
