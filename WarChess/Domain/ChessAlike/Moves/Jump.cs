﻿using System;
using WarChess.Domain.AbstractGame;
using WarChess.Domain.GridGame2D;

namespace WarChess.Domain.ChessAlike.Moves
{
    public class Jump<TGameState, TCell> : DirectedMove<TGameState, TCell>
        where TGameState : ChessAlikeGameState<TCell>
        where TCell : ICell
    {
        public Jump(Point2D step, Point2D from, Point2D to) : base(step, from, to)
        {
        }

        public override TGameState Make(TGameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}