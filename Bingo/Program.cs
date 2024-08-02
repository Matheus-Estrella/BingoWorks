

using Models;

GameRun GRun = new GameRun();

//

var card = new Card(GRun.Rules);
card.Grid.ShowGrid(GRun.Rules);
//
do
{
    GRun.RunGame(GRun);
} while (GRun.Stats.Wins.WinBingo == false);
