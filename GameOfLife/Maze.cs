using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2GameOfLife
{
    enum Types 
    {
        Solar,
        Metal,
        Hard       
    }
    class Maze : Game
    {
        public Types Type { get; set; }

        public Maze(Types gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (Type == Types.Solar)
            {
                grid = new Grid(15, 16);
                grid.ToggleCell(5, 6, true);
                grid.ToggleCell(5, 7, true);
                grid.ToggleCell(5, 8, true);
                grid.ToggleCell(7, 7, true);
                grid.ToggleCell(9, 6, true);
                grid.ToggleCell(9, 7, true);
                grid.ToggleCell(9, 8, true);
            }
        }
        public override void Show()
        {
            Console.Title = String.Format("Maze Game: {0}", Type);
            base.Show();
        }
    }
}
