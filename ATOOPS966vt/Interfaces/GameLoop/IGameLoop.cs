using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATOOPS966vt.Interfaces.GamePieces;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IGameLoop
    {
        public void LoopGame(IPlayer player1, IPlayer player2, IGrid grid);
    }
}
