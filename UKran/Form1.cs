using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool HakenAus = false;
        bool HakenEin = false;
        bool AuslegerAus = false;
        bool AuslegerEin = false;
        bool KranRechts = false;
        bool KranLinks = false;
        bool KranAus = false;
        bool KranEin = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (rbnHakenAus.Checked)
            {
                HakenAus = true;
                HakenEin = false;
                AuslegerAus = false;
                AuslegerEin = false;
                KranRechts = false;
                KranLinks = false;
                KranAus = false;
                KranEin = false;
            }

            else if (rbnHakenEin.Checked)
            {
                HakenAus = false;
                HakenEin = true;
                AuslegerAus = false;
                AuslegerEin = false;
                KranRechts = false;
                KranLinks = false;
                KranAus = false;
                KranEin = false;
            }

            else if (rbnAuslegerAus.Checked)
            {
                HakenAus = false;
                HakenEin = false;
                AuslegerAus = true;
                AuslegerEin = false;
                KranRechts = false;
                KranLinks = false;
                KranAus = false;
                KranEin = false;
            }

            else if (rbnAuslegerEin.Checked)
            {
                HakenAus = false;
                HakenEin = false;
                AuslegerAus = false;
                AuslegerEin = true;
                KranRechts = false;
                KranLinks = false;
                KranAus = false;
                KranEin = false;
            }

            else if (rbnKranRechts.Checked)
            {
                HakenAus = false;
                HakenEin = false;
                AuslegerAus = false;
                AuslegerEin = false;
                KranRechts = true;
                KranLinks = false;
                KranAus = false;
                KranEin = false;
            }

            else if (rbnKranLinks.Checked)
            {
                HakenAus = false;
                HakenEin = false;
                AuslegerAus = false;
                AuslegerEin = false;
                KranRechts = false;
                KranLinks = true;
                KranAus = false;
                KranEin = false;
            }

            else if (rbnKranAus.Checked)
            {
                HakenAus = false;
                HakenEin = false;
                AuslegerAus = false;
                AuslegerEin = false;
                KranRechts = false;
                KranLinks = false;
                KranAus = true;
                KranEin = false;
            }

            else if (rbnKranEin.Checked)
            {
                HakenAus = false;
                HakenEin = false;
                AuslegerAus = false;
                AuslegerEin = false;
                KranRechts = false;
                KranLinks = false;
                KranAus = false;
                KranEin = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (HakenAus && (pnlSeil.Height < (pnlHoehe.Height-30)))
            {
                pnlSeil.Height += 1;
            }
            if (HakenEin)
            {
                pnlSeil.Height -= 1;
            }
            if (AuslegerAus && (pnlAusleger.Location.X > 1))
            {
                pnlAusleger.Width += 1;
                pnlAusleger.Location = new Point(pnlAusleger.Location.X - 1, pnlAusleger.Location.Y);
                pnlSeil.Location = new Point(pnlSeil.Location.X - 1, pnlSeil.Location.Y);
            }
            if (AuslegerEin && (pnlAusleger.Width > 70))
            {
                pnlAusleger.Width -= 1;
                pnlAusleger.Location = new Point(pnlAusleger.Location.X + 1, pnlAusleger.Location.Y);
                pnlSeil.Location = new Point(pnlSeil.Location.X + 1, pnlSeil.Location.Y);
            }
            if (KranLinks && (pnlAusleger.Location.X > 1))
            {
                pnlSeil.Location = new Point(pnlSeil.Location.X - 1, pnlSeil.Location.Y);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X - 1, pnlAusleger.Location.Y);
                pnlHoehe.Location = new Point(pnlHoehe.Location.X - 1, pnlHoehe.Location.Y);
                pnlBoden.Location = new Point(pnlBoden.Location.X - 1, pnlBoden.Location.Y);
            }
            if (KranRechts && pnlBoden.Location.X < 709)
            {
                pnlSeil.Location = new Point(pnlSeil.Location.X + 1, pnlSeil.Location.Y);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X + 1, pnlAusleger.Location.Y);
                pnlHoehe.Location = new Point(pnlHoehe.Location.X + 1, pnlHoehe.Location.Y);
                pnlBoden.Location = new Point(pnlBoden.Location.X + 1, pnlBoden.Location.Y);
            }
            if (KranAus && (pnlHoehe.Location.Y > 1))
            {
                pnlHoehe.Height += 1;
                pnlSeil.Location = new Point(pnlSeil.Location.X, pnlSeil.Location.Y - 1);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X, pnlAusleger.Location.Y - 1);
                pnlHoehe.Location = new Point(pnlHoehe.Location.X, pnlHoehe.Location.Y - 1);
            }
            if (KranEin && (pnlHoehe.Height > 170) && (pnlSeil.Location.Y+pnlSeil.Height < 526))
            {
                pnlHoehe.Height -= 1;
                pnlSeil.Location = new Point(pnlSeil.Location.X, pnlSeil.Location.Y + 1);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X, pnlAusleger.Location.Y + 1);
                pnlHoehe.Location = new Point(pnlHoehe.Location.X, pnlHoehe.Location.Y + 1);
            }

        }

        private void rbnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
