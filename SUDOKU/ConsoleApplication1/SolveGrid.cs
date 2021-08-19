using System;

namespace Sudoku
{
    //The search strategy most constrained first" heuristic is used for sloving the sudoku grid.
    //The cell with most constraints upon itself is chosen first in each step of the algorithm.
    class SolveGrid
    {
        public bool SolveGridMethod(char[][] grid, ref int iterativeSteps)
        {

            bool solved = false;

            int row = -1;
            int col = -1;
            char[] candidates = null;
            
            for (int i = 0; i < 9; i++)
            { 
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i][j] == '.')
                    {
                        ValidEntries ValidEntriesInstance = new ValidEntries();
                        char[] newValidEntries = ValidEntriesInstance.ValidEntriesMethod(grid, i, j);

                        if (row < 0 || newValidEntries.Length < candidates.Length)
                        {
                            row = i;
                            col = j;
                            candidates = newValidEntries;
                        }
                    }
                }
            }
            if (row < 0)
            {
                solved = true;
            }
            else
            {
                for (int i = 0; i < candidates.Length; i++)
                {
                    grid[row][col] = candidates[i];
                    iterativeSteps++;
                    if (SolveGridMethod(grid, ref iterativeSteps))
                    {
                        solved = true;
                        break;
                    }
                    grid[row][col] = '.';
                }
            }
            return solved;
        }
    }
}
