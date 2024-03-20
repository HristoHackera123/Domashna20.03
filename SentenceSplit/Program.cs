using System.Threading.Channels;

namespace SentenceSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            char[] result = sentence.ToCharArray();
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
