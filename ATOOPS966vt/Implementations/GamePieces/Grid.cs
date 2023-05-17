using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GamePieces
{
    internal class Grid : IGrid
    {
        public Grid(IElement[,] elements)
        {
            Elements = elements;
        }

        public IElement[,] Elements { get; set; }
    }
}
