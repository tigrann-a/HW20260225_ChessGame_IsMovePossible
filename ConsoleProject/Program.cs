using LibraryProject;
using LibraryProject.Pieces;
using static System.Console;

string playGame;

do
{ 
    WriteLine("Please enter the name of the piece (ex. King): ");
    string pieceNameTxt = ReadLine();

    bool isValidPieceName = Enum.TryParse(pieceNameTxt, out PieceNames name);
    bool isDefined = Enum.IsDefined(typeof(PieceNames),  pieceNameTxt);

    if (isDefined && isValidPieceName)
    {
        WriteLine("Please enter the starting position of the piece (ex. A1): ");
        string startPos = ReadLine();

        GetCoords(startPos, out int startX, out int startY);
        Coords startCoords = new Coords(startX, startY);

        WriteLine("Please enter the final position of the piece (ex. A2): ");
        string finalPos = ReadLine();

        GetCoords(finalPos, out int finalX, out int finalY);
        Coords finalCoords = new Coords(finalX, finalY);

        bool movingStatus = false;

        switch (name)
        {
            case PieceNames.King:
                King king = new King();
                movingStatus = king.IsMovePossible(startCoords, finalCoords);
                break;
            case PieceNames.Queen:
                Queen queen = new Queen();
                movingStatus = queen.IsMovePossible(startCoords, finalCoords);
                break;
            case PieceNames.Rook:
                Rook rook = new Rook();
                movingStatus = rook.IsMovePossible(startCoords, finalCoords);
                break;
            case PieceNames.Knight:
                Knight knight = new Knight();
                movingStatus = knight.IsMovePossible(startCoords, finalCoords);
                break;
            case PieceNames.Bishop:
                Bishop bishop = new Bishop();
                movingStatus = bishop.IsMovePossible(startCoords, finalCoords);
                break;
            case PieceNames.Pawn:
                ChekPawnMovingStatusByColor(movingStatus, startCoords, finalCoords);
                break;
            default:
                Console.WriteLine("The piece you selected does not exist.");
                break;
        }

        CheckMovingStatus(movingStatus);
    }
    else
        Console.WriteLine("You entered an incorrect piece.");

    WriteLine();

    WriteLine("Continue?");
    playGame = ReadLine();

    WriteLine();

    void GetCoords(string pos, out int x, out int y)
    {
        bool isNum = int.TryParse(pos[1].ToString(), out x);
        x -= 1;

        y = (int)Enum.Parse<Files>(pos[0].ToString());

        WriteLine($"X: {x}, Y: {y}");
    }

    void CheckMovingStatus(bool status)
    {
        if (status)
            WriteLine($"Yes {name} can move to the final position");
        else
            WriteLine($"No {name} can\'t move to the final position");
    }

    void ChekPawnMovingStatusByColor(bool canMove, Coords start, Coords final)
    {
        WriteLine("Please enter color of selected Pawn: ");
        string colorTxt = ReadLine();
        bool isValidColor = Enum.TryParse(colorTxt, out PieceColor color);
        Pawn pawn = new Pawn(color);
        canMove = pawn.IsMovePossible(start, final);
    }
}
while (playGame == "Y");


