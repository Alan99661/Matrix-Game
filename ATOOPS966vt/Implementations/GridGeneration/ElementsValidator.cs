using ATOOPS966vt.Interfaces;
using ATOOPS966vt.Interfaces.ConsoleOperations;
using ATOOPS966vt.Interfaces.GridOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GridGeneration
{
    internal class ElementsValidator : IElementsValidator
    {
        readonly IPrinter Printer;

        public ElementsValidator(IPrinter printer)
        {
            Printer = printer;
        }

        public bool Validate(Dictionary<char, int> pairs)
        {
            if (pairs == null) { Printer.Print("Please input elements."); return false; }
            if (pairs.Count < 3) { Printer.Print("Not enough elements."); return false; }
            if (!pairs.Values.Contains(0)) { Printer.Print("There needs to be an \"End game\" element."); return false; }
            return true;
        }
    }
}
