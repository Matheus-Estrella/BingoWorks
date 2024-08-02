using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GameConfig
{
    public class GameStats
    {
        public int turn { get; set; }
        public Pools Pools { get; set; }
        public WinStatus Wins { get; set; }
        public WinScore Scores { get; set; }
        public List<Player> Players { get; set; }

        public GameStats(GameRules GR, List<Player> _players)
        {
            turn = 0;
            Players = _players;
            Pools = new Pools(GR.RouletteMaxNumber, GR.CardSize*GR.CardSize);
            Scores = GR.WinScore;
            Wins = new WinStatus();
        }
    }
}
