/* Y3JlYXRlZCBieSBMZUtvbnN0
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int number, result;
            result = 0;
            //result can be = 0. Add var with type bool, to understand that result exist.
            bool isThirdDigit = false;
            number = inputNumber("Input a number: ");
            
            while(number / 100 > 0)
            {
                isThirdDigit = true;
                result = number % 10;
                number = number / 10;
            }
            
            if(isThirdDigit)
            {
                Console.WriteLine("Третья цифра: {0}", result);
            }else
            {
                Console.WriteLine("Третьей цифры нет");
            }
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