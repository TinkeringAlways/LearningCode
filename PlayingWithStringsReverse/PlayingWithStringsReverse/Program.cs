using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithStringsReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "awesome";

            char[] letters = new char[word.Length];

            letters = word.ToCharArray(0, word.Length);

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(letters[i]);
            }

            Console.ReadLine();

            int cnt = 0;
            char[] temp = new char[letters.Length];

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                temp[cnt] = letters[i];

                cnt++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }

            Console.ReadLine();
        }
    }
}
