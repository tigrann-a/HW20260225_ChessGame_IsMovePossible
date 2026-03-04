using System.Collections;

namespace LibraryProject.Pieces;

public class Rook
{
    public Coords coord;

    public PieceColor color;

    public Rook(){}
    public Rook(Coords position)
    {
        //this.color = color;
        coord.x = position.x;
        coord.y = position.y;
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

    public bool IsMovePossible1(Coords start, Coords final, Coords other)
    {
        int coefficentX = Math.Abs(final.x - start.x);
        int coefficentY = Math.Abs(final.y - start.y);
        int coefficentOtherX = Math.Abs(other.x - final.x);
        int coefficentOtherY = Math.Abs(other.y - final.y);

        if (coefficentX == 0 || coefficentY == 0)
        {
            if((coefficentOtherX == 0 && (other.x > start.x && other.x < final.x))
                || (coefficentOtherY == 0 && (other.y > start.y && other.y < final.y)) )
            {
                return false;
            }
        }

        return true;
        
    }

    public bool CaptureIsPossible(Coords whiteRook, Coords blackRook)
    {
        int coefficentX = Math.Abs(whiteRook.x - blackRook.x);
        int coefficentY = Math.Abs(whiteRook.y - blackRook.y);
        if (coefficentX == 0 || coefficentY == 0)
            return true;

        else
            return false;
    }
}

