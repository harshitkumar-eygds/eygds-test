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
            Console.ReadKey();
        }
    }
}
