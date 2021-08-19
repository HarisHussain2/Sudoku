using System;

namespace Sudoku
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                // The sudoku grid will be given as input from the user.
                ReadGrid ReadGridInstance = new ReadGrid();
                char[][] Grid = ReadGridInstance.ReadGridMethod();

                int iterativeSteps = 0;

                SolveGrid SolveGridInstance = new SolveGrid();
                if (SolveGridInstance.SolveGridMethod(Grid, ref iterativeSteps))
                {
                    DisplayGrid DisplayGridInstance = new DisplayGrid();
                    DisplayGridInstance.DisplayGridMethod(Grid, iterativeSteps);
                }
                else
                {
                    Console.WriteLine("The given sudoku is invalid!");
                }

                Console.WriteLine();
                Console.Write("Want to play more? {Yes or No} | ");

                if (Console.ReadLine().ToUpper() != "YES")
                {
                    
                    Console.WriteLine();
                    Console.WriteLine("Thanks for playing Sudoku.");
                    Console.WriteLine();

                    break;
                }
            }
        }
    }
}