﻿using ChessWPF.Models;
using ChessWPF.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessWPF
{
    public class Game
    {
        public static bool IsRunning = false;

        public static string[,] BoardLayout =
        {
            { "a8", "b8", "c8", "d8", "e8", "f8", "g8", "h8" },
            { "a7", "b7", "c7", "d7", "e7", "f7", "g7", "h7" },
            { "a6", "b6", "c6", "d6", "e6", "f6", "g6", "h6" },
            { "a5", "b5", "c5", "d5", "e5", "f5", "g5", "h5" },
            { "a4", "b4", "c4", "d4", "e4", "f4", "g4", "h4" },
            { "a3", "b3", "c3", "d3", "e3", "f3", "g3", "h3" },
            { "a2", "b2", "c2", "d2", "e2", "f2", "g2", "h2" },
            { "a1", "b1", "c1", "d1", "e1", "f1", "g1", "h1" },
        };

        public Piece[] AlivePieces = AddPieces();

        public static Piece[] AddPieces()
        {
            Piece[] arr = new Piece[32];
            Pawn pawn = new Pawn();

            for(int i = 0; i < 32; i++)
            {
                
                if(i == 15)
                {

                }
            }

            return arr;
        }

        public void Run()
        {
            IsRunning = true;

            //Add Pieces

            while (IsRunning)
            {

            }
        }

    }
}
