using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int f = 1;
            int num;
            Console.WriteLine("Enter a whole number");
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    for (i = 1; i <= num; i++)
                        f *= i;
                    Console.Write("The factorial of {0} is: {1}\n", num, f);
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a whole number!");
                }
            }
        }
    }
}
