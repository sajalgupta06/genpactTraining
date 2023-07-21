using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppday8Exercise_2
{
    internal class Program
    {
        public delegate void SortingDel(int[] arr);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Elements of Array");
            int k = 0;
            int[] arr = new int[n];
            while (k<n)
            {
                arr[k] = int.Parse(Console.ReadLine());


                k++;

            }
            int temp;
            SortingDel del = delegate (int[] numsArray)
            {
                for (int i = 0; i < numsArray.Length; i++)
                {
                    for (int j = i; j < numsArray.Length; j++)
                    {
                        if (numsArray[i] > numsArray[j])
                        {
                            temp = numsArray[i];
                            numsArray[i] = numsArray[j];
                            numsArray[j] = temp;

                        }
                    }
                }
                Console.WriteLine("Sorted Array is :");
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                };
            };

            del(arr);
            Console.ReadKey();

        }
    }
}
