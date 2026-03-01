using static System.Console;
using static System.Net.WebRequestMethods;
using LibraryProject;
using LibraryProject.Pieces;

WriteLine("Please enter coordinates of White Rook: ");
string whiteRookPosTxt = ReadLine();

GetCoords(whiteRookPosTxt, out byte whiteRookX, out byte whiteRookY);
Coords whiteRookPos = new Coords(whiteRookX, whiteRookY);

WriteLine("Please enter coordinates of Black Rook: ");
string  blackRookPosTxt = ReadLine();

GetCoords(blackRookPosTxt, out byte blackRookX, out byte blackRookY);
Coords blackRookPos = new Coords(blackRookX, blackRookY);

void GetCoords(string pos, out byte x, out byte y)
{
    bool isNum = byte.TryParse(pos[1].ToString(), out x);
    x -= 1;

    y = (byte)Enum.Parse<Files>(pos[0].ToString());

    WriteLine($"X: {x}, Y: {y}");
}