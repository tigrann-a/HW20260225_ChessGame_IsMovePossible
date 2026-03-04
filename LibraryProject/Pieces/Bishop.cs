namespace LibraryProject.Pieces;

public class Bishop
{

    public Coords coord;
    public PieceColor color;

    // Parameterized constructor
    public Bishop(PieceColor color)
    {
        this.color = color;
    }
    public Bishop(Coords position)
    {
        //this.color = color;
        coord.x = position.x;
        coord.y = position.y;
    }
    // Copy constructor
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
