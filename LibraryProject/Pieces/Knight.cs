namespace LibraryProject.Pieces;

public class Knight
{
    public Coords coord;
    public PieceColor color;
    public Knight(PieceColor color)
    {
        this.color = color;
    }

    public Knight(Coords position)
    {
        //this.color = color;
        coord.x = position.x;
        coord.y = position.y;
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

