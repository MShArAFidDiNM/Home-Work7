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

            Random rand = new Random();
            int randnumber = rand.Next(0, 10);
            int[][] arr = new int[randnumber][];

            for (int i = 0; i < randnumber; i++)
            {
                int rand_num2 = rand.Next(3, 10);
                arr[i] = new int[rand_num2];

                Console.WriteLine($"[{randnumber}][{rand_num2}]");
            }

            Max(arr);

            Console.ReadLine();
        }

        public static void Max(int[][] arr)
        {

            Random rand = new Random();

            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentMax = 0;
                int sum = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] += rand.Next(1, 10);

                    Console.Write($"{arr[i][j]}  ");

                    currentMax += arr[i][j];
                    sum += arr[i][j];

                }


                if (currentMax > max)
                {
                    max = currentMax;
                }


                Console.WriteLine($" : sum : {sum}");

            }

            Console.WriteLine($"Max : {max}");

        }
    }
    
}
