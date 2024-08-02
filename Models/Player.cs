using Models.GameConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player(GameRules GR)
        {
            Cards = new List<Card>();
            Console.Write("\nDigite o seu nome: ");
            Name = Console.ReadLine();
            int numCards = Bingo.Utils.HelpFunctions.AskValue(1, GR.MaxCards, "o número de cartelas do jogador");
            for (int i = 0; i < numCards; i++)
            {
                Cards.Add(new Card(GR));
            }
        }
    }
}
