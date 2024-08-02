using Models.GameConfig;

namespace Models
{
    public class Card
    {
        public Pools Pool { get; set; }
        public WinStatus WinStatus { get; set; }
        public CardGrid Grid { get; set; }

        public Card(GameRules GR)
        {
            Pool = new Pools(GR.RouletteMaxNumber, GR.CardSize*GR.CardSize);
            Grid = new CardGrid(Pool,GR.CardSize);
        }
    }
}
