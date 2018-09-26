using System;
using System.Collections.Generic;
using System.Linq;

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
        //if (arabicNumeral > 3 && arabicNumeral < 9)
        //    {

        //        return ConvertArabicNumberFrom4To8(arabicNumeral);
        //    }

        //    if (arabicNumeral >= 9)
        //    {
        //        return ConvertArabicNumberFrom9toInfinit(arabicNumeral);
        //    }

        //    return MultiplyByArabicNumber(arabicNumeral);

        //}

        private string ConvertArabicNumberFrom9toInfinit(int arabicNumeral)
        {
            if (arabicNumeral == 9)
            {
                return "IX";
            }

            int nbOneSymbolToAdd = arabicNumeral - 10;

            return "X" + MultiplyByArabicNumber(nbOneSymbolToAdd);
        }

        private string ConvertArabicNumberFrom4To8(int arabicNumber)
        {
            if (arabicNumber == 4)
            {
                return "IV";
            }
            int nbOneSymbolToAdd = arabicNumber - 5;

            return ROMAN_SYMBOL_FOR_5 + MultiplyByArabicNumber(nbOneSymbolToAdd);

        }

        public string MultiplyByArabicNumber(int arabicNumber)
        {
            string convertedRomanNumeral = "";

            for (int iteratorIndex = 1; iteratorIndex <= arabicNumber; iteratorIndex++)
            {
                convertedRomanNumeral += ROMAN_SYMBOL_FOR_1;

            }

            return convertedRomanNumeral;

        }
    }
}
