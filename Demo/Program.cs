namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            while ((command = Console.ReadLine()) != "END")
            {
                string commandReverse = Reverse(command);

                IF(command, commandReverse);

            }
        }

        private static string Reverse(string command)
        {
            string commandReverse = string.Empty;

            for (int i = command.Length - 1; i >= 0; i--)
            {
                commandReverse += command[i];
            }

            return commandReverse;
        }

        private static void IF(string command, string commandReverse)
        {
            if (command == commandReverse)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }
    }
}