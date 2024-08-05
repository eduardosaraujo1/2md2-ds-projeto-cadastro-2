using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetoCadastro2
{
    public static class Utils
    {
        public static int EvalTableAutoIncrement(DataTable table)
        {
            int nextIncr = 0;

            if (table.Rows.Count > 0)
            {
                nextIncr = (int)table.Compute("MAX(Id)", "");
            }

            return nextIncr + 1;
        }

        public static void PrintPage(string page, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Courier New", 10, FontStyle.Regular);
            PointF anchorPoint = new PointF(50, 50);

            g.DrawString(page, font, Brushes.Black, anchorPoint);
        }
    }
}
