namespace RubikCubeChallenge.Cube
{
    public class CubeConsolePrinter : ICubePrinter
    {
        public void Print(IPrintableCube cube)
        {
            // Up: U
            for (int row = 0; row < cube.Size; row++)
            {
                Console.Write(new string(' ', cube.Size * 2));
                PrintRow(cube.Size, cube.Up, row);
                Console.WriteLine();
            }

            // Middle: L, F, R, B
            for (int row = 0; row < cube.Size; row++)
            {
                PrintRow(cube.Size, cube.Left, row); 
                PrintRow(cube.Size, cube.Front, row); 
                PrintRow(cube.Size, cube.Right, row); 
                PrintRow(cube.Size, cube.Back, row); 
                Console.WriteLine();
            }

            // Down (D)
            for (int row = 0; row < cube.Size; row++)
            {
                Console.Write(new string(' ', cube.Size * 2));
                PrintRow(cube.Size, cube.Down, row);
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
