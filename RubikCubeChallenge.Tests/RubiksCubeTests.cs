using RubikCubeChallenge.Cube;

namespace RubikCubeChallenge.Tests
{
    public class RubiksCubeTests
    {
        [Fact]
        public void RotateFront_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateRight();

            // Act
            cube.RotateFront();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'G', 'G', 'G' }, { 'G', 'G', 'G' }, { 'Y', 'Y', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'W', 'W', 'G' }, { 'W', 'W', 'G' }, { 'O', 'O', 'O' } }, cube.Up);
                AssertFace(new char[,] { { 'R', 'R', 'R' }, { 'Y', 'Y', 'B' }, { 'Y', 'Y', 'B' } }, cube.Down);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' }, { 'O', 'O', 'B' } }, cube.Left);
                AssertFace(new char[,] { { 'W', 'R', 'R' }, { 'W', 'R', 'R' }, { 'G', 'R', 'R' } }, cube.Right);
                AssertFace(new char[,] { { 'W', 'B', 'B' }, { 'W', 'B', 'B' }, { 'W', 'B', 'B' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateFrontCounterClockwise_ShouldRotateTheFaceCounterClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateRight();

            // Act
            cube.RotateFrontCounterClockwise();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'Y', 'Y', 'Y' }, { 'G', 'G', 'G' }, { 'G', 'G', 'G' } }, cube.Front);
                AssertFace(new char[,] { { 'W', 'W', 'G' }, { 'W', 'W', 'G' }, { 'R', 'R', 'R' } }, cube.Up);
                AssertFace(new char[,] { { 'O', 'O', 'O' }, { 'Y', 'Y', 'B' }, { 'Y', 'Y', 'B' } }, cube.Down);
                AssertFace(new char[,] { { 'O', 'O', 'G' }, { 'O', 'O', 'W' }, { 'O', 'O', 'W' } }, cube.Left);
                AssertFace(new char[,] { { 'B', 'R', 'R' }, { 'Y', 'R', 'R' }, { 'Y', 'R', 'R' } }, cube.Right);
                AssertFace(new char[,] { { 'W', 'B', 'B' }, { 'W', 'B', 'B' }, { 'W', 'B', 'B' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateRight_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();

            // Act
            cube.RotateRight();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'G', 'G', 'R' }, { 'G', 'G', 'Y' }, { 'G', 'G', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'W', 'W', 'G' }, { 'W', 'W', 'G' }, { 'O', 'O', 'G' } }, cube.Up);
                AssertFace(new char[,] { { 'R', 'R', 'B' }, { 'Y', 'Y', 'B' }, { 'Y', 'Y', 'B' } }, cube.Down);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' } }, cube.Left);
                AssertFace(new char[,] { { 'W', 'W', 'W' }, { 'R', 'R', 'R' }, { 'R', 'R', 'R' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'B', 'B' }, { 'W', 'B', 'B' }, { 'W', 'B', 'B' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateRightCounterClockwise_ShouldRotateTheFaceCounterClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();

            // Act
            cube.RotateRightCounterClockwise();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'G', 'G', 'W' }, { 'G', 'G', 'W' }, { 'G', 'G', 'O' } }, cube.Front);
                AssertFace(new char[,] { { 'W', 'W', 'B' }, { 'W', 'W', 'B' }, { 'O', 'O', 'B' } }, cube.Up);
                AssertFace(new char[,] { { 'R', 'R', 'G' }, { 'Y', 'Y', 'G' }, { 'Y', 'Y', 'G' } }, cube.Down);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' } }, cube.Left);
                AssertFace(new char[,] { { 'R', 'R', 'R' }, { 'R', 'R', 'R' }, { 'W', 'W', 'W' } }, cube.Right);
                AssertFace(new char[,] { { 'Y', 'B', 'B' }, { 'Y', 'B', 'B' }, { 'R', 'B', 'B' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateUp_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();
            cube.RotateRight();

            // Act
            cube.RotateUp();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'W', 'W', 'W' }, { 'G', 'G', 'Y' }, { 'G', 'G', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'O', 'W', 'W' }, { 'O', 'W', 'W' }, { 'G', 'G', 'G' } }, cube.Up);
                AssertFace(new char[,] { { 'R', 'R', 'B' }, { 'Y', 'Y', 'B' }, { 'Y', 'Y', 'B' } }, cube.Down);
                AssertFace(new char[,] { { 'G', 'G', 'R' }, { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' } }, cube.Left);
                AssertFace(new char[,] { { 'O', 'B', 'B' }, { 'R', 'R', 'R' }, { 'R', 'R', 'R' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'W', 'B', 'B' }, { 'W', 'B', 'B' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateUpCounterClockwise_ShouldRotateTheFaceCounterClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();
            cube.RotateRight();

            // Act
            cube.RotateUpCounterClockwise();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'G', 'G', 'Y' }, { 'G', 'G', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'G', 'G', 'G' }, { 'W', 'W', 'O' }, { 'W', 'W', 'O' } }, cube.Up);
                AssertFace(new char[,] { { 'R', 'R', 'B' }, { 'Y', 'Y', 'B' }, { 'Y', 'Y', 'B' } }, cube.Down);
                AssertFace(new char[,] { { 'O', 'B', 'B' }, { 'O', 'O', 'Y' }, { 'O', 'O', 'Y' } }, cube.Left);
                AssertFace(new char[,] { { 'G', 'G', 'R' }, { 'R', 'R', 'R' }, { 'R', 'R', 'R' } }, cube.Right);
                AssertFace(new char[,] { { 'W', 'W', 'W' }, { 'W', 'B', 'B' }, { 'W', 'B', 'B' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateDown_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();
            cube.RotateRightCounterClockwise();
            cube.RotateUp();

            // Act
            cube.RotateDown();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'R', 'R', 'R' }, { 'G', 'G', 'W' }, { 'O', 'O', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'O', 'W', 'W' }, { 'O', 'W', 'W' }, { 'B', 'B', 'B' } }, cube.Up);
                AssertFace(new char[,] { { 'Y', 'Y', 'R' }, { 'Y', 'Y', 'R' }, { 'G', 'G', 'G' } }, cube.Down);
                AssertFace(new char[,] { { 'G', 'G', 'W' }, { 'O', 'O', 'Y' }, { 'R', 'B', 'B' } }, cube.Left);
                AssertFace(new char[,] { { 'Y', 'B', 'B' }, { 'R', 'R', 'R' }, { 'G', 'G', 'O' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'Y', 'B', 'B' }, { 'W', 'W', 'W' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateDownCounterClockwise_ShouldRotateTheFaceCounterClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();
            cube.RotateRightCounterClockwise();
            cube.RotateUp();

            // Act
            cube.RotateDownCounterClockwise();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'R', 'R', 'R' }, { 'G', 'G', 'W' }, { 'W', 'W', 'W' } }, cube.Front);
                AssertFace(new char[,] { { 'O', 'W', 'W' }, { 'O', 'W', 'W' }, { 'B', 'B', 'B' } }, cube.Up);
                AssertFace(new char[,] { { 'G', 'G', 'G' }, { 'R', 'Y', 'Y' }, { 'R', 'Y', 'Y' } }, cube.Down);
                AssertFace(new char[,] { { 'G', 'G', 'W' }, { 'O', 'O', 'Y' }, { 'G', 'G', 'O' } }, cube.Left);
                AssertFace(new char[,] { { 'Y', 'B', 'B' }, { 'R', 'R', 'R' }, { 'R', 'B', 'B' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'Y', 'B', 'B' }, { 'O', 'O', 'Y' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateLeft_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();
            cube.RotateUp();
            cube.RotateDown();

            // Act
            cube.RotateLeft();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'O', 'R', 'R' }, { 'O', 'G', 'G' }, { 'O', 'O', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'R', 'W', 'W' }, { 'B', 'W', 'W' }, { 'Y', 'W', 'W' } }, cube.Up);
                AssertFace(new char[,] { { 'W', 'Y', 'R' }, { 'G', 'Y', 'R' }, { 'O', 'Y', 'R' } }, cube.Down);
                AssertFace(new char[,] { { 'B', 'O', 'G' }, { 'B', 'O', 'G' }, { 'B', 'Y', 'G' } }, cube.Left);
                AssertFace(new char[,] { { 'B', 'B', 'B' }, { 'W', 'R', 'R' }, { 'G', 'G', 'G' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'O', 'Y' }, { 'B', 'B', 'Y' }, { 'W', 'R', 'Y' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateLeftCounterClockwise_ShouldRotateTheFaceCounterClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateFront();
            cube.RotateUp();
            cube.RotateDown();

            // Act
            cube.RotateLeftCounterClockwise();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'Y', 'R', 'R' }, { 'Y', 'G', 'G' }, { 'Y', 'O', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'W', 'W', 'W' }, { 'G', 'W', 'W' }, { 'O', 'W', 'W' } }, cube.Up);
                AssertFace(new char[,] { { 'R', 'Y', 'R' }, { 'B', 'Y', 'R' }, { 'Y', 'Y', 'R' } }, cube.Down);
                AssertFace(new char[,] { { 'G', 'Y', 'B' }, { 'G', 'O', 'B' }, { 'G', 'O', 'B' } }, cube.Left);
                AssertFace(new char[,] { { 'B', 'B', 'B' }, { 'W', 'R', 'R' }, { 'G', 'G', 'G' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'O', 'O' }, { 'B', 'B', 'O' }, { 'W', 'R', 'O' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateBack_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateRight();
            cube.RotateLeft();
            cube.RotateUp();

            // Act
            cube.RotateBack();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'R', 'R', 'R' }, { 'W', 'G', 'Y' }, { 'W', 'G', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'Y', 'R', 'R' }, { 'W', 'W', 'W' }, { 'G', 'G', 'G' } }, cube.Up);
                AssertFace(new char[,] { { 'G', 'Y', 'B' }, { 'G', 'Y', 'B' }, { 'W', 'O', 'O' } }, cube.Down);
                AssertFace(new char[,] { { 'B', 'G', 'Y' }, { 'B', 'O', 'O' }, { 'B', 'O', 'O' } }, cube.Left);
                AssertFace(new char[,] { { 'W', 'B', 'B' }, { 'R', 'R', 'Y' }, { 'R', 'R', 'G' } }, cube.Right);
                AssertFace(new char[,] { { 'W', 'W', 'O' }, { 'B', 'B', 'O' }, { 'Y', 'Y', 'O' } }, cube.Back);
            });
        }

        [Fact]
        public void RotateBackCounterClockwise_ShouldRotateTheFaceClockwise()
        {
            // Arrange
            var cube = new RubiksCube();
            cube.RotateRight();
            cube.RotateLeft();
            cube.RotateUp();

            // Act
            cube.RotateBackCounterClockwise();

            // Assert
            Assert.Multiple(() =>
            {
                AssertFace(new char[,] { { 'R', 'R', 'R' }, { 'W', 'G', 'Y' }, { 'W', 'G', 'Y' } }, cube.Front);
                AssertFace(new char[,] { { 'O', 'O', 'W' }, { 'W', 'W', 'W' }, { 'G', 'G', 'G' } }, cube.Up);
                AssertFace(new char[,] { { 'G', 'Y', 'B' }, { 'G', 'Y', 'B' }, { 'R', 'R', 'Y' } }, cube.Down);
                AssertFace(new char[,] { { 'G', 'G', 'Y' }, { 'Y', 'O', 'O' }, { 'B', 'O', 'O' } }, cube.Left);
                AssertFace(new char[,] { { 'W', 'B', 'B' }, { 'R', 'R', 'B' }, { 'R', 'R', 'B' } }, cube.Right);
                AssertFace(new char[,] { { 'O', 'Y', 'Y' }, { 'O', 'B', 'B' }, { 'O', 'W', 'W' } }, cube.Back);
            });
        }

        private void AssertFace(char[,] expected, char[,] actual)
        {
            for (int row = 0; row < actual.GetLength(0); row++)
            {
                for (int col = 0; col < actual.GetLength(1); col++)
                {
                    Assert.Equal(expected[row, col], actual[row, col]);
                }
            }
        }
    }
}
