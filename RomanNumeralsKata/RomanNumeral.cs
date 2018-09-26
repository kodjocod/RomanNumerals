using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace RomanNumeralsKata

{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> MatchArabicAndRomanSymbols = new Dictionary<int, string>
        {
            {10,"X"},
            {9,"IX" },
            {5,"V"},
            {4,"IV"},
            {1, "I"}

        };

        private readonly Dictionary<string, int> MatchRomanSymbolsWithArabicNumbers = new Dictionary<string, int>
        {
            {"L",50 },
            {"XL",40 },
            { "X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
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

        public int ConvertToArabicNumber(string romanSymbol)
        {
            int convertedNumber = 0;

            while (romanSymbol.Length != 0)
            {
                foreach (var romanNumeral in MatchRomanSymbolsWithArabicNumbers.Keys)
                {
                    if (romanSymbol.Contains(romanNumeral))
                    {
                        convertedNumber += MatchRomanSymbolsWithArabicNumbers[romanNumeral];
                        var posRomanSymbolToDelete = romanSymbol.IndexOf(romanNumeral);
                        romanSymbol = romanSymbol.Remove(posRomanSymbolToDelete,romanNumeral.Length);
                    }

                }
            }
            return convertedNumber;
        }
    }
}
