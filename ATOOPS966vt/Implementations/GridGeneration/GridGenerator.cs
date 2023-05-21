using ATOOPS966vt.Implementations.GamePieces;
using ATOOPS966vt.Interfaces;
using ATOOPS966vt.Interfaces.ConsoleOperations;
using ATOOPS966vt.Interfaces.GamePieces;
using ATOOPS966vt.Interfaces.GridOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GridGeneration
{
    internal class GridGenerator : IGridGenerator
    {

        public IGrid Generate(int x, int y, Dictionary<char, int> elements, IElementsValidator validator)
        {
            if (!validator.Validate(elements)) throw new ArgumentException("Emements are not valid");

            Random random = new Random();
            IElement[,] _grid = new IElement[x, y];
            List<char> _keys = new List<char>(elements.Keys);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    char _key = _keys[random.Next(_keys.Count)];
                    _grid[i, j] = new Element(_key, elements[_key]);
                }
            }
            return new Grid(_grid);
        }
    }
}
