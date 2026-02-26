namespace LibraryProject.Pieces;

public class Queen
{
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.X - start.X);
        int coefficentY = Math.Abs(final.Y - start.Y);

        if (coefficentX == 0 || coefficentY == 0 || coefficentX == coefficentY)
            return true;
        else
            return false;
        ;
    }
}

