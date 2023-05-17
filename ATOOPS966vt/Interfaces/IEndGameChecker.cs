using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces
{
    internal interface IEndGameChecker
    {
        public int EndGameValue { get; set; }
        public bool EndGameCheck(int value);
    }
}
