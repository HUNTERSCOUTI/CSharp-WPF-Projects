using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWPF.Models
{
    public enum SquareLetter
    {
        a,
        b,
        c,
        d,
        e,
        f,
        g,
        h,
    }
    public enum SquareNumber
    {
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
    }
    public class Square
    {
        public SquareLetter squareLetter { get; set; }
        public SquareNumber squareNumber { get; set; }

        //Make on mouse click
    }
}
