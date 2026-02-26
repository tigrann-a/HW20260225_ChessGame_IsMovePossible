namespace LibraryProject.Pieces;

public class Pawn
{
    public PieceColor Color;

    public Pawn(PieceColor color)
    {
        Color = color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = final.X - start.X;
        int coefficentY = Math.Abs(final.Y - start.Y);

        if (Color == PieceColor.White && coefficentY == 0)
        {
            if (coefficentX == 1)
                return true;
            if (start.X == 1 && coefficentX == 2)
                return true;
        }
        if (Color == PieceColor.Black && coefficentY == 0)
        {
            if (coefficentX == -1)
                return true;
            if (start.X == 6 && coefficentX == -2)
                return true;
        }

        return false;
    }

}

