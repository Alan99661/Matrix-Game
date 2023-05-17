using ATOOPS966vt.Interfaces.GameLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop.PickingElement
{
    internal class RegexInputValidator : InputValidator
    {
        public RegexInputValidator(Regex regex)
        {
            RegexP = regex;
        }

        public Regex RegexP { get; set; }

        public bool ValidateInput(string input)
        {
            if (RegexP.IsMatch(input)) return true;
            return false;
        }
    }
}
