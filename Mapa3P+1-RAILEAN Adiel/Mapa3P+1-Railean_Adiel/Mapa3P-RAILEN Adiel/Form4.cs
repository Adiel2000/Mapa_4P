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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, xG, yG;
            String Mesaj;
            if (!Double.TryParse(textBox1.Text, out a))
                 {
                MessageBox.Show("Trebuie introduse valori numerice pentru a si / sau g! ", "Eroare");
                return;
            };
            xG = 0.3162 * a;
            yG = -0.1926 * a;
             Mesaj = Convert.ToString(xG);
            textBox2.Text = Mesaj;
            Mesaj = Convert.ToString(yG);
            textBox3.Text = Mesaj;
            
        }
    }
}
