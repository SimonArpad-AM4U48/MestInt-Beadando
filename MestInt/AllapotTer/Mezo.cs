using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestInt.AllapotTer
{
    internal class Mezo : Button
    {
        Point pont;
        public Point Pont
        {
            get { return pont; }
            set { pont = value; }
        }

        public Mezo(int x, int y)
        {
            Pont = new Point(x, y);
            Size = new Size(50, 50);
            Font = new Font(Font.FontFamily, 20, FontStyle.Bold);
        }
    }
}
