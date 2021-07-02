using System;

namespace NunitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to N Unit Testing Programs"); 
            Console.WriteLine("1) Day of week");
            Console.WriteLine("Enter you choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.ReadInput();
                    break;

                default:
                    break;
            }
            Console.Read();
        }
    }
}
