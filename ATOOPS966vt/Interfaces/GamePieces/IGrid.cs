using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GamePieces
{
    internal interface IGrid
    {
        public IElement[,] Elements { get; }
    }
}
