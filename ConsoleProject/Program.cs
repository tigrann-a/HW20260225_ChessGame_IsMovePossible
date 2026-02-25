using LibraryProject;
using LibraryProject.Pieces;
using System.Collections;
using System.Drawing;
using System.Net.NetworkInformation;
using static System.Console;

string playGame;

do
{ 
    WriteLine("Please enter the name of the piece (ex. King): ");
    string pieceName = ReadLine();

    WriteLine("Please enter the starting position of the piece (ex. A1): ");
    string startPos = ReadLine();

    GetCoords(startPos, out int startX, out int startY);
    Coords startCoords = new Coords(startX, startY);

    Console.WriteLine("Please enter the final position of the piece (ex. A2): ");
    string finalPos = ReadLine();

    GetCoords(finalPos, out int finalX, out int finalY);
    Coords finalCoords = new Coords(finalX, finalY);

    bool movingStatus = false;

    switch (pieceName)
    {
        case "King":
            King king = new King();
            movingStatus = king.IsMovePossible(startCoords, finalCoords);
            break;
        case "Queen":
            Queen queen = new Queen();
            movingStatus = queen.IsMovePossible(startCoords, finalCoords);
            break;
        case "Rook":
            Rook rook = new Rook();
            movingStatus = rook.IsMovePossible(startCoords, finalCoords);
            break;
        case "Knight":
            Knight knight = new Knight();
            movingStatus = knight.IsMovePossible(startCoords, finalCoords);
            break;
        case "Bishop":
            Bishop bishop = new Bishop();
            movingStatus = bishop.IsMovePossible(startCoords, finalCoords);
            break;
        case "Pawn":
            ChekPawnMovingStatusByColor();
            break;
        default:
            break;
    }

    CheckMovingStatus(movingStatus);

    WriteLine();

    WriteLine("Continue?");
    playGame = ReadLine();

    WriteLine();

    void GetCoords(string pos, out int x, out int y)
    {
        bool isNum = int.TryParse(pos[1].ToString(), out x);
        x -= 1;

        y = (int)Enum.Parse<Board.Files>(pos[0].ToString());

        WriteLine($"X: {x}, Y: {y}");
    }

    void CheckMovingStatus(bool status)
    {
        if (status)
            WriteLine($"Yes {pieceName} can move to the final position");
        else
            WriteLine($"No {pieceName} can\'t move to the final position");
    }

    void ChekPawnMovingStatusByColor()
    {
        WriteLine("Please enter color of selected Pawn: ");
        string color = ReadLine();
        Pawn pawn = new Pawn(color);
        movingStatus = pawn.IsMovePossible(startCoords, finalCoords);
    }
}
while (playGame == "Y");


