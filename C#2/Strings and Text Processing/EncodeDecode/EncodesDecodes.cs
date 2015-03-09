//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
//letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

namespace EncodeDecode
{
    using System;
    using System.Text;
    class EncodesDecodes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.Write("Enter cipher: ");
            string cipher = Console.ReadLine();

            string encoded = Decode(input, cipher);
            string decoded = Decode(encoded, cipher);

            Console.WriteLine(encoded + "\n\r" + decoded);
        }

        private static string Decode(string input, string cipher)
        {
            StringBuilder result = new StringBuilder();
            int inputLetter;
            int cipherLetter;
            for (int current = 0; current < input.Length; current++)
            {
                inputLetter = (int)input[current];
                cipherLetter = (int)cipher[current % cipher.Length];
                result.Append((char)(inputLetter ^ cipherLetter));
            }
            return result.ToString();
        }
    }
}