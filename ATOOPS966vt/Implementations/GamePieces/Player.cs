using ATOOPS966vt.Interfaces.GamePieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations.GamePieces
{
    internal class Player : IPlayer
    {
        public Player(string name)
        {
            Name = name;
            Points = 0;
        }

        public string Name { get ; set; }
        public int Points { get; set; }
    }
}
