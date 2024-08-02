using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GameConfig
{
    public class GameRules
    {
        public int MaxCards { get; set; }
        public int CardSize { get; set; }
        public int RouletteMaxNumber { get; set; }
        public int PlayerQuantity { get; set; }
        public WinScore WinScore { get; set; }

        public GameRules()
        {
            WinScore = new WinScore();
            PlayerQuantity = 1;
            MaxCards = 1;
            CardSize = 5;
            RouletteMaxNumber = 100;
            WinScore.ColumnScore = 1;
            WinScore.LineScore = 1;
            WinScore.BingoScore = 5;

            //WinScore = new WinScore();
            //PlayerQuantity = Bingo.Utils.HelpFunctions.AskValue(1, 10, "o número atual de jogadores");
            //MaxCards = Bingo.Utils.HelpFunctions.AskValue(1, 10, "o número máximo de cartelas por jogador");
            //CardSize = Bingo.Utils.HelpFunctions.AskValue(1, 10, "o tamanho n da cartela (nxn)");
            //RouletteMaxNumber = Bingo.Utils.HelpFunctions.AskValue(1, 150, "o maior valor sorteado pela roleta");
            //Console.WriteLine("\n\n");
            //WinScore.ColumnScore = Bingo.Utils.HelpFunctions.AskValue(1, 100, "a pontuação recebida ao completar uma coluna");
            //WinScore.LineScore = Bingo.Utils.HelpFunctions.AskValue(1, 100, "a pontuação recebida ao completar uma linha");
            //WinScore.BingoScore = Bingo.Utils.HelpFunctions.AskValue(1, 100, "a pontuação recebida ao completar o Bingo");
        }

    }
}
