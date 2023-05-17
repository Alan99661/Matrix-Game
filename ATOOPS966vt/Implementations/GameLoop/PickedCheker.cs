using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop
{
    internal class PickedCheker : IPickedChecker
    {
        public bool CheckIfPicked(IElement element)
        {
            if (element.Picked)
            {
                return true;
            }
            element.Picked = true;
            return false;
        }
    }
}
