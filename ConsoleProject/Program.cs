using LibraryProject;
using LibraryProject.Pieces;
using static System.Console;
using LibraryProject.Services;

string playGame;
UserService userService = new UserService();

do
{
    string pieceName = userService.EnterPieceName();

    bool isValidPieceName = Enum.TryParse(pieceName, out PieceNames name);
    bool isDefined = Enum.IsDefined(typeof(PieceNames), pieceName);

    if (isDefined && isValidPieceName)
    {
        WriteLine("Please enter color of the piece: ");
        string colorTxt = ReadLine();

        bool isValidColor = Enum.TryParse(colorTxt, out PieceColor color);

        WriteLine("Please enter the starting position of the piece (ex. A1): ");
        string startPos = ReadLine();

        userService.GetCoords(startPos, out byte startX, out byte startY);
        Coords startCoords = new Coords(startX, startY);

        WriteLine("Please enter the final position of the piece (ex. A2): ");
        string finalPos = ReadLine();

        userService.GetCoords(finalPos, out byte finalX, out byte finalY);
        Coords finalCoords = new Coords(finalX, finalY);

        userService.CheckThePieceMovingPossibility(name, color, startCoords, finalCoords);
    }
    else
        Console.WriteLine("You entered an incorrect piece.");

    WriteLine();

    WriteLine("Continue?");
    playGame = ReadLine();

    WriteLine();
}
while (playGame == "Y");

