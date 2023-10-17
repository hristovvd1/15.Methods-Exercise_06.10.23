namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().ToLower().Select(x => x.ToString()).ToArray();

            int count = vowelsCount(word);

            Console.WriteLine(count);
        }

        private static int vowelsCount(string[] word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == "a")
                {
                    count++;
                }

                if (word[i] == "e")
                {
                    count++;
                }

                if (word[i] == "i")
                {
                    count++;
                }

                if (word[i] == "o")
                {
                    count++;
                }

                if (word[i] == "u")
                {
                    count++;
                }
            }

            return count;
        }
    }
}

