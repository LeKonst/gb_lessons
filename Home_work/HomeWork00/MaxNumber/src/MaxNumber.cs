/*Y3JlYXRlZCBieSBMZUtvbnN0
    Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/
using System;
using System.Text;

namespace MaxNumber
{

    class MaxNumber
    {
        static void Main(string[] args)
        {
           ComparingNumbers comparingNumbers = new ComparingNumbers();
           Console.Write("Input first number: ");
           int first_number = Convert.ToInt32(Console.ReadLine());
           Console.Write("Input second number: ");
           int second_number = Convert.ToInt32(Console.ReadLine());
           Console.Write("Input third number: ");
           int third_number = Convert.ToInt32(Console.ReadLine());

           int max_number = comparingNumbers.MaxNumber(first_number, second_number);
           max_number = comparingNumbers.MaxNumber(max_number, third_number);

           Console.WriteLine("Max number {0}", max_number);
        }

    }
}

