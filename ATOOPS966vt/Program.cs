using ATOOPS966vt;
using ATOOPS966vt.Implementations;
using ATOOPS966vt.Implementations.GameLoop;
using ATOOPS966vt.Implementations.GameLoop.PickingElement;
using ATOOPS966vt.Implementations.GamePieces;
using ATOOPS966vt.Implementations.GridGeneration;
using ATOOPS966vt.Interfaces.GameLoop;
using ATOOPS966vt.Interfaces.GamePieces;
using ATOOPS966vt.Interfaces.GridOperations;
using Ninject;
using System.Reflection;
using System.Text.RegularExpressions;

Dictionary<char, int> elements = new Dictionary<char, int>();
elements['o'] = 0;
elements['F'] = 5;
elements['G'] = 10;
elements['D'] = 15;
elements['R'] = 20;

ConsoleOperations consoleOperations = new ConsoleOperations();
IPlayer player1 = new Player("Jeff");
IPlayer player2 = new Player("Jeb");
Regex regex = new Regex(@"^\d+\s+\d+$");
IGridGenerator generator = new GridGenerator();
IGrid grid = generator.Generate(3, 3, elements, new ElementsValidator(consoleOperations));
IDetermineWinner determineWinner = new DetermineWinner();

//IGameLoop gameLoop = new GameLoop(
//    consoleOperations,
//    new GameRound(
//        new InputTaker(
//            new RegexInputValidator(regex)
//        ),
//        new ElementPicker(),
//        consoleOperations,
//        new PickedCheker(),
//        new OutOFBoundsCheck()
//    ),
//    new EndgameChecker(0),
//    new PointCalculator()
//);
var kernel = new StandardKernel();
kernel.Load(new GameModule());
var gameLoop = kernel.Get<IGameLoop>();
gameLoop.LoopGame(player1, player2, grid);
var winner = determineWinner.DetermineWinner(player1, player2);
consoleOperations.Print($"The winner is:{winner.Name}");








