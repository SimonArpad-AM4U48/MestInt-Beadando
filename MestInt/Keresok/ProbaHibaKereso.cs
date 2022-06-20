using MestInt.AllapotTer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt.Keresok
{
    internal class ProbaHibaKereso
    {
        public Operator Ajanlas(Allapot allapot)
        {
            while (true)
            {
                Random random = new Random();
                Operator op = new Operator((new Point(random.Next(Allapot.SOR), random.Next(Allapot.OSZLOP))), "B");
                if (op.Elofeltetel(allapot))
                {
                    return op;
                }
            }
        }
    }
}
