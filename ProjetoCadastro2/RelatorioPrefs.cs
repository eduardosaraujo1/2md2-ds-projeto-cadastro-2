using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetoCadastro2
{
    public static class RelatorioPrefs
    {
        public static int PAGE_LINE_COUNT = 68;
        public static int PAGE_LINE_LENGTH = 84;
        public static int MARGIN_TOP = 50;
        public static int MARGIN_LEFT = 50;
        public static Font FONT = new Font("Courier New", 10);
        public static Brush BRUSH_COLOR = Brushes.Black;
        public static PointF DRAW_ANCHOR = new PointF(MARGIN_LEFT, MARGIN_TOP);
    }
}
