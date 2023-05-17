using ATOOPS966vt.Interfaces.ConsoleOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOOPS966vt.Implementations
{
    public class ConsoleOperations : IConsoleOperations
    {
        //private static readonly ConsoleOperations instance = new ConsoleOperations();

        public ConsoleOperations() { }

        //public static ConsoleOperations Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}

        public void Print(string message)
        {
           Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
