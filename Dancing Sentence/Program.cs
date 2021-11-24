using System;
using System.Text;

namespace Dancing_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenca;
            StringBuilder sentencaDanca;

            int i = 0;
            int tamanhoString;
            sentenca = Console.ReadLine();
            sentencaDanca = new StringBuilder(sentenca);
            tamanhoString = sentenca.Length;

            while (i < tamanhoString)
            {
                if (sentenca[i] == ' ')
                {
                    sentencaDanca[i] = sentenca[i];
                }
                else if (Char.IsUpper(sentencaDanca[i]) && i % 2 != 0)
                {
                    sentencaDanca[i] = sentenca.ToLower()[i];
                }
                else if (Char.IsLower(sentencaDanca[i]) && i % 2 == 0)
                {
                    sentencaDanca[i] = sentenca.ToUpper()[i];
                }
                else
                {
                    sentencaDanca[i] = sentenca[i];
                }
                i++;
            }
            sentencaDanca.Append('\0');
            string final = sentencaDanca.ToString();
            Console.WriteLine(final);

        }
    }
}