using ATOOPS966vt.Implementations.GamePieces;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IGameRound
    {
        public IElement PlayRound(IPlayer player,IGrid grid);
    }
}
