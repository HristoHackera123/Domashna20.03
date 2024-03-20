using System.Diagnostics;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int comp = string.Compare(str1, str2, true);
            if (comp < 0)
            {
                Console.WriteLine($"{str1}(1st input) is before {str2} alphabetically");
            }
            else if (comp > 0) 
            {
                Console.WriteLine($"{str2}(2nd input) is before {str1} alphabetically");
            }
            else
            {
                Console.WriteLine("The strings are the same");
            }
        }
    }
}
