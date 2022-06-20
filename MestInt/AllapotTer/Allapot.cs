using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt.AllapotTer
{
    internal class Allapot
    {
        public static int SOR = 11;
        public static int OSZLOP = 11;

        private string[,] palya;
        public string[,] Palya
        {
            get { return palya; }
            set { palya = value; }
        }

        private string jatekos;
        public string Jatekos
        {
            get { return jatekos; }
            set { jatekos = value; }
        }

        public Allapot()
        {
            Palya = new string[SOR, OSZLOP];
            for (int i = 0; i < SOR; i++)
            {
                for (int j = 0; j < OSZLOP; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                        Palya[i, j] = "R";
                    if (i % 2 != 0 && j % 2 == 0)
                        Palya[i, j] = "B";
                }
            }
        }

        public string Celfeltetel()
        {
            //piros nyer
            for (int i = 0; i < OSZLOP; i++)
            {
                if (palya[0, i] == "R")
                {
                    if (palya[0, i] == palya[1, i] &&
                        palya[1, i] == palya[2, i] &&
                        Palya[2, i] == palya[3, i] &&
                        Palya[3, i] == palya[4, i] &&
                        Palya[4, i] == palya[5, i] &&
                        Palya[5, i] == palya[6, i] &&
                        Palya[6, i] == palya[7, i] &&
                        Palya[7, i] == palya[8, i] &&
                        Palya[8, i] == palya[9, i] &&
                        Palya[9, i] == palya[10, i])
                    {
                        return palya[10, i];
                    }
                }
            }
            //kék nyer
            for (int i = 0; i < SOR; i++)
            {
                if (palya[i, 0] == "B")
                {
                    if (palya[i, 0] == palya[i, 1] &&
                        palya[i, 1] == palya[i, 2] &&
                        palya[i, 2] == palya[i, 3] &&
                        palya[i, 3] == palya[i, 4] &&
                        palya[i, 4] == palya[i, 5] &&
                        palya[i, 5] == palya[i, 6] &&
                        palya[i, 6] == palya[i, 7] &&
                        palya[i, 7] == palya[i, 8] &&
                        palya[i, 8] == palya[i, 9] &&
                        palya[i, 9] == palya[i, 10])
                    {
                        return palya[i, 10];
                    }
                }
            }
            //meg nincs vege
            for (int i = 0; i < SOR; i++)
            {
                for (int j = 0; j < OSZLOP; j++)
                {
                    if (palya[i, j] == null)
                    {
                        return null;
                    }
                }
            }
            //döntetlen
            return "Döntetlen";
        }
    }
}
