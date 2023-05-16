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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double n, R, l, A;
            String Mesaj;

            if (!Double.TryParse(textBox1.Text, out n) ||
           !Double.TryParse(textBox2.Text, out R))


            {
                MessageBox.Show("Trebuie introduse valori numerice pentru n,R! ", "Eroare");
                return;
            }
            l = R * Math.Cos(Math.PI / n);
            Mesaj = Convert.ToString(l);
            textBox3.Text = Mesaj;
            A = n * R * R * Math.Sin(Math.PI / n) * Math.Cos(Math.PI / n);
            Mesaj = Convert.ToString(A);
            textBox4.Text = Mesaj;
        }
    }
}
