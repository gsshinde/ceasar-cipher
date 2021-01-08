using System;

namespace CaesarCipher
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if(!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char) ((((ch + key) - d) % 26) + d);
        }

        public static string Decipher(string input, int key)
        {
            string output = string.Empty;
            foreach (char ch in input)
            {
                output += cipher(ch, key);
            }
            return output;
        }

        static void Main(string[] args)
        {
            string cipherText = "nrfzh";
            int key = 3;
        
            string decipherText = Decipher(cipherText, key);
            Console.WriteLine(decipherText);
            Console.ReadKey();
        }
    }
}
