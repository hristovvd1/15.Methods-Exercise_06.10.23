namespace _9.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = default;

            while ((command = Console.ReadLine()) != "END")
            {
                char[] commandArray = command.ToCharArray();
                Array.Reverse(commandArray);
                string commandReverse = new string(commandArray);

                IF(command, commandReverse);
            }
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
/*
     Друго решение:

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
 */
