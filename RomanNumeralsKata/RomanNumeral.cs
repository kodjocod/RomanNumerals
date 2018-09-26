using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RomanNumeralsKata

{
    public class RomanNumeral
    {
        private const string ROMAN_SYMBOL_FOR_1 = "I";
        private const string ROMAN_SYMBOL_FOR_5 = "V";

        private readonly Dictionary<int, string> MatchArabicAndRomanSymbols = new Dictionary<int, string>
        {
            {10,"X"},
            {9,"IX" },
            {5,"V"},
            {4,"IV"},
            {1, "I"}

        };

        public string ConvertToRomanNumerals(int arabicNumeral)
        {
            var convertedNumber = string.Empty;

            foreach (var arabicNumber in MatchArabicAndRomanSymbols.Keys)
            {
                while (arabicNumeral >= arabicNumber)
                {
                    convertedNumber += MatchArabicAndRomanSymbols[arabicNumber];
                    arabicNumeral -= arabicNumber;
                }

            }

            return convertedNumber;
        }

        public  int ConvertToArabicNumber(string romanSymbol)
        {
            if (romanSymbol == "I")
            {
                return 1;
            }
            return 0;
        }
    }
}
