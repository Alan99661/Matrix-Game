using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATOOPS966vt.Interfaces.GamePieces;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IElementPicker
    {
        public IElement PickElement(IGrid grid, int x, int y);
    }
}
