using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop
{
    internal class OutOFBoundsCheck : IOutOFBoundsCheck
    {
        public bool OFBCheck(IGrid grid, int x, int y)
        {
            if (x > grid.Elements.GetLength(0) || y > grid.Elements.Rank) return true;
            return false;
        }
    }
}
