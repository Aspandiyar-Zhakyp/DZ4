using System;

namespace ClassIntroductionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Money purse = new Money(1000, 15);                         
            Console.WriteLine(purse);
            Console.WriteLine(purse.CheckAvailability(251));        
            Console.WriteLine(purse.CalculationOfQuantity(1000));   

            Console.ReadKey();
        }
    }
}
