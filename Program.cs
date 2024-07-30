namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parth = @"C:\Users\Brill\Desktop\Новый текстовый документ (2).txt";
            if (!File.Exists(parth))
            {
                throw new FileNotFoundException();
            }
            Console.WriteLine(CountOfVowel(parth));
            Console.WriteLine(CountOfConsonants(parth));
            Console.WriteLine(CountOfLowerLetters(parth));
            Console.WriteLine(CountOfUpperLetters(parth));
            Console.WriteLine(CountOfNumbers(parth));


        }

        static int CountOfLines(string parth) => File.ReadAllLines(parth).Length + 1;
        
        static int CountOfUpperLetters(string parth)
        {
            int countOfUpperLetters = 0;
            string[] linesFromFile = File.ReadAllLines(parth);
            foreach (string line in linesFromFile)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if(char.IsUpper(line[i]))
                    {
                        countOfUpperLetters++;
                    }
                }
            }
            return countOfUpperLetters;
        }

        static int CountOfLowerLetters(string parth)
        {
            int countOfLowerLetters = 0;
            string[] linesFromFile = File.ReadAllLines(parth);
            foreach (string line in linesFromFile)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLower(line[i]))
                    {
                        countOfLowerLetters++;
                    }
                }
            }
            return countOfLowerLetters;
        }

        static int CountOfVowel(string parth)
        {
            int countOfVowel = 0;
            string[] linesFromFile = File.ReadAllLines(parth);
            foreach (string line in linesFromFile)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.ToLower(line[i]) == 'a' || char.ToLower(line[i]) == 'e' || char.ToLower(line[i]) == 'i' || char.ToLower(line[i]) == 'o' || char.ToLower(line[i]) == 'u')
                    {
                        countOfVowel++;
                    }
                }
            }
            return countOfVowel;
        }

        static int CountOfConsonants(string parth)
        {
            int countOfConsonants = 0;
            string[] linesFromFile = File.ReadAllLines(parth);
            foreach (string line in linesFromFile)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(line[i])))
                    {
                        countOfConsonants++;
                    }
                }
            }
            return countOfConsonants;
        }

        static int CountOfNumbers(string parth)
        {
            int countOfNumberss = 0;
            string[] linesFromFile = File.ReadAllLines(parth);
            foreach (string line in linesFromFile)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsDigit(line[i]))
                    {
                    countOfNumberss++;
                    }
                }
            }
            return countOfNumberss;
        }
    }
}

//Пользователь вводит путь к файлу. Приложение отображает статистическую информацию о файле:
// Количество предложений
// Количество больших букв
// Количество маленьких букв
// Количество гласных букв
// Количество согласных букв
// Количество цифр