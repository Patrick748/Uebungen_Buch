using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDatenfeld_Eindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new Random();

        private void BtnMin_Click(object sender, EventArgs e)
        {
            int[] zahlen = new int[10];
            
            LstZahlen.Items.Clear();

            for(int i =0; i<= zahlen.GetUpperBound(0); i++)
            {
                zahlen[i] = r.Next(0,10);
                LstZahlen.Items.Add(zahlen[i]);
            }

            int minimalwert = zahlen[0];

            for (int i=0; i <= zahlen.GetUpperBound(0); i++)
            {
                if(minimalwert > zahlen[i])
                {
                    minimalwert = zahlen[i];
                }
            }

            LblAusgabe.Text = "Minimalwert: " + minimalwert + "\n";

            for (int i = 0; i <= zahlen.GetUpperBound(0); i++)
            {
                if (minimalwert >= zahlen[i])
                {
                    LblAusgabe.Text += "Index: " + i + "\n";
                }
            }
        }
    }
}
