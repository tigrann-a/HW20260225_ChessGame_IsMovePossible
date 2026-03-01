using static System.Console;
using static System.Net.WebRequestMethods;
using LibraryProject;
using LibraryProject.Pieces;

WriteLine("Please enter coordinates of White Rook: ");
string whiteRookPosTxt = ReadLine();

WriteLine("Please enter coordinates of Black Rook: ");
string  blackRookPosTxt = ReadLine();

void GetCoords(string pos, out byte x, out byte y)
{
    bool isNum = byte.TryParse(pos[1].ToString(), out x);
    x -= 1;

    y = (byte)Enum.Parse<Files>(pos[0].ToString());

    WriteLine($"X: {x}, Y: {y}");
}