namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int minNumber = GetMinNumber(number1, number2);
            minNumber = GetMinNumber(minNumber, number3);

            Console.WriteLine(minNumber);
        }

        private static int GetMinNumber(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
