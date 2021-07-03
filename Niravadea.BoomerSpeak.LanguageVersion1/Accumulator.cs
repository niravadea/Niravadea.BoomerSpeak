using System.Text;

namespace Niravadea.BoomerSpeak.LanguageVersion1
{
    public class Accumulator
    {
        StringBuilder _accumulatedString;
        bool _capitalizationEligible;

        public Accumulator()
        {
            _accumulatedString = new StringBuilder();
            _capitalizationEligible = false;
        }

        public Accumulator(StringBuilder accumulatedString, bool capitalizationEligible)
        {
            _accumulatedString = accumulatedString;
            _capitalizationEligible = capitalizationEligible;
        }

        public StringBuilder AccumulatedString
        {
            get
            {
                return _accumulatedString;
            }
            set
            {
                _accumulatedString = value;
            }
        }

        public bool CapitalizationEligible
        {
            get
            {
                return _capitalizationEligible;
            }
            set
            {
                _capitalizationEligible = value;
            }
        }

        public string GetAccumulatedString()
        {
            return _accumulatedString.ToString();
        }
    }
}
