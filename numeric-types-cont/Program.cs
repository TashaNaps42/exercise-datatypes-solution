using System;

namespace numeric_types_cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How far did you drive in miles?");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many gallons did you use?");
            int gallons = int.Parse(Console.ReadLine());
            int mpg = miles / gallons;
            if (mpg >= 30)
            {
                Console.WriteLine($"You got {mpg} miles per gallon? Dang is that a hybrid? The savings!");
            }
            else
            {
                Console.WriteLine($"You got {mpg} miles per gallon? Keep poisoning the Earth, I'm sure we have another one...");
            }
        }
    }
}
