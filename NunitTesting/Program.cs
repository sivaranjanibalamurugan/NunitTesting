using System;

namespace NunitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("1 - Day of week");
            Console.WriteLine("2 - Temperature Conversion");
            Console.WriteLine("3 - Monthly Payment");
            Console.WriteLine("Enter you choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:

                    DayofWeek DayofWeek = new DayofWeek();
                    DayofWeek.ReadInput();
                    break;

                case 2:
                    TemperatureConversion temperatureConversion = new TemperatureConversion();
                    temperatureConversion.ReadInput();
                    break;
                case 3:

                    MonthlyPayment MonthlyPayment = new MonthlyPayment();
                    MonthlyPayment.ReadInput();
                    break;

                default:
                    break;

            }
            Console.Read();
        }
    }
}