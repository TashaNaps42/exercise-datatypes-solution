namespace empty_boy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] someInts = { 1, 10, 2, 3, 5, 8, 10 };
            int searchTerm = 10;
            foreach (int oneInt in someInts)
            {
                if (oneInt == searchTerm)
                {
                    Console.WriteLine("Found it!");
                    
                }
                else
                {
                    Console.WriteLine("Not here");
                }
            }
        }
    }
}