namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            int valid = 0;

            valid = CharactersLong(password, valid);

            valid = LettersAndDigits(password, valid);

            valid = TwoDigits(password, valid);

            IsValid(valid);
        }

        private static void IsValid(int valid)
        {
            if (valid == 0)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static int TwoDigits(string password, int valid)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= '0') && (password[i] <= '9'))
                {
                    count++;
                }
            }

            if (!password.Any(char.IsDigit) || count == 1)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid++;
            }

            return valid;
        }

        private static int LettersAndDigits(string password, int valid)
        {
            if (password.Contains("-") || password.Contains("=") || password.Contains("+") || password.Contains("!") || password.Contains("[") || password.Contains("]") || password.Contains("$") ||
                password.Contains("|") || password.Contains("@") || password.Contains("#") || password.Contains("%") || password.Contains("^") || password.Contains("&") || password.Contains("*") ||
                password.Contains("(") || password.Contains(")") || password.Contains("_") || password.Contains("`") || password.Contains("~"))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valid++;
            }

            return valid;
        }

        private static int CharactersLong(string password, int valid)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid++;
            }

            return valid;
        }
    }
}
