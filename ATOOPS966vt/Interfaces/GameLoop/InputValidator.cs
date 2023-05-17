using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface InputValidator
    {
        public Regex RegexP { get; set; }
        public bool ValidateInput(string input);
    }
}
