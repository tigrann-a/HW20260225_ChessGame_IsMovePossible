using System.Collections;

namespace LibraryProject.Pieces;

public class Rook
{
    public byte x;
    public byte y;
    public PieceColor color;

    public Rook(){}
    public Rook(Coords position)
    {
        //this.color = color;
        x = position.x;
        y = position.y;
    }
    public Rook(Rook rook)
    {
        color = rook.color;
    }
    public bool IsMovePossible(Coords start, Coords final)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);

        if (coefficentX == 0 || coefficentY == 0)
            return true;
        else
            return false;
    }

    public bool CaptureIsPossible(Rook whiteRook, Rook blackRook)
    {
        int coefficentX = Math.Abs(whiteRook.x - blackRook.x);
        int coefficentY = Math.Abs(whiteRook.y - blackRook.y);
        if (coefficentX == 0 || coefficentY == 0)
            return true;

        else
            return false;
    }
}

