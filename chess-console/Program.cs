using System;
using board;
using Microsoft.VisualBasic.FileIO;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);
            Console.ReadLine();
        }
    }
}