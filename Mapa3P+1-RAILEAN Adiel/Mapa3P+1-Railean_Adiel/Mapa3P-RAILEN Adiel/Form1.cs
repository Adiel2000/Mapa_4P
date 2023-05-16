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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
 /*       //Rescrie evenimentul butonului exit [X] Form1
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.DialogResult Raspuns;   

                // Display a MsgBox asking the user to save changes or abort.

                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Raspuns = MessageBox.Show("Esti sigur?", "Iesire",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                    if (Raspuns == System.Windows.Forms.DialogResult.Yes)
                        Application.Exit();
                    else e.Cancel = true;

                 }
        }
*/
        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Linii de cod pentru Iesire
                        System.Windows.Forms.DialogResult Raspuns;
            
                        Raspuns= MessageBox.Show("Esti sigur?", "Iesire",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1 );
            
                        if( Raspuns== System.Windows.Forms.DialogResult.Yes )
                            Application.Exit();
        }

        private void programul1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 P1 = new Form2();
            P1.ShowDialog();

        }

        private void programul2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 P2 = new Form3();
            P2.ShowDialog();
        }

        private void programul3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
    Form4 P3 = new Form4();
   P3.ShowDialog(); 
   
}

private void programeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Ajutor = new Form5();
            Ajutor.ShowDialog();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mapa3P+1 v1.0\nAutor:RAILEAN Adiel  anul II MECA\n2021",
            "Despre");

        }


        private void verdeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            albToolStripMenuItem.Checked = false;
            galbenToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = true;
        }

        private void albToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            albToolStripMenuItem.Checked = true;
            galbenToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
        }

        private void galbenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            albToolStripMenuItem.Checked = false;
            galbenToolStripMenuItem.Checked = true;
            verdeToolStripMenuItem.Checked = false;
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1.Font.Size = 8;
            this.Font = new System.Drawing.Font(
                      "Microsoft Sans Serif",
                      8.0F);
                      //System.Drawing.FontStyle.Regular,
                      //System.Drawing.GraphicsUnit.Point,
                      //((byte)(0)));
            ptToolStripMenuItem.Checked = true;
            ptToolStripMenuItem2.Checked = false;
            ptToolStripMenuItem1.Checked = false;
        }

        private void ptToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font(
                      "Microsoft Sans Serif",
                      12.0F);
            ptToolStripMenuItem.Checked = false;
            ptToolStripMenuItem2.Checked = true;
            ptToolStripMenuItem1.Checked = false;
        }

        private void ptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font(
                      "Microsoft Sans Serif",
                      10.0F);
            ptToolStripMenuItem.Checked = false;
            ptToolStripMenuItem2.Checked = false;
            ptToolStripMenuItem1.Checked = true;
        }

        private void programul4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 P4 = new Form6();
            P4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
