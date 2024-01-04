/* Y3JlYXRlZCBieSBMZUtvbnN0
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

namespace WeekendDay
{
    class WeekendDay
    {
        static void Main(string[] args)
        {
            int number;
            number = inputNumber("Enter day of the week: ");
            
            while(number < 1 || number > 7)
            {
                Console.WriteLine("Enter a number between 1 to 7!");
                return;
            }
            
            if(number == 6 || number == 7)
            {
                Console.WriteLine("День недели {0} - выходной.", number);
            }else
            {
                Console.WriteLine("День недели {0} - не выходной.", number);
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