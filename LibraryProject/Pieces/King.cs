using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Pieces
{
    public class King
    {
        public bool IsMovePossible(Coords start, Coords final)
        {
            Console.WriteLine($"Start X: {start.X}, Start Y: {start.Y}");
            Console.WriteLine($"Final X: {final.X}, Final Y: {final.Y}");
            int coefficentX = Math.Abs(final.X - start.X);
            int coefficentY = Math.Abs(final.Y - start.Y);
            Console.WriteLine($"{coefficentX}");
            Console.WriteLine($"{coefficentY}");
            

            if (coefficentX <= 1 && coefficentY <= 1 && (coefficentX + coefficentY != 0))
                return true;
            else
                return false;
        }
    }
}
