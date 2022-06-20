using MestInt.AllapotTer;
using MestInt.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestInt
{
    public partial class Form1 : Form
    {
        Mezo[,] palya = new Mezo[Allapot.OSZLOP, Allapot.SOR];
        Allapot allapot;

        public Form1()
        {
            allapot = new Allapot();
            InitializeComponent();
            for (int i = 0; i < Allapot.SOR; i++)
            {
                for (int j = 0; j < Allapot.OSZLOP; j++)
                {
                    Mezo mezo = new Mezo(i, j);
                    mezo.Location = new Point(i * 50, j * 50);
                    mezo.Click += new EventHandler(mezoClick);
                    palya[i, j] = mezo;
                    Controls.Add(mezo);
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        allapot.Jatekos = "R";
                        Kirajzol(mezo);
                    }
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        allapot.Jatekos = "B";
                        Kirajzol(mezo);
                    }

                }
            }
            allapot.Jatekos = "R";
        }

        private void mezoClick(object sender, EventArgs e)
        {
            Mezo mezo = (Mezo)sender;
            Point pont = mezo.Pont;

            Operator op = new Operator(pont, allapot.Jatekos);
            if (op.Elofeltetel(allapot))
            {
                Kirajzol(mezo);
                allapot = op.Lepes(allapot);
                CelfeltetelVizsgalat();

                ProbaHibaKereso probaHibaKereses = new ProbaHibaKereso();
                Operator opGep = probaHibaKereses.Ajanlas(allapot);

                Mezo mezogep = palya[opGep.Hova.X, opGep.Hova.Y];
                Kirajzol(mezogep);
                allapot = opGep.Lepes(allapot);
                CelfeltetelVizsgalat();

            }
        }

        private void CelfeltetelVizsgalat()
        {
            if (allapot.Celfeltetel() != null)
            {
                if (allapot.Celfeltetel() == "Döntetlen")
                {
                    MessageBox.Show(allapot.Celfeltetel());
                }
                else
                {
                    MessageBox.Show("Gratulálunk! Nyert: " + allapot.Celfeltetel());
                }
                Close();
                Application.Exit();

            }
        }

        private void Kirajzol(Mezo mezo)
        {
            if (allapot.Jatekos == "R")
            {
                mezo.BackColor = Color.Red;
            }
            else
            {
                mezo.BackColor = Color.Blue;
            }
        }
    }
}
