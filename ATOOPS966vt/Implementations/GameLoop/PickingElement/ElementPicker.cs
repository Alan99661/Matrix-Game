using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop.PickingElement
{
    internal class ElementPicker : IElementPicker
    {
        public IElement PickElement(IGrid grid, int x, int y) => grid.Elements[x, y];
    }
}
