namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int middleChar = name.Length;

            Result(name, middleChar);
        }

        private static void Result(string name, int middleChar)
        {
            if (middleChar % 2 == 0)
            {
                int lenght1 = middleChar / 2;
                Console.WriteLine($"{name[lenght1 - 1]}{name[lenght1]}");
            }

            else
            {
                int lenght = middleChar / 2;
                Console.WriteLine(name[lenght]);
            }
        }
    }
}
