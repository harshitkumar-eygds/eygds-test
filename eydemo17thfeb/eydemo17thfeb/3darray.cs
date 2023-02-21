using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class array3d
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details of matrix 1");
            Console.Write("Enter row : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter Col : ");
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            
            Console.WriteLine($"Enter {row * col} numbers");

            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your array is");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                    
                }
                Console.WriteLine();
            }


            Console.WriteLine("Enter details of matrix 2");
            Console.Write("Enter row : ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Col : ");
            int col1 = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[row1, col1];

            Console.WriteLine($"Enter {row1 * col1} numbers");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your array is");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(arr1[i, j] + " ");

                }
                Console.WriteLine();
            }

            if (row == row1 && col == col1)
            {
                Console.WriteLine("matrix addition can be performed");

                for (int i = 0; i < row; i++) {
                    for (int j = 0; j < col; j++) {
                        Console.Write(arr[i, j] + arr1[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else {
                Console.WriteLine("matrix addition cannot be performed");
            }
            
            Console.ReadKey();
        }
    }
}
