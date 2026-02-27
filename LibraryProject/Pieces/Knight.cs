namespace LibraryProject.Pieces;

public class Knight
{
    public PieceColor color;
    public Knight(PieceColor color)
    {
        this.color = color;
    }

    public Knight(Bishop bishop)
    {
        color = bishop.color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if ((coefficentX == 2 && coefficentY == 1) || (coefficentX == 1 && coefficentY == 2))
            return true;
        else
            return false;
    }
}

