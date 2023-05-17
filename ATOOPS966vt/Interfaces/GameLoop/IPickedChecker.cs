using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IPickedChecker
    {
        public bool CheckIfPicked(IElement element);
    }
}
