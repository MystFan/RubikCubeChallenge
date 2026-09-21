namespace RubikCubeChallenge.Cube
{
    public class CubeConsolePrinter : ICubePrinter
    {
        public void Print(IPrintableCube cube)
        {
            // Up: U
            for (int row = 0; row < cube.N; row++)
            {
                Console.Write(new string(' ', cube.N * 2));
                PrintRow(cube.N, cube.Up, row);
                Console.WriteLine();
            }

            // Middle: L, F, R, B
            for (int row = 0; row < cube.N; row++)
            {
                PrintRow(cube.N, cube.Left, row); 
                PrintRow(cube.N, cube.Front, row); 
                PrintRow(cube.N, cube.Right, row); 
                PrintRow(cube.N, cube.Back, row); 
                Console.WriteLine();
            }

            // Down (D)
            for (int row = 0; row < cube.N; row++)
            {
                Console.Write(new string(' ', cube.N * 2));
                PrintRow(cube.N, cube.Down, row);
                Console.WriteLine();
            }
        }

        private void PrintRow(int n, char[,] face, int row)
        {
            ConsoleColor originalBg = Console.BackgroundColor;
            for (int col = 0; col < n; col++)
            {
                char colorChar = face[row, col];
                SetConsoleColor(colorChar);
                Console.Write(colorChar + " ");
            }

            Console.ResetColor();
        }

        private void SetConsoleColor(char color)
        {
            Console.ForegroundColor = color switch
            {
                'W' => ConsoleColor.White,
                'Y' => ConsoleColor.Yellow,
                'G' => ConsoleColor.Green,
                'B' => ConsoleColor.Blue,
                'O' => ConsoleColor.DarkYellow,
                'R' => ConsoleColor.Red,
                _ => ConsoleColor.Gray
            };
        }
    }
}
