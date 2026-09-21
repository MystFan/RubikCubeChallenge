using RubikCubeChallenge.Cube;
using Playground = System.Console;

namespace RubikCubeChallenge.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cube = new RubiksCube();
            var cubePrinter = new CubeConsolePrinter();

            while (true)
            {
                Playground.Clear();
                Playground.WriteLine("=== Rubik's Cube ===");
                Playground.WriteLine("Enter command (U, D, F, B, L, R, U', D', F', B', L', R', 'reset') or 'exit' to quit:");
                Playground.WriteLine("------------------------------------------------------------------------------------");

                cubePrinter.Print(cube);

                Playground.WriteLine("------------------------------------------------------------------------------------");
                Playground.WriteLine();
                Playground.Write("Your choice: ");
                string input = Playground.ReadLine()?.ToUpper().Trim() ?? string.Empty;

                if (input.ToUpper() == "EXIT")
                {
                    break;
                }

                if (input.ToUpper() == "RESET")
                {
                    cube.Reset();
                    continue;
                }

                switch (input)
                {
                    case "F": cube.RotateFront(); break;
                    case "F'": cube.RotateFrontCounterClockwise(); break;
                    case "U": cube.RotateUp(); break;
                    case "U'": cube.RotateUpCounterClockwise(); break;
                    case "D": cube.RotateDown(); break;
                    case "D'": cube.RotateDownCounterClockwise(); break;
                    case "L": cube.RotateLeft(); break;
                    case "L'": cube.RotateLeftCounterClockwise(); break;
                    case "R": cube.RotateRight(); break;
                    case "R'": cube.RotateRightCounterClockwise(); break;
                    case "B": cube.RotateBack(); break;
                    case "B'": cube.RotateBackCounterClockwise(); break;
                    default:
                        Playground.WriteLine("Invalid command! Press Enter to try again...");
                        Playground.ReadLine();
                        break;
                }
            }
        }
    }
}
