using System;

namespace numeric_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the rectangle's length?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("And our rectangle friend's width?");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine($"The rectangle has an area of {area}");
        }
    }
}
