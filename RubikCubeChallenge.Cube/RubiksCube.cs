namespace RubikCubeChallenge.Cube
{
    public class RubiksCube : IPrintableCube
    {
        private readonly int size;
        private readonly char[,] up;
        private readonly char[,] down;
        private readonly char[,] front;
        private readonly char[,] back;
        private readonly char[,] left;
        private readonly char[,] right;

        public RubiksCube(int size = 3)
        {
            this.size = size;
            up = new char[size, size];
            down = new char[size, size];
            front = new char[size, size];
            back = new char[size, size];
            left = new char[size, size];
            right = new char[size, size];

            this.Reset();
        }

        public int Size => size;
        public char[,] Up => (char[,])up.Clone();
        public char[,] Down => (char[,])down.Clone();
        public char[,] Front => (char[,])front.Clone();
        public char[,] Back => (char[,])back.Clone();
        public char[,] Left => (char[,])left.Clone();
        public char[,] Right => (char[,])right.Clone();

        public void Reset()
        {
            FillFace(up, 'W');
            FillFace(down, 'Y');
            FillFace(front, 'G');
            FillFace(back, 'B');
            FillFace(left, 'O');
            FillFace(right, 'R');
        }

        public void RotateFront()
        {
            RotateFaceClockwise(front);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = up[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                up[size - 1, i] = left[size - i - 1, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                left[i, size - 1] = down[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                down[0, i] = right[size - i - 1, 0];
            }

            for (int i = 0; i < size; i++)
            {
                right[i, 0] = temp[i];
            }
        }

        public void RotateFrontCounterClockwise()
        {
            RotateFaceCounterClockwise(front);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = up[size - 1, i];
            }

            for (int i = 0; i < 3; i++)
            {
                up[size - 1, i] = right[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                right[i, 0] = down[0, size - i - 1];
            }

            for (int i = 0; i < size; i++)
            {
                down[0, i] = left[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                left[i, size - 1] = temp[size - i - 1];
            }
        }

        public void RotateUp()
        {
            RotateFaceClockwise(up);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                front[0, i] = right[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                right[0, i] = back[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                back[0, i] = left[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                left[0, i] = temp[i];
            }
        }

        public void RotateUpCounterClockwise()
        {
            RotateFaceCounterClockwise(up);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                front[0, i] = left[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                left[0, i] = back[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                back[0, i] = right[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                right[0, i] = temp[i];
            }
        }

        public void RotateDown()
        {
            RotateFaceClockwise(down);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                front[size - 1, i] = left[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                left[size - 1, i] = back[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                back[size - 1, i] = right[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                right[size - 1, i] = temp[i];
            }
        }

        public void RotateDownCounterClockwise()
        {
            RotateFaceCounterClockwise(down);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                front[size - 1, i] = right[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                right[size - 1, i] = back[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                back[size - 1, i] = left[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                left[size - 1, i] = temp[i];
            }
        }

        public void RotateLeft()
        {
            RotateFaceClockwise(left);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                front[i, 0] = up[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                up[i, 0] = back[size - i - 1, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                back[size - i - 1, size - 1] = down[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                down[i, 0] = temp[i];
            }
        }

        public void RotateLeftCounterClockwise()
        {
            RotateFaceCounterClockwise(left);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                front[i, 0] = down[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                down[i, 0] = back[size - i - 1, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                back[size - i - 1, size - 1] = up[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                up[i, 0] = temp[i];
            }
        }

        public void RotateRight()
        {
            RotateFaceClockwise(right);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                front[i, size - 1] = down[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                down[i, size - 1] = back[size - i - 1, 0];
            }

            for (int i = 0; i < size; i++)
            {
                back[size - i - 1, 0] = up[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                up[i, size - 1] = temp[i];
            }
        }

        public void RotateRightCounterClockwise()
        {
            RotateFaceCounterClockwise(right);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = front[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                front[i, size - 1] = up[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                up[i, size - 1] = back[size - i - 1, 0];
            }

            for (int i = 0; i < size; i++)
            {
                back[i, 0] = down[size - i - 1, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                down[i, size - 1] = temp[size - i - 1];
            }
        }

        public void RotateBack()
        {
            RotateFaceClockwise(back);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = up[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                up[0, i] = right[i, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                right[i, size - 1] = down[size - 1, size - i - 1];
            }

            for (int i = 0; i < size; i++)
            {
                down[size - 1, i] = left[i, 0];
            }

            for (int i = 0; i < size; i++)
            {
                left[i, 0] = temp[size - i - 1];
            }
        }

        public void RotateBackCounterClockwise()
        {
            RotateFaceCounterClockwise(back);
            char[] temp = new char[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = up[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                up[0, i] = left[size - i - 1, 0];
            }

            for (int i = 0; i < size; i++)
            {
                left[i, 0] = down[size - 1, i];
            }

            for (int i = 0; i < size; i++)
            {
                down[size - 1, i] = right[size - i - 1, size - 1];
            }

            for (int i = 0; i < size; i++)
            {
                right[i, size - 1] = temp[i];
            }
        }

        private void RotateFaceClockwise(char[,] face)
        {
            char[,] temp = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    temp[col, size - row - 1] = face[row, col];
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int c = 0; c < size; c++)
                {
                    face[row, c] = temp[row, c];
                }
            }
        }

        private void RotateFaceCounterClockwise(char[,] face)
        {
            char[,] temp = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    temp[size - col - 1, row] = face[row, col];
                }
            }

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    face[r, c] = temp[r, c];
                }
            }
        }

        private void FillFace(char[,] face, char color)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    face[row, col] = color;
                }
            }
        }
    }
}
