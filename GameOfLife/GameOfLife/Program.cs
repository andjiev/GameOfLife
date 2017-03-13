using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab2GameOfLife
{
    class Program
    {
        static readonly int MAX_GENERATIONS = 60;

        static void Main(string[] args)
        {
            Game game = new Maze(Types.Solar, MAX_GENERATIONS);
            while (game.CurrentGeneration <= game.MaxGenerations)
            {
                game.Show();
                game.Evolve();
                Thread.Sleep(300);
            }
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
