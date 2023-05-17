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
    internal class GameRound : IGameRound
    {
        readonly IInputTaker _inputTaker;
        readonly IElementPicker _elementPicker;
        readonly IConsoleOperations _consoleOperations;
        readonly IPickedChecker _pickedChecker;
        readonly IOutOFBoundsCheck _outOFBoundsCheck;

        public GameRound(IInputTaker inputTaker, IElementPicker elementPicker, IConsoleOperations operations, IPickedChecker pickedChecker, IOutOFBoundsCheck outOFBoundsCheck)
        {
            _inputTaker = inputTaker;
            _elementPicker = elementPicker;
            _consoleOperations = operations;
            _pickedChecker = pickedChecker;
            _outOFBoundsCheck = outOFBoundsCheck;
        }

        public IElement PlayRound(IPlayer player, IGrid grid)
        {
            _consoleOperations.Print($"{player.Name} select element:");
            int[] input = _inputTaker.TakeInputs(_consoleOperations);
            if (_outOFBoundsCheck.OFBCheck(grid, input[0], input[1]))
            {
                _consoleOperations.Print("Element is out of bounds");
                return this.PlayRound(player, grid);
            }
            IElement el = _elementPicker.PickElement(grid, input[0], input[1]);
            if(_pickedChecker.CheckIfPicked(el))
            {
                _consoleOperations.Print("Element Already Picked");
                return this.PlayRound(player,grid);
            }
            _consoleOperations.Print($"You got an {el.Symbol} element with the value of {el.Value}");
            return el;
        }
    }
}
