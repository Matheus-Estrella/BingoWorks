using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Utils
{
    public static class HelpFunctions
    {
        public static int AskValue(int min, int max, string txt)
        {
            int num = 0;
            do
            {
                Console.Write($"\n Digite {txt} : ");
                num = int.Parse(Console.ReadLine());
                if((num<min || num == 0 || num>max))
                {
                    Console.WriteLine($"\nInsira um valor correto, entre {min} e {max}\n");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            } while (num<min || num == 0 || num>max);
            return num;
        }

        public static void Jump(string txt)
        {
            if (txt == "")
                txt = "continuar";
            Console.WriteLine($"\n Digite enter para {txt}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
