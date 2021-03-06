﻿using System;
using System.Collections.Generic;
using System.Linq;
using WarChess.Domain.Chess.Moves;
using WarChess.Domain.Chess.Moves.Castling;
using WarChess.Domain.GridGame2D;

namespace WarChess.Domain.Chess.Pieces
{
    public class King : ChessPiece
    {
        public King(int playerId, bool wasMoved) : base(playerId) { WasMoved = wasMoved; }

        public bool WasMoved { get; }

        public override void AcceptVisitor(IChessPieceVisitor visitor) { visitor.Visit(this); }

        public override IEnumerable<Func<GridPosition2D, GridPosition2D, IChessMove>> GetPossibleMoves()
        {
            var steps = new List<Point2D>();
            for (var dx = -1; dx <= 1; ++dx)
            for (var dy = -1; dy <= 1; ++dy)
                if (dx != 0 || dy != 0)
                    steps.Add(new Point2D(dx, dy));
            yield return (from, to) => new ShortCastling(from, to);
            yield return (from, to) => new LongCastling(from, to);
            foreach (var e in steps
                .Select<Point2D, Func<GridPosition2D, GridPosition2D, IChessMove>>(
                    step => ((from, to) => new KingMove(step, from, to))))
                yield return e;
        }
    }
}