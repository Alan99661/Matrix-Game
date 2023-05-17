using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop
{
    internal class PointCalculator : IPointCalculator
    {
        public void AddPoints(IPlayer player, int points)
        {
            player.Points += points;
        }
    }
}
