namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int secondSum = Sum(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(secondSum);
        }

        private static int Sum(int firstNumber, int secondNumber, int thirdNumber)
        {
            int firstSum = firstNumber + secondNumber;
            int secondSum = firstSum - thirdNumber;

            return secondSum;
        }
    }
}
