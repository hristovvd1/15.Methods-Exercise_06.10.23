namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            if (second < first)
            {
                char swap = first;
                first = second;
                second = swap;
            }

            Print(first, second);
        }

        private static void Print(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
