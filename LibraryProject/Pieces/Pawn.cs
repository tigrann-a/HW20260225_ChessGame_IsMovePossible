namespace LibraryProject.Pieces;

public class Pawn
{
    public PieceColor color;

    public Pawn(PieceColor color)
    {
        this.color = color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = final.x - start.x;
        int coefficentY = Math.Abs(final.y - start.y);

        if (this.color == PieceColor.White && coefficentY == 0)
        {
            if (coefficentX == 1)
                return true;
            if (start.x == 1 && coefficentX == 2)
                return true;
        }
        if (this.color == PieceColor.Black && coefficentY == 0)
        {
            if (coefficentX == -1)
                return true;
            if (start.x == 6 && coefficentX == -2)
                return true;
        }

        return false;
    }

}

