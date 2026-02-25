using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Pieces
{
    public class Rook
    {
        public bool IsMovePossible(Coords start, Coords final)
        {
            int coefficentX = Math.Abs(final.X - start.X);
            int coefficentY = Math.Abs(final.Y - start.Y);

            if (coefficentX == 0 || coefficentY == 0)
                return true;
            else
                return false;
            ;
        }
    }
}
