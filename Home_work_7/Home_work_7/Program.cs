using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int row = rnd.Next(2, 11);
            int[][] array = new int[row][];

            for (int i = 0; i < array.Length; i++)
            {
                int col = rnd.Next(1, 10);
                array[i] = new int [col];
                Console.WriteLine($"array : [{row}][{col}]");
            }

            for (int i = 0;i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(1, 10);
                }
            }

            int big = array[0][0];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                    if (array[i][j] >= big)
                    {
                        big = array[i][j];
                    }
                }
                Console.WriteLine();
            } 

            Console.WriteLine($"Big Number : {big}") ;
            Console.ReadLine();
        }
    }
}
