using LibraryProject;
using LibraryProject.Pieces;
using static System.Console;

string playGame;

do
{
    string pieceName = EnterPieceName();

    bool isValidPieceName = Enum.TryParse(pieceName, out PieceNames name);
    bool isDefined = Enum.IsDefined(typeof(PieceNames), pieceName);

    if (isDefined && isValidPieceName)
    {
        WriteLine("Please enter color of the piece: ");
        string colorTxt = ReadLine();

        bool isValidColor = Enum.TryParse(colorTxt, out PieceColor color);

        WriteLine("Please enter the starting position of the piece (ex. A1): ");
        string startPos = ReadLine();

        GetCoords(startPos, out byte startX, out byte startY);
        Coords startCoords = new Coords(startX, startY);

        WriteLine("Please enter the final position of the piece (ex. A2): ");
        string finalPos = ReadLine();

        GetCoords(finalPos, out byte finalX, out byte finalY);
        Coords finalCoords = new Coords(finalX, finalY);

        CheckThePieceMovingPossibility(name, color, startCoords, finalCoords);
    }
    else
        Console.WriteLine("You entered an incorrect piece.");

    WriteLine();

    WriteLine("Continue?");
    playGame = ReadLine();

    WriteLine();

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
while (playGame == "Y");

