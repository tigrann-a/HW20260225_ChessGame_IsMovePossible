namespace LibraryProject.Pieces;

public class Bishop
{
    public PieceColor color;
    public Bishop(PieceColor color)
    {
        this.color = color;
    }

    public Bishop(Bishop bishop)
    {
        color = bishop.color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);
        if (coefficentX == coefficentY)
            return true;
        else
            return false;
    }
}
