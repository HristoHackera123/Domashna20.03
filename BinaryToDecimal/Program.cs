namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a binary number");
            string input = Console.ReadLine();
            Console.WriteLine("Method 1 or 2");
            if (Console.ReadLine() == "1")
            {
                int result = Convert.ToInt32(input, 2);
                Console.WriteLine(result);
            }
            else
            {
                char[] usable = input.ToCharArray();
                double sum = 0;
                for (int i = 0; i < usable.Length; i++)
                {
                    if (usable[i] == '1')
                    {
                        sum += Math.Pow(2, usable.Length - i - 1);
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
