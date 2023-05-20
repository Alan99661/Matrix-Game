using ATOOPS966vt.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop
{
    internal class EndgameChecker : IEndGameChecker
    {
        public EndgameChecker([Named("EndgameValue")] int endGameValue)
        {
            EndGameValue = endGameValue;
        }

        public int EndGameValue { get; set; }

        public bool EndGameCheck(int value)
        {
            if (EndGameValue == value) { return true; }
            return false;
        }
    }
}
