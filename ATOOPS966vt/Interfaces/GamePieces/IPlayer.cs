﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Interfaces.GamePieces
{
    internal interface IPlayer
    {
        public string Name { get; set; }
        public int Points { get; set; }
    }
}
