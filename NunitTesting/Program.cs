using System;

namespace NunitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("1) Day of week");
            Console.WriteLine("2) Temperature Conversion");
            Console.WriteLine("3) Monthly Payment");
            Console.WriteLine("4) Square Root");
            Console.WriteLine("5) Decimal to Binary");
            Console.WriteLine("6) BinarySwap");
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
                case 4:

                    SquareRoot SquareRoot = new SquareRoot();
                    SquareRoot.ReadInput();
                    break;

                case 5:
                    DecimalToBinary DecimalToBinary = new DecimalToBinary();
                   DecimalToBinary.ReadInput();
                    break;

                case 6:
                    BinarySwap.NibbleSwap();
                    break;

                default:
                    break;

            }
            Console.Read();
        }
    }
}