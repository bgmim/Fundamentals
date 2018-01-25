using System;

namespace _12._Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                   
                }

            }
            Console.WriteLine("It is a number.");

        }
    }
}
