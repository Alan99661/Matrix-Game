using ATOOPS966vt.Interfaces;
using ATOOPS966vt.Interfaces.ConsoleOperations;
using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop
{
    internal class GameLoop : IGameLoop

    {
        readonly IPrinter _printer;
        readonly IGameRound _gameRound;
        readonly IEndGameChecker _endGameCheker;
        readonly IPointCalculator _pointCalculator;

        public GameLoop(IPrinter printer, IGameRound gameRound,IEndGameChecker endGameCheker,IPointCalculator pointCalculator)
        {
            _printer = printer;
            _gameRound = gameRound;
            _endGameCheker = endGameCheker;
            _pointCalculator = pointCalculator;
        }

        public void LoopGame(IPlayer player1, IPlayer player2, IGrid grid)
        {
            _printer.Print($"The grid is {grid.Elements.GetLength(0)} elements long and {grid.Elements.Rank} elements high");
            while (true)
            {
                IElement _el = _gameRound.PlayRound(player1, grid);
                if (_endGameCheker.EndGameCheck(_el.Value))return;
                _pointCalculator.AddPoints(player1,_el.Value);
                IElement _el2 = _gameRound.PlayRound(player2, grid);
                if (_endGameCheker.EndGameCheck(_el2.Value))return;
                _pointCalculator.AddPoints(player2, _el2.Value);

            }
        }
    }
}
