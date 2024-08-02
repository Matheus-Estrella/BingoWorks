using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GameConfig
{
    public class WinStatus
    {
        public bool WinLine { get; set; }
        public bool WinColumn { get; set; }
        public bool WinBingo { get; set; }

        public WinStatus()
        {
            WinLine=false;
            WinColumn=false;
            WinBingo=false;
        }

        public bool CheckWinLine(Card card, int size)
        {
            var _grid = card.Grid;
            bool _winLine = false;
            for (int Line = 0; Line<size; Line++)
            {
                for (int Column = 0; Column<size; Column++)
                {
                    if (_grid.GridStats[Line,Column] == false) // Se for falso, foi sorteado
                    {
                        _winLine = true;
                    }
                    else
                    {
                        _winLine = false;
                    }
                }
                if (_winLine == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckWinColumn(Card card, int size)
        {
            var _grid = card.Grid;
            bool _winColumn = false;
            for (int Column = 0; Column<size; Column++)
            {
                for (int Line = 0; Line<size; Line++)
                {
                    if (_grid.GridStats[Column,Line] == false) // Se for falso, foi sorteado
                    {
                        _winColumn = true;
                    }
                    else
                    {
                        _winColumn = false;
                    }
                }
                if (_winColumn == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckWinBingo(Card card, int size)
        {
            var _grid = card.Grid;
            bool _winBingo = false;
            for (int Column = 0; Column<size; Column++)
            {
                for (int Line = 0; Line<size; Line++)
                {
                    if (_grid.GridStats[Column, Line] == false) // Se for falso, foi sorteado
                    {
                        _winBingo = true;
                    }
                    else
                    {
                        _winBingo = false;
                        break;
                    }
                }
            }
            if (_winBingo == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
