using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acronym
{
    public class Acronym
    {
        public void ReadPhrase()
        {
           
            Console.WriteLine("Enter a phrase separated by spaces Exemple:To be discussed");
            string input = Console.ReadLine();
            IsPhraseValid(input);
        }

        public void IsPhraseValid(string input)
        {
            if (input.Contains(" "))
            {
                Console.WriteLine("Acronym for phrase is:");
                CreateAcronym(input);
                return;
            }
            else
            {
                Console.WriteLine("please enter a phrase with words separated by spaces");
                ReadPhrase();
            }
        }
        public void CreateAcronym(string input)
        {
           
            string[] splited = input.Split(" ");
            for (int i = 0; i < splited.Length; i++)
            {
                char[] firstWord = splited[i].ToCharArray();
                Console.Write(firstWord[0].ToString().ToUpper());
            }
        }
    }
}
