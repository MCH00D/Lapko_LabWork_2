using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapko_LabWork_2_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TASK: Write a method that calculate the first 100 Fibonacci numbers. 
            // By definition, the first two numbers in the Fibonacci sequence are 0 and 1, 
            // and each successive number is the sum of the two previous ones. 
            // As an example, here are the first 10 Fibonacci numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21 and 34.

            var listFibonacci = GetNumbersFibonacci(100);
            
            for (int i = 0; i < listFibonacci.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i, listFibonacci[i]);
            }

            Console.ReadKey();
        }

        public static List<decimal> GetNumbersFibonacci(int amount)
        {
            List<decimal> list = new List<decimal>() { 0, 1 };

            for (int i = 1; list.Count < amount; i++)
            {

                // Check for exceeding the maximum value of type
                decimal diff = decimal.MaxValue - list[i];
                if (list[i - 1] > diff)
                {
                    return list;
                }

                list.Add(list[i] + list[i - 1]);
            }

            return list;
        }
    }
}
