using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapko_LabWork_2_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TASK: Write a method that takes a array of non-negative integers, 
            // sorts them so that they make up the largest possible number. 
            // For example, [50, 2, 1, 9], the largest generated number is 95021.

            int[] array = new int[] { 50, 2, 1, 9 };
            Console.WriteLine(GetMaximumPossibleNumber(array));

            Console.ReadKey();
        }

        public static int GetMaximumPossibleNumber(int[] array)
        {
            // Сортируем массив
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    // Сравниваем длину чисел
                    // наименьшему добавляем 9 до длины наибольшего
                    string elementI = array[i].ToString();
                    string elementJ = array[j].ToString();

                    int lengthElementI = elementI.Length;
                    int lengthElementJ = elementJ.Length;

                    if (lengthElementI != lengthElementJ)
                    {
                        if (lengthElementI > lengthElementJ)
                        {
                            elementJ += new string('9', lengthElementI - lengthElementJ); 
                        }
                        else
                        {
                            elementI += new string('9', lengthElementJ - lengthElementI);
                        }
                    }

                    if (Int32.Parse(elementI) < Int32.Parse(elementJ))
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            // Получаем число из массива
            var builder = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                builder.Append(array[i]);
            }

            return Int32.Parse(builder.ToString());
        }
    }
}
