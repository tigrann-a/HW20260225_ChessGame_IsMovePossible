namespace LibraryProject.Pieces;

public class Rook
{
    public PieceColor color;
    public Rook(PieceColor color)
    {
        this.color = color;
    }
    public Rook(Bishop bishop)
    {
        color = bishop.color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if (coefficentX == 0 || coefficentY == 0)
            return true;
        else
            return false;
        ;
    }
}

