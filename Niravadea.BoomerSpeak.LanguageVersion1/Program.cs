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
                acc = accumulatorFunction(acc, c);
            }
            string result = acc.GetAccumulatedString();
            Console.WriteLine(result);
        }

        static Accumulator accumulatorFunction(Accumulator accumulator, char c)
        {
            // check if the letter is subject to cap switching
            if (char.IsLetter(c))
            {
                char newChar;
                if (accumulator.CapitalizationEligible)
                {
                    newChar = char.ToLower(c);
                }
                else
                {
                    newChar = char.ToUpper(c);
                }
                StringBuilder tempAccumulator = accumulator.AccumulatedString.Append(newChar);
                Accumulator returnValue = new Accumulator(tempAccumulator, !accumulator.CapitalizationEligible);
                return returnValue;
            }
            else
            {
                StringBuilder tempAccumulator = accumulator.AccumulatedString.Append(c);
                Accumulator returnValue = new Accumulator(tempAccumulator, accumulator.CapitalizationEligible);
                return returnValue;
            }
        }
    }
}
