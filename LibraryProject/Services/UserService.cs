using LibraryProject.Pieces;
using static System.Console;
using LibraryProject.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LibraryProject.Services
{
    public class UserService
    {
        public string EnterPieceName()
        {
            WriteLine("Please enter the name of the piece (ex. King): ");
            string? pieceNameTxt = ReadLine();
            return pieceNameTxt;
        }

        public void GetCoords(string pos, out byte x, out byte y)
        {
            bool isNum = byte.TryParse(pos[1].ToString(), out x);
            x -= 1;

            y = (byte)Enum.Parse<Files>(pos[0].ToString());

            WriteLine($"X: {x}, Y: {y}");
        }

        public void CheckMovingStatus(PieceNames name, bool status)
        {
            if (status)
                WriteLine($"Yes {name} can move to the final position");
            else
                WriteLine($"No {name} can\'t move to the final position");
        }

        public void CheckThePieceMovingPossibility(PieceNames name, PieceColor color, Coords start, Coords final)
        {
            bool movingStatus = false;

            switch (name)
            {
                case PieceNames.King:
                    King king = new King(color);
                    movingStatus = king.IsMovePossible(start, final);
                    break;
                case PieceNames.Queen:
                    Queen queen = new Queen(color);
                    movingStatus = queen.IsMovePossible(start, final);
                    break;
                case PieceNames.Rook:
                    //Rook rook = new Rook(color);
                    //movingStatus = rook.IsMovePossible(start, final);
                    //break;
                case PieceNames.Knight:
                    Knight knight = new Knight(color);
                    movingStatus = knight.IsMovePossible(start, final);
                    break;
                case PieceNames.Bishop:
                    Bishop bishop = new Bishop(color);
                    movingStatus = bishop.IsMovePossible(start, final);
                    break;
                case PieceNames.Pawn:
                    Pawn pawn = new Pawn(color);
                    movingStatus = pawn.IsMovePossible(start, final);
                    break;
                default:
                    Console.WriteLine("The piece you selected does not exist.");
                    break;
            }

            CheckMovingStatus(name, movingStatus);
        }

        public void PrintCapturePossibilityMsg(bool status)
        {
            if(status)
                Console.WriteLine("Yes Rook can capture each other");
            else
                Console.WriteLine("No Rook can capture each other");
        }
    }
}
