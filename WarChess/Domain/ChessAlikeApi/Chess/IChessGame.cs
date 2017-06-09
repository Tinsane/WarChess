﻿using WarChess.Domain.Chess.Pieces;

namespace WarChess.Domain.ChessAlikeApi.Chess
{
    public interface IChessGame : IChessAlikeGame<ChessPiece>
    {
        bool IsCheck { get; }
    }
}