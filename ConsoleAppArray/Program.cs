using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int[,] studMarks = new int[4,3];

             for (int i = 0; i < 4;i++)
             {

                     Console.WriteLine("Enter roll no. for student " + i+1);
                     int rollno = int.Parse(Console.ReadLine());
                     Console.WriteLine("Enter sem 1 marks.");
                     int sem1 = int.Parse(Console.ReadLine());
                     Console.WriteLine("Enter sem2 marks.");
                     int sem2 = int.Parse(Console.ReadLine());
                     studMarks[i, 0] = rollno;
                     studMarks[i, 1] = sem1;
                     studMarks[i, 2] = sem2;





             }


             for (int i = 0;i < 4;i++) {

                 Console.WriteLine($" Roll No. {studMarks[i,0]},  Sem1 Marks{studMarks[i,1]}, Sem2 Marks {studMarks[i,2]}");
             }*/

            int[][] arr = new int[3][];
            arr[0] = new int[3] {1,2,3};
            arr[1] = new int[5] { 1, 2, 3,4,5 };
            arr[2] = new int[2] { 1, 2 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]}\t");
                }
                Console.WriteLine("\n");

            }

            Console.ReadKey();
        }
    }
}
