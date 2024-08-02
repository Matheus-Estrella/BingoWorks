using Models.GameConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CardGrid
    {
        public int[,] GridNum { get; set; }
        public bool[,] GridStats { get; set; }

        public CardGrid(Pools pool, int size)
        {
            GridNum = new int[size, size];
            GridStats = new bool[size, size];

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    GridNum[i, j] = pool.Sorteds[count];
                    GridStats[i, j] = pool.Avaliables[count];
                    count++;
                }
            }
        }
        public void ShowGrid(GameRules GR)
        {
            bool _sorted = false;
            int size = GR.CardSize;
            for (int i = 0; i < size; i++)
            {
                for(int nl = 0; nl < size; nl++)
                {
                    Console.Write("______");
                    if(nl == size - 1)
                    {
                        Console.WriteLine("_\n");
                    }
                }
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"| ");
                    if (_sorted == true)
                        Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write($"{GridNum[i, j]:000}");
                    Console.Write(" ");
                    if (_sorted == true)
                        Console.ResetColor();
                    if (j == size- 1)
                    {
                        Console.Write("|\n");
                    }
                }
                if(i == size-1)
                {
                    for (int nl = 0; nl < size; nl++)
                    {
                        Console.Write("______");
                    }
                    Console.WriteLine("_");
                }
            }
            Bingo.Utils.HelpFunctions.Jump("mostrar a próxima cartela");

        }
    }
}
