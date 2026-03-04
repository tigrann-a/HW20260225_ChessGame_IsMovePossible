using System.Collections;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Services
{
    public class UserServices
    {
        string EnterPieceName()
        {
            WriteLine("Please enter the name of the piece (ex. King): ");
            string? pieceNameTxt = ReadLine();
            return pieceNameTxt;
        }

        void GetCoords(string pos, out byte x, out byte y)
        {
            bool isNum = byte.TryParse(pos[1].ToString(), out x);
            x -= 1;

            y = (byte)Enum.Parse<Files>(pos[0].ToString());

            WriteLine($"X: {x}, Y: {y}");
        }

        void CheckMovingStatus(bool status)
        {
            if (status)
                WriteLine($"Yes {name} can move to the final position");
            else
                WriteLine($"No {name} can\'t move to the final position");
        }

        void CheckThePieceMovingPossibility(PieceNames name, PieceColor color, Coords start, Coords final)
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
                    Rook rook = new Rook(color);
                    movingStatus = rook.IsMovePossible(start, final);
                    break;
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

            CheckMovingStatus(movingStatus);
        }
    }
}
