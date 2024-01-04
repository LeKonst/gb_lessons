/* Y3JlYXRlZCBieSBMZUtvbnN0
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
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
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Enter a numeric value!");
                return;
            }

           if(number == 0){
            Console.WriteLine("Number equal 0");
            return;
           }

           Console.WriteLine(evenNumber.isEvenNumber(number));
        }
    }
}