using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations
{
    internal class DetermineWinner : IDetermineWinner
    {
        IPlayer IDetermineWinner.DetermineWinner(IPlayer player1, IPlayer player2)
        {
            if(player1.Points >= player2.Points) {return player1;} else { return player2;}
        }
    }
}
