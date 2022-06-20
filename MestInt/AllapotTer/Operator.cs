using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt.AllapotTer
{
    internal class Operator
    {
        private Point hova;
        public Point Hova
        {
            get { return hova; }
            set { hova = value; }
        }

        private string mit;
        public string Mit
        {
            get { return mit; }
            set { mit = value; }
        }

        public Operator(Point hova, string mit)
        {
            Hova = hova;
            Mit = mit;
        }
        public bool Elofeltetel(Allapot aktualisAllapot)
        {
            return aktualisAllapot.Palya[Hova.X, Hova.Y] == null;
        }

        public Allapot Lepes(Allapot AktualisAllapot)
        {
            Allapot ujAllapot = new Allapot();
            ujAllapot.Palya = (string[,])AktualisAllapot.Palya.Clone();

            ujAllapot.Palya[Hova.X, Hova.Y] = Mit;
            if (Mit == "R")
                ujAllapot.Jatekos = "B";
            else
                ujAllapot.Jatekos = "R";
            return ujAllapot;
        }
    }
}
