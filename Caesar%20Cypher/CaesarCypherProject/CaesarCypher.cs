using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypherProject
{
    public class CaesarCypher
    {
        private string word;
        private int key;
        private static string alphabet;

        public CaesarCypher(string userInput, int shiftValue)
        {
            word = userInput;
            key = shiftValue;
            alphabet = ("abcdefghijklmnopqrstuvwxyz");
        }
        public string Decrypt()
        {
            StringBuilder sb = new StringBuilder();
            for (int characterPosition = 0; characterPosition < word.Length; characterPosition++)
            {
                int index = alphabet.IndexOf(word[characterPosition]);
                index = index - key;
                if (index < 0)
                {
                    index = index + 26;
                }
                sb.Append(alphabet[index]);
            }

            return sb.ToString();
        }
        public string Encrypt()
        {
            StringBuilder sb = new StringBuilder();
            for (int characterPosition = 0; characterPosition < word.Length; characterPosition++)
            {
                string alphabet = ("abcdefghijklmnopqrstuvwxyz");
                int index = alphabet.IndexOf(word[characterPosition]);
                index = index + key;
                index = checkIndex(index);
                sb.Append(alphabet[index]);
            }

            return sb.ToString();
        }

        private static int checkIndex(int index)
        {
            if (index > 25)
            {
                index = index - 26;
            }

            return index;
        }
    }
}
