using System.Text;

namespace Niravadea.BoomerSpeak.LanguageVersion1
{
    public class Accumulator
    {
        StringBuilder _accumulatedString = new StringBuilder();
        bool _capitalizationEligible = false;

        public void Accumulate(char c)
        {
            // check if the letter is subject to cap switching
            if (char.IsLetter(c))
            {
                char newChar;
                if (_capitalizationEligible)
                {
                    newChar = char.ToLower(c);
                }
                else
                {
                    newChar = char.ToUpper(c);
                }
                _accumulatedString.Append(newChar);
                _capitalizationEligible = !_capitalizationEligible;
            }
            else
            {
                _accumulatedString.Append(c);
            }
        }

        public string GetAccumulatedString()
        {
            return _accumulatedString.ToString();
        }
    }
}
