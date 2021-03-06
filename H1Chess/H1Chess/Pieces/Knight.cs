﻿using System;
using System.Drawing;
using System.Windows;

namespace H1Chess.Pieces
{
    [Serializable()]
    class Knight : Piece
    {
        public Knight(MoveDirection direction, PieceColor color) : base(direction, color)
        {
            pieceImageBlack = Bitmap.FromFile(@"Images\Pieces\knight_black.png");
            pieceImageWhite = Bitmap.FromFile(@"Images\Pieces\knight_white.png");
        }

        public override string GetRepresentation()
        {
            return "knight";
        }

        public override bool IsValidMove(ChessBoard board, Vector startPosition, Vector endPosition)
        {
            return false;
        }
    }
}