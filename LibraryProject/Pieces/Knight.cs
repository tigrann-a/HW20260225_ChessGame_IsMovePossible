namespace LibraryProject.Pieces;

public class Knight
{
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.X - start.X);
        int coefficentY = Math.Abs(final.Y - start.Y);

        if ((coefficentX == 2 && coefficentY == 1) || (coefficentX == 1 && coefficentY == 2))
            return true;
        else
            return false;
    }
}

