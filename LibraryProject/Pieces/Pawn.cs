using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LibraryProject.Pieces
{
    public class Pawn
    {
        public string color;

        public Pawn(string pieceColor)
        {
            color = pieceColor;
        }
        public bool IsMovePossible(Coords start, Coords final)
        {
            int coefficentX = Math.Abs(final.X - start.X);
            int coefficentY = Math.Abs(final.Y - start.Y);

            if (color == "White")
            {
                if (start.X == 1 && coefficentX == 1 || coefficentX == 2)
                    return true;
                else if(coefficentX == 1)
                    return true;
            }
            if (color == "Black")
            {
                if (start.X == 7 && coefficentX == -1 || coefficentX == -2)
                    return true;
                else if (coefficentX == -1)
                    return true;
            }
            return false;
        }

    }
}
