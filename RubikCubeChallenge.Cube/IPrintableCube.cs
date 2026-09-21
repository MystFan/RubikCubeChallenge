namespace RubikCubeChallenge.Cube
{
    public interface IPrintableCube
    {
        int N { get; }

        char[,] Up { get; }

        char[,] Down { get; }

        char[,] Front { get; }

        char[,] Back { get; }

        char[,] Left { get; }

        char[,] Right { get; }
    }
}
