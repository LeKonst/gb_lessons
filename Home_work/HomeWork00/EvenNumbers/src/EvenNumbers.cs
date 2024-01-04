/* Y3JlYXRlZCBieSBMZUtvbnN0
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
using System;
using System.Text;

namespace isEvenNumber
{

    class isEvenNumber
    {
        static void Main(string[] args)
        {
            EvenNumber evenNumber = new EvenNumber();
            Console.Write("Input number: ");
            int number;
            List<int> listEvenNumber;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Enter a numeric value!");
                return;
            }

            if(number <= 0)
            {
                Console.Write("The number is less 0!");
                return;    
            }

            listEvenNumber = evenNumber.listEvenNumber(number);

            Console.WriteLine(String.Join(",", listEvenNumber.Select(i => i.ToString()).ToArray()));
        }
    }
}