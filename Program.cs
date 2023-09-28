using System;

namespace Second_Digit_Number
{
    public class Answer
    {
        static void PrintThirdDigit(int number)
        {
            string numStr = number.ToString();
            if (numStr.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                char num = numStr[2];
                Console.WriteLine(num);
            }
        }


        static public void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите число");
            int number;

            if (args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            PrintThirdDigit(number);
        }
    }
}
