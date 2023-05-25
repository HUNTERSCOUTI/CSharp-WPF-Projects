using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessWPF.Models
{
    public class Piece
    {
        public string PieceName { get; set; }
        public bool IsWhite { get; set; }
        public Square CurrentSquare { get; set; }
        public Square[] PossibleMoves { get; set; }
        public Image PieceImage { get; set; }

        public Piece() { }
        public Piece(string name, bool isWhite, Square currentSquare, Square[] possibleMoves, Image image)
        {
            PieceName = name;
            IsWhite = isWhite;
            CurrentSquare = currentSquare;
            PossibleMoves = possibleMoves;
            PieceImage = image;
        }

        //Make on mouse click

    }
}
