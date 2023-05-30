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
                PieceImage = new BitmapImage(new Uri("/Images/Pieces/WhitePawn.png"));
            }
            else
            {
                PieceImage = new BitmapImage(new Uri("/Images/Pieces/BlackPawn.png"));
            }
            if (IsWhite)
            {
                StartPosistions = new Square[]
                {
                    new Square { squareLetter = SquareLetter.a, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.b, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.c, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.d, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.e, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.f, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.g, squareNumber = SquareNumber.two },
                    new Square { squareLetter = SquareLetter.h, squareNumber = SquareNumber.two },
                };
            } else
            {
                StartPosistions = new Square[]
                {
                    new Square { squareLetter = SquareLetter.a, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.b, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.c, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.d, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.e, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.f, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.g, squareNumber = SquareNumber.seven },
                    new Square { squareLetter = SquareLetter.h, squareNumber = SquareNumber.seven },
                };
            }


    }
}
