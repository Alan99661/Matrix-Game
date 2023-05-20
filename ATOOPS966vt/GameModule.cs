using ATOOPS966vt.Implementations.GameLoop.PickingElement;
using ATOOPS966vt.Implementations.GameLoop;
using ATOOPS966vt.Implementations;
using ATOOPS966vt.Interfaces.ConsoleOperations;
using ATOOPS966vt.Interfaces.GameLoop;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATOOPS966vt.Interfaces;
using System.Text.RegularExpressions;

namespace ATOOPS966vt
{
    internal class GameModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrinter>().To<ConsoleOperations>();
            Bind<IReader>().To<ConsoleOperations>();
            Bind<IConsoleOperations>().To<ConsoleOperations>();
            Bind<Regex>().ToMethod(context => new Regex(@"^\d+\s+\d+$"));
            Bind<InputValidator>().To<RegexInputValidator>();
            Bind<IInputTaker>().To<InputTaker>();
            Bind<IElementPicker>().To<ElementPicker>();
            Bind<IPickedChecker>().To<PickedCheker>();
            Bind<IOutOFBoundsCheck>().To<OutOFBoundsCheck>();
            Bind<IGameRound>().To<GameRound>();
            Bind<int>().ToConstant(0).Named("EndgameValue");
            Bind<IEndGameChecker>().To<EndgameChecker>();
            Bind<IPointCalculator>().To<PointCalculator>();
            Bind<IGameLoop>().To<GameLoop>();
        }
    }
}
