using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATOOPS966vt.Interfaces.GamePieces;

namespace ATOOPS966vt.Interfaces.GridOperations
{
    internal interface IGridGenerator
    {
        public IGrid Generate(int x, int y, Dictionary<char, int> pairs, IElementsValidator validator);
    }
}
