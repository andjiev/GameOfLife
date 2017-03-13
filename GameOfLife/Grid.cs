using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2GameOfLife
{
    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[Rows][];
            for (int i = 0; i < Rows; ++i)
            {
                Cells[i] = new Cell[Columns];
                for (int j = 0; j < Columns; ++j)
                {
                    Cells[i][j] = new Cell();
                }
            }
        }
        public void ToggleCell(int x, int y, bool isAlive)
        {
            if (isAlive)
                Cells[x][y].IsAlive = true;
            else
                Cells[x][y].IsAlive = false;
        }
        
        public void Evolve()
        {
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    int alive = Find(i, j, Rows, Columns);
                    if (Cells[i][j].IsAlive && alive < 2)
                        Cells[i][j].ShouldLive = false;
                    else if (Cells[i][j].IsAlive && (alive == 2 || alive == 3))
                        Cells[i][j].ShouldLive = true;
                    else if (Cells[i][j].IsAlive && alive > 3)
                        Cells[i][j].ShouldLive = false;
                    else if (!Cells[i][j].IsAlive && alive == 3)
                        Cells[i][j].ShouldLive = true;
                }
            }
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Cells[i][j].IsAlive = Cells[i][j].ShouldLive;
                }
            }
        }
        private int Find(int x, int y, int rows, int columns)
        {            
            int counter = 0;
            int startX = x, startY = y, endX = x, endY = y;
            if (x > 0 ) --startX;
            if (y > 0) --startY;
            if (x < rows-1) ++endX;
            if (y < columns-1) ++endY;
            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++) 
                {
                    if (Cells[i][j].IsAlive)
                        ++counter;
                }
            }
            if (Cells[x][y].IsAlive == true)
                --counter;
            return counter;
        }
    }
}
