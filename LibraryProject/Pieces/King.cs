namespace LibraryProject.Pieces;

public class King
{
    public PieceColor color;

    // Parameterized constructor
    public King(PieceColor color)
    {
        this.color = color;
    }

    // Copy cosntructor
    public King(Bishop bishop)
    {
        color = bishop.color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if (coefficentX <= 1 && coefficentY <= 1 && (coefficentX + coefficentY != 0))
            return true;
        else
            return false;
    }
}

