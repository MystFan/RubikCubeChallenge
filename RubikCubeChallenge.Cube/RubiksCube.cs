namespace RubikCubeChallenge.Cube
{
    public class RubiksCube : IPrintableCube
    {
        private readonly int n;
        private readonly char[,] up;
        private readonly char[,] down;
        private readonly char[,] front;
        private readonly char[,] back;
        private readonly char[,] left;
        private readonly char[,] right;

        public RubiksCube(int n = 3)
        {
            this.n = n;
            up = new char[n, n];
            down = new char[n, n];
            front = new char[n, n];
            back = new char[n, n];
            left = new char[n, n];
            right = new char[n, n];

            this.Reset();
        }

        public int N => n;
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
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = up[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                up[n - 1, i] = left[n - i - 1, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                left[i, n - 1] = down[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                down[0, i] = right[n - i - 1, 0];
            }

            for (int i = 0; i < n; i++)
            {
                right[i, 0] = temp[i];
            }
        }

        public void RotateFrontCounterClockwise()
        {
            RotateFaceCounterClockwise(front);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = up[n - 1, i];
            }

            for (int i = 0; i < 3; i++)
            {
                up[n - 1, i] = right[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                right[i, 0] = down[0, n - i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                down[0, i] = left[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                left[i, n - 1] = temp[n - i - 1];
            }
        }

        public void RotateUp()
        {
            RotateFaceClockwise(up);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                front[0, i] = right[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                right[0, i] = back[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                back[0, i] = left[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                left[0, i] = temp[i];
            }
        }

        public void RotateUpCounterClockwise()
        {
            RotateFaceCounterClockwise(up);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                front[0, i] = left[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                left[0, i] = back[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                back[0, i] = right[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                right[0, i] = temp[i];
            }
        }

        public void RotateDown()
        {
            RotateFaceClockwise(down);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                front[n - 1, i] = left[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                left[n - 1, i] = back[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                back[n - 1, i] = right[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                right[n - 1, i] = temp[i];
            }
        }

        public void RotateDownCounterClockwise()
        {
            RotateFaceCounterClockwise(down);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                front[n - 1, i] = right[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                right[n - 1, i] = back[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                back[n - 1, i] = left[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                left[n - 1, i] = temp[i];
            }
        }

        public void RotateLeft()
        {
            RotateFaceClockwise(left);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                front[i, 0] = up[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                up[i, 0] = back[n - i - 1, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                back[n - i - 1, n - 1] = down[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                down[i, 0] = temp[i];
            }
        }

        public void RotateLeftCounterClockwise()
        {
            RotateFaceCounterClockwise(left);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                front[i, 0] = down[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                down[i, 0] = back[n - i - 1, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                back[n - i - 1, n - 1] = up[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                up[i, 0] = temp[i];
            }
        }

        public void RotateRight()
        {
            RotateFaceClockwise(right);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                front[i, n - 1] = down[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                down[i, n - 1] = back[n - i - 1, 0];
            }

            for (int i = 0; i < n; i++)
            {
                back[n - i - 1, 0] = up[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                up[i, n - 1] = temp[i];
            }
        }

        public void RotateRightCounterClockwise()
        {
            RotateFaceCounterClockwise(right);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = front[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                front[i, n - 1] = up[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                up[i, n - 1] = back[n - i - 1, 0];
            }

            for (int i = 0; i < n; i++)
            {
                back[i, 0] = down[n - i - 1, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                down[i, n - 1] = temp[n - i - 1];
            }
        }

        public void RotateBack()
        {
            RotateFaceClockwise(back);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = up[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                up[0, i] = right[i, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                right[i, n - 1] = down[n - 1, n - i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                down[n - 1, i] = left[i, 0];
            }

            for (int i = 0; i < n; i++)
            {
                left[i, 0] = temp[n - i - 1];
            }
        }

        public void RotateBackCounterClockwise()
        {
            RotateFaceCounterClockwise(back);
            char[] temp = new char[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = up[0, i];
            }

            for (int i = 0; i < n; i++)
            {
                up[0, i] = left[n - i - 1, 0];
            }

            for (int i = 0; i < n; i++)
            {
                left[i, 0] = down[n - 1, i];
            }

            for (int i = 0; i < n; i++)
            {
                down[n - 1, i] = right[n - i - 1, n - 1];
            }

            for (int i = 0; i < n; i++)
            {
                right[i, n - 1] = temp[i];
            }
        }

        private void RotateFaceClockwise(char[,] face)
        {
            char[,] temp = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    temp[col, n - row - 1] = face[row, col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int c = 0; c < n; c++)
                {
                    face[row, c] = temp[row, c];
                }
            }
        }

        private void RotateFaceCounterClockwise(char[,] face)
        {
            char[,] temp = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    temp[n - col - 1, row] = face[row, col];
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    face[r, c] = temp[r, c];
                }
            }
        }

        private void FillFace(char[,] face, char color)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    face[row, col] = color;
                }
            }
        }
    }
}
