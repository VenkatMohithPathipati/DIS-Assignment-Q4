using System;

namespace AssignQues4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimention of the array");
            var dim = int.Parse(Console.ReadLine());// taking the dimension
            var bulls_grid = new int[dim,dim];// initiating array
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    bulls_grid[i,j] = int.Parse(Console.ReadLine());//adding values to the array
                }
            }
            Console.WriteLine(DiagonalSum(bulls_grid, dim));
            
            
        }
        static int DiagonalSum(int[,] bulls_grid, int dim)
        {
            int diag = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (i == j | i + j == dim - 1)// by using or, a number is added only once even if it satisfies both the conditions
                    {
                        diag = diag + bulls_grid[i,j];
                    }
                }
            }
            return diag;
            

        }
    }
}
