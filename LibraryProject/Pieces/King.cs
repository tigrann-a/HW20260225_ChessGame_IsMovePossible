namespace LibraryProject.Pieces;

public class King
{
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.X - start.X);
        int coefficentY = Math.Abs(final.Y - start.Y);

        if (coefficentX <= 1 && coefficentY <= 1 && (coefficentX + coefficentY != 0))
            return true;
        else
            return false;
    }
}

