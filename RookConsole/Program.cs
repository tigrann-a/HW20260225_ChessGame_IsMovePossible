using LibraryProject;
using LibraryProject.Pieces;
using LibraryProject.Services;
using static System.Console;

UserService userService = new UserService();
//WriteLine("Please enter color of selected rook: ");
//string color1 = Console.ReadLine();

//bool isValidColor1 = Enum.TryParse(color1, out PieceColor firstColor);

WriteLine("Please enter coordinates of White Rook: ");
string? whiteRookPosTxt = ReadLine();

userService.GetCoords(whiteRookPosTxt, out byte whiteRookX, out byte whiteRookY);
Coords whiteRookPos = new Coords(whiteRookX, whiteRookY);

//WriteLine("Please enter color of selected rook: ");
//string color2 = Console.ReadLine();

//bool isValidColor2 = Enum.TryParse(color2, out PieceColor secondColor);

WriteLine("Please enter coordinates of Black Rook: ");
string? blackRookPosTxt = ReadLine();

userService.GetCoords(blackRookPosTxt, out byte blackRookX, out byte blackRookY);
Coords blackRookPos = new Coords(blackRookX, blackRookY);

WriteLine("Please enther other piece coordinates: ");
string? otherPiecePosTxt = ReadLine();

userService.GetCoords(otherPiecePosTxt, out byte otherPieceX, out byte otherPieceY);
Coords otherPiecePos = new Coords(otherPieceX, otherPieceY);

Rook rook = new Rook(whiteRookPos);
//Rook rook2 = new Rook(blackRookPos);

bool isCapturePossible = rook.CaptureIsPossible(whiteRookPos, blackRookPos);
//bool isCapturePossible1 = rook.IsMovePossible1(whiteRookPos, blackRookPos, otherPiecePos);

userService.PrintCapturePossibilityMsg(isCapturePossible);
//userService.PrintCapturePossibilityMsg(isCapturePossible1);

