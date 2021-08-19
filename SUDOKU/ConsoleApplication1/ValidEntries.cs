using System;

namespace Sudoku
{
    class ValidEntries
    {
        public char[] ValidEntriesMethod(char[][] grid, int row, int col)
        {

            string s = "";

            for (char character = '1'; character <= '9'; character++)
            {

                bool collision = false;

                for (int i = 0; i < 9; i++)
                {
                    if (grid[row][i] == character ||
                        grid[i][col] == character ||
                        grid[(row - row % 3) + i / 3][(col - col % 3) + i % 3] == character)
                    {
                        collision = true;
                        break;
                    }
                }

                if (!collision)
                {
                    s = s + character;
                }
            }

            return s.ToCharArray();

        }
    }
}
