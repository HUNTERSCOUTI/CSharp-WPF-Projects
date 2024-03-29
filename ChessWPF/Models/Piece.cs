﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessWPF.Models
{
    public abstract class Piece
    {
        public string PieceName { get; set; }
        public bool IsWhite { get; set; }
        public Square CurrentSquare { get; set; }
        public List<Square> PossibleMoves { get; set; }
        public Square[] StartPosistions { get; set; }
        public ImageSource PieceImage { get; set; }

        public Piece() { }
        public Piece(string name, bool isWhite, Square currentSquare, List<Square> possibleMoves)
        {
            PieceName = name;
            IsWhite = isWhite;
            CurrentSquare = currentSquare;
            PossibleMoves = possibleMoves;
        }

        //Make on mouse click

        public List<Square> CalcPossibleMoves()
        {
            List<Square> moves = new()
            {
                new Square(SquareLetter.a, SquareNumber.two)
            };

            return moves;
        }
    }
}
