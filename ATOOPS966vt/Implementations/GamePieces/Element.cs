using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GamePieces
{
    internal class Element : IElement
    {
        public Element(char symbol, int value)
        {
            Symbol = symbol;
            Value = value;
            Picked = false;
        }

        public char Symbol { get; set; }

        public int Value { get; set; }

        public bool Picked { get; set; }
    }
}
