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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { double Fx, Fy,F,b,a,alpha,Va,Vb,Ha,l,V;
            F = double.Parse(textBox1.Text);
            a = double.Parse(textBox2.Text);
            b= double.Parse(textBox3.Text);
            alpha = double.Parse(textBox4.Text);
            Fx = F * Math.Cos(alpha*(Math.PI / 180));
            Fy = F * Math.Sin(alpha*(Math.PI/180));
            Ha = Fx;
            l = a + b;
            Va = (Fy * b) / l;
            Vb = (Fy * a) / l;
            V = (Va + Vb) - Fy;
            textBox5.Text = Convert.ToString(Fx);
            textBox6.Text = Convert.ToString(Fy);
            textBox7.Text = Convert.ToString(Ha);
            textBox8.Text = Convert.ToString(Va);
            textBox9.Text = Convert.ToString(Vb);
            textBox11.Text = Convert.ToString(l);
            textBox10.Text = Convert.ToString(V);





            
        }


    }
}
