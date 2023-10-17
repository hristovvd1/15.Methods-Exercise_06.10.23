namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factFirst = GetFactorial(num1);
            double factSecond = GetFactorial(num2);

            Console.WriteLine($"{(factFirst / factSecond):f2}");
        }

        private static double GetFactorial(int num)
        {
            double sum = 1;

            for (int i = 1; i <= num; i++)
            {
                sum = sum * i;
            }

            return sum;
        }
    }
}


