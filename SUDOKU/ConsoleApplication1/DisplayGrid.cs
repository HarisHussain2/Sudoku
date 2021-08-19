using System;

namespace Sudoku
{
    class DisplayGrid
    {
        public void DisplayGridMethod(char[][] grid, int iterativeSteps)
        {
            // For displaying the recursive steps and sudoku grid after solving it.
            Console.WriteLine();
            Console.WriteLine("Grid was solved after {0} recurssive steps:", iterativeSteps);
            Console.WriteLine("-----------");
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine("|" + "{0}" + "|", new string(grid[i]));
            }
            Console.WriteLine("-----------");
        }
    }
}
