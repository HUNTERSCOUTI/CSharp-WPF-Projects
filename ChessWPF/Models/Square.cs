using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWPF.Models
{
    public enum SquareLetter
    {
        a = 1,
        b = 2,
        c = 3,
        d = 4,
        e = 5,
        f = 6,
        g = 7,
        h = 8,
    }
    public enum SquareNumber
    {
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
    }
    public class Square
    {
        // X Cordinate
        public SquareLetter squareLetter { get; set; }
        // Y Cordinate
        public SquareNumber squareNumber { get; set; }

        public Square(SquareLetter sL, SquareNumber sN)
        {
            squareLetter = sL;
            squareNumber = sN;
        }

        //Make on mouse click

        
    }

    
}
