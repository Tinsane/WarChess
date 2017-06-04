﻿using System;
using WarChess.Domain.AbstractGame;

namespace WarChess.Domain.GridGame2D
{
    public class BoundedGridField2D : IField<GridPosition2D, SquareCell2D>
    {
        public BoundedGridField2D(int rowsCnt, int columnsCnt)
        {
            Grid = new SquareCell2D[rowsCnt, columnsCnt];
        }

        private SquareCell2D[,] Grid { get; }

        public SquareCell2D this[GridPosition2D position]
        {
            get
            {
                if (!Utilities.IsInInterval(position.X, 0, Grid.GetLength(0)) ||
                    !Utilities.IsInInterval(position.Y, 0, Grid.GetLength(1)))
                    throw new ArgumentOutOfRangeException(nameof(position));
                return Grid[position.X, position.Y];
            }
        }

        public Size2D Size => new Size2D(Grid.GetLength(0), Grid.GetLength(1));
    }
}