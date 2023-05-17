using ATOOPS966vt.Interfaces.ConsoleOperations;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IInputTaker
    {
        public int[] TakeInputs(IReader reader);
    }
}
