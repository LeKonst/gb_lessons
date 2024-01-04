/* Y3JlYXRlZCBieSBMZUtvbnN0
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

namespace SecondDigit
{
    class SecondDigit
    {
        static void Main(string[] args)
        {
            int number, result;
            number = inputNumber("Input a three-digit number: ");

            if(((number/100) == 0) || ((number / 1000) != 0))
            {
                Console.WriteLine("Number can be only a integer three-digit number.");
                return;
            };

            result = number % 100;
            result = result / 10;

            Console.WriteLine("Second digit {0}", result);
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