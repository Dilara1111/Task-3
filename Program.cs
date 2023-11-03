using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string originalString = "Huseynova";
            string reversedString = ReverseWords(originalString);
            Console.WriteLine(reversedString);
        }

        static string ReverseWords(string input)
        {
            string[] words = input.Split(' '); // Stringi boşluq əsasında bölmək
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray(); // Hər bir sözü char array-ə çevirmək
                Array.Reverse(charArray); // Char array-dəki simvolların sırasını tərsinə çevirmək
                words[i] = new string(charArray); // Tərsinə çevrilmiş char array-i string kimi yaratmaq
            }
            return string.Join(" ", words); // Tərsinə çevrilmiş sözləri birləşdirmək və yeni string kimi qaytarmaq
        }
    }
}

