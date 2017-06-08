﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarChess.Domain.ChessAlikeApi.Chess
{
    public class MockBoard : IChessBoard<ChessPiece>
    {
        public int RowCount => 8;
        public int ColumnCount => 8;

        public ChessPiece this[ChessPosition position] => null;
    }
}