using System;

namespace Acronym
{
    public class Acronym
    {
        private string phrase;

        public string Phrase { get => phrase; }



        public void ReadPhrase(string input)
        {
            string abreviated = string.Empty;
            Console.WriteLine("Enter a phrase separated by spaces Exemple:To be discussed");
            input = Console.ReadLine();
            IsPhraseValid(input);
            
        }

        public void IsPhraseValid(string input)
        {
            if(input.Contains(" "))
            {
                Console.WriteLine("email is ok!");
                CreateAcronym(input);
                return;
            }
            else
            {
                Console.WriteLine("email is not ok!");
                ReadPhrase(input);
            }
        }
        public void CreateAcronym(string input)
        {
            ReadPhrase(input);
            string [] splited = input.Split(" ");
            for (int i = 0; i < splited.Length; i++)
            {
                char[] firstWord = splited[i].ToCharArray();
                Console.Write(firstWord[0].ToString().ToUpper());
            }
        }
}
}
