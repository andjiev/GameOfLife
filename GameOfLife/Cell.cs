using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2GameOfLife
{
    class Cell
    {
        public bool IsAlive { get; set; }
        public bool ShouldLive { get; set; }

        public Cell()
        {
            IsAlive = false;
            ShouldLive = false;
        }
        public override string ToString()
        {
            if (IsAlive)
                return "X";
            else
                return "_";
        }
    }
}
