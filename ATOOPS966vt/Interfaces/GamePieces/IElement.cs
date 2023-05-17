using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GamePieces
{
    internal interface IElement
    {
        public char Symbol { get; }
        public int Value { get; }
        public bool Picked { get; set; }
    }
}
