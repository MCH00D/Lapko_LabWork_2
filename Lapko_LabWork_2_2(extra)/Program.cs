using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lapko_LabWork_2_1_extra_
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TASK: Write a method that calculate the first 100 Fibonacci numbers. 
            // By definition, the first two numbers in the Fibonacci sequence are 0 and 1, 
            // and each successive number is the sum of the two previous ones. 
            // As an example, here are the first 10 Fibonacci numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21 and 34.
            // EXTRA: Модифицировать задачу про фибоначи так, что пользователь сам мог указать сколько чисел Фибоначчи необходимо вывести.

            int numbersFibonacci;

            Console.WriteLine("Fibonacci numbers");

            while (true)
            {
                Console.Write("Enter the number of Fibonacci numbers: ");

                if (Int32.TryParse(Console.ReadLine(), out numbersFibonacci) && numbersFibonacci > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The entered value must be a positive number!");
                }
            }
            var listFibonacci = GetListNumbersFibonacci(numbersFibonacci);

            for (int i = 0; i < listFibonacci.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i, listFibonacci[i]);
            }

            Console.ReadKey();
        }

        public static List<BigInteger> GetListNumbersFibonacci(int amount)
        {
            if (amount == 1)
            {
                return new List<BigInteger>() { 0 };
            }

            List<BigInteger> list = new List<BigInteger>() { 0, 1 };

            for (int i = 1; list.Count < amount; i++)
            {
                list.Add(list[i] + list[i - 1]);
            }

            return list;
        }
    }
}
