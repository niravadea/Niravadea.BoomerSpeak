using System;
using System.Text;

namespace Niravadea.BoomerSpeak.LanguageVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            Accumulator acc = new Accumulator();
            foreach(char c in source)
            {
                acc.Accumulate(c);
            }
            string result = acc.GetAccumulatedString();
            Console.WriteLine(result);
        }
    }
}
