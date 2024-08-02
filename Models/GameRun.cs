using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.GameConfig;

namespace Models
{
    public class GameRun
    {
        public List<Player> Players { get; set; }
        public GameRules Rules { get; set; }
        public GameStats Stats { get; set; }
        public int LastSorted { get; set; }

        public GameRun()
        {
            Rules = new GameRules();
            Players = SetPlayers(Rules);
            Stats = new GameStats(Rules, Players);
        }

        internal List<Player> SetPlayers(GameRules GR)
        {
            List<Player> Players = new List<Player>();
            for (int i = 0; i < GR.PlayerQuantity; i++)
            {
                Players.Add(new Player(GR));
                Bingo.Utils.HelpFunctions.Jump("prosseguir para o próximo jogador");
            }
            return Players;
        }

        public GameRun RunGame(GameRun GRun)
        {
            GRun = NewTurn(GRun);
            GRun = CheckVictory(GRun);
            return GRun;
        }
        public GameRun NewTurn(GameRun GRun)
        {

            return GRun;
        }
        public GameRun CheckVictory(GameRun GRun)
        {
            bool _bingo = GRun.Stats.Wins.WinBingo;
            var _sortedPools = GRun.Stats.Pools;
            int _size = GRun.Rules.CardSize;
            foreach (var _player in GRun.Players)
            {
                foreach (var _card in _player.Cards)
                {
                    if (_card.Pool.Sorteds.Contains(GRun.LastSorted))
                    {
                        int index = _card.Pool.Sorteds.IndexOf(GRun.LastSorted);
                        _card.Pool.Avaliables[index] = false;
                        _card.Grid = new CardGrid(_card.Pool, GRun.Rules.CardSize);

                        if (GRun.Stats.Wins.WinLine == false)
                        {
                            _card.WinStatus.WinLine = _card.WinStatus.CheckWinLine(_card, _size);
                            if (_card.WinStatus.WinLine == true)
                                GRun.Stats.Wins.WinLine = true;
                        }

                        if (GRun.Stats.Wins.WinColumn == false)
                        {
                            _card.WinStatus.WinColumn = _card.WinStatus.CheckWinColumn(_card, _size);
                            if (_card.WinStatus.WinColumn == true)
                                GRun.Stats.Wins.WinColumn = true;
                        }

                        if (GRun.Stats.Wins.WinBingo == false)
                        {
                            _card.WinStatus.WinBingo = _card.WinStatus.CheckWinBingo(_card, _size);
                            if (_card.WinStatus.WinBingo == true)
                            {
                                GRun.Stats.Wins.WinBingo = true;
                                _bingo = true;
                            }
                        }
                    }
                }
            }
            if (_bingo == true)
                EndGame(GRun);
            return GRun;
        }
        public void EndGame(GameRun GRun)
        {

        }
        public string PlayerName(GameRun GRun)
        {
            int turn = GRun.Stats.turn;
            var _playersNames = new List<string>();

            foreach (var player in GRun.Stats.Players)
            {
                _playersNames.Add(player.Name);
            }
            do
            {
                if (turn > _playersNames.Count)
                    turn -= _playersNames.Count;
            } while(turn <= _playersNames.Count);

            string _currentPlayer = _playersNames[turn];

            return _currentPlayer;
        }
    }
}
