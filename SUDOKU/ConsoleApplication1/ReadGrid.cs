using System;

namespace Sudoku
{
    class ReadGrid
    {
        //The char type is used for storing each row of sudoku separately as 9 rows into a series of characters.
        public char[][] ReadGridMethod()
        {
            //Creating an object "grid" that will store the sudoku grid as a 9*9 array
            char[][] grid = new char[9][];

            Console.WriteLine("Enter Sudoku table:");

            for (int i = 0; i <= 8; i++)
            {
                //Converting the given sudoku in a string
                string row = Console.ReadLine();

                //Converting each row of grid into a series of "characters", Substring() returns the string 
                //from index 0 to index 9, and ToCharArray() converts that substring to Char format.
                grid[i] = row.Substring(0,9).ToCharArray();
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i][j] < '1' || grid[i][j] > '9')
                    {
                        //If something is different then the charcters from between '1' to '9', 
                        //they will be converted to '.' for simplicity.
                        grid[i][j] = '.';
                    }
                }
            }
            return grid;
        }
    }
}
