namespace LibraryProject.Pieces;

public class Queen
{
    public PieceColor color;
    public Queen(PieceColor color)
    {
        this.color = color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if (coefficentX == 0 || coefficentY == 0 || coefficentX == coefficentY)
            return true;
        else
            return false;
        ;
    }
}

