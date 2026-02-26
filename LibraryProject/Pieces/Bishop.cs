namespace LibraryProject.Pieces;

public class Bishop
{
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.X - start.X);
        int coefficentY = Math.Abs(final.Y - start.Y);
        if (coefficentX == coefficentY)
            return true;
        else
            return false;
    }
}
