using ChessWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace ChessWPF.Pieces
{
    public class Pawn : Piece
    {
        public Pawn()
        {
            PieceName = "Pawn";
            if (IsWhite)
            {
                PieceImage = new BitmapImage(new Uri("/Images/Pieces/WhitePawn.png", UriKind.Relative));
            }
            else
            {
                PieceImage = new BitmapImage(new Uri("/Images/Pieces/BlackPawn.png", UriKind.Relative));
            }
            if (IsWhite)
            {
                StartPosistions = new Square[]
                {
                    new Square(SquareLetter.a, SquareNumber.two),
                    new Square(SquareLetter.b, SquareNumber.two),
                    new Square(SquareLetter.c, SquareNumber.two),
                    new Square(SquareLetter.d, SquareNumber.two),
                    new Square(SquareLetter.e, SquareNumber.two),
                    new Square(SquareLetter.f, SquareNumber.two),
                    new Square(SquareLetter.g, SquareNumber.two),
                    new Square(SquareLetter.h, SquareNumber.two),
                };
            }
            else
            {
                StartPosistions = new Square[]
                {
                    new Square(SquareLetter.a, SquareNumber.seven),
                    new Square(SquareLetter.b, SquareNumber.seven),
                    new Square(SquareLetter.c, SquareNumber.seven),
                    new Square(SquareLetter.d, SquareNumber.seven),
                    new Square(SquareLetter.e, SquareNumber.seven),
                    new Square(SquareLetter.f, SquareNumber.seven),
                    new Square(SquareLetter.g, SquareNumber.seven),
                    new Square(SquareLetter.h, SquareNumber.seven),
                };
            }
        }

    }
}
