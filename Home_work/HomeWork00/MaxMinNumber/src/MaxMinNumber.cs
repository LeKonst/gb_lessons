/* Y3JlYXRlZCBieSBMZUtvbnN0
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
using System;
using System.Text;

namespace MaxMinNumber
{

    class MaxNumber
    {
        static void Main(string[] args)
        {
           ComparingNumbers comparingNumbers = new ComparingNumbers();
           int first_number, second_number;
           first_number = inputNumber("Input first number: ");
           second_number = inputNumber("Input second number: ");

           Console.WriteLine("Max number {0}", comparingNumbers.MaxNumber(first_number, second_number));
           Console.WriteLine("Min number {0}", comparingNumbers.MinNumber(first_number, second_number)); 
        }

        private static int inputNumber(string TextForInput)
        {
            int result;
            result = 0;
            Console.Write(TextForInput);
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a numeric value!");
                return 0;
            }
            return result;
        }
    }
}

