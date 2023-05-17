using ATOOPS966vt.Interfaces.ConsoleOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GridOperations
{
    internal interface IElementsValidator
    {
        public bool Validate(Dictionary<char, int> pairs);
    }
}
