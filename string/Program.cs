using System;

namespace strings_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aliceSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string aliceSentenceSearch = aliceSentence.ToLower();
            Console.WriteLine("Search a term from the Alice Sentence");
            string searchTerm = Console.ReadLine().ToLower();

            if (aliceSentenceSearch.IndexOf(searchTerm) != -1)
            {
                int termLength = searchTerm.Length;
                int termIndex = aliceSentenceSearch.IndexOf(searchTerm);
                int termEnd = termIndex + termLength;
                int remainingChars = aliceSentence.Length - termLength;
                Console.WriteLine($"String size {searchTerm.Length} found at index[{aliceSentenceSearch.IndexOf(searchTerm)}]");
                Console.WriteLine(aliceSentenceSearch.Replace(searchTerm, ""));
            }
            else
            {
                Console.WriteLine("404. Jk that's for client-server ;)");
            }
        }
    }
}
