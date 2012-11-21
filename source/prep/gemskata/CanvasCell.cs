using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.gemskata
{
    public class CanvasCell
    {
        public static CanvasCell OccupiedCell = new CanvasCell();
        public static CanvasCell FreeCell = new CanvasCell();

        public int x;
        public int y;
    }
}
