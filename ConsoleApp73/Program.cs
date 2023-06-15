using System.Globalization;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int firstDivisor = 3;
            int secondDivider = 5;
            int maxNumber = 101;
            float finalResult = 0;
            bool isUserExit = false;
            number = random.Next(maxNumber + 1);

            Console.WriteLine("Ваше число:" + number);

            for (int i = 0; i < number; i++)
            {
                if (i % firstDivisor == 0 || i % secondDivider == 0)
                {
                    finalResult += i;
                }
            }

            Console.WriteLine("Общая сумма - " + finalResult);
        }
    }
}