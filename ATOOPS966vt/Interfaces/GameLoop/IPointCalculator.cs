using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATOOPS966vt.Interfaces.GamePieces;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IPointCalculator
    {
        public void AddPoints(IPlayer player, int points);
    }
}
