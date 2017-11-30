using System;

namespace exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some words: ");
            var input = Console.ReadLine();
            var hold = input.Split(' ');
            var variableName = "";

            foreach (var word in hold)
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
            Console.ReadLine();
        }
    }
}
