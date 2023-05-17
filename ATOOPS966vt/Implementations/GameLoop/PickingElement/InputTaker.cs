using ATOOPS966vt.Interfaces.ConsoleOperations;
using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GameLoop.PickingElement
{
    internal class InputTaker : IInputTaker
    {
        readonly InputValidator _validator;
        public InputTaker(InputValidator validator)
        {
            _validator = validator;
        }

        public int[] TakeInputs(IReader reader)
        {
            string input = reader.ReadLine();
            if (!_validator.ValidateInput(input))
            {
                return this.TakeInputs(reader);
            }
            string[] values = input.Split(' ');
            int value1 = int.Parse(values[0]);
            int value2 = int.Parse(values[1]);
            return new int[] { value1, value2 };
        }
    }
}
