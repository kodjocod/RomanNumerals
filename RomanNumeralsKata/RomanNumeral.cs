using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace RomanNumeralsKata

{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> FromArabicToRoman = new Dictionary<int, string>
        {
            {10,"X"},
            {9,"IX" },
            {5,"V"},
            {4,"IV"},
            {1, "I"}

        };

        private readonly Dictionary<string, int> FromRomanToArabic = new Dictionary<string, int>
        {
     
            { "L",50 },
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

            foreach (var arabicNumber in FromArabicToRoman.Keys)
            {
                while (arabicNumeral >= arabicNumber)
                {
                    convertedNumber += FromArabicToRoman[arabicNumber];
                    arabicNumeral -= arabicNumber;
                }

            }

            return convertedNumber;
        }

        public int ConvertToArabicNumber(string romanSymbol)
        {
            int convertedNumber = 0;
            int posRomanSymbolToDelete = 0;

            while (romanSymbol.Length != 0)
            {
                foreach (var romanNumeral in FromRomanToArabic.Keys)
                {
                    if(romanSymbol.Contains(romanNumeral))
                    {
                        if (CanBeSubtracted(romanSymbol))
                        {
                            var singleRomanSymbols = romanSymbol.ToCharArray().Select(character => character.ToString()).ToArray();
                            convertedNumber += FromRomanToArabic[singleRomanSymbols[1]] - FromRomanToArabic[singleRomanSymbols[0]];
                            romanSymbol = romanSymbol.Remove(posRomanSymbolToDelete, 2);

                        }
                        else
                        {
                            convertedNumber += FromRomanToArabic[romanNumeral];
                            posRomanSymbolToDelete = romanSymbol.IndexOf(romanNumeral, StringComparison.Ordinal);
                            romanSymbol = romanSymbol.Remove(posRomanSymbolToDelete, romanNumeral.Length);
                        }
          
                       
                    }

                }
            }
            return convertedNumber;
        }

        public bool CanBeSubtracted(string romanSymbol)
        {
            if (romanSymbol.Length > 1)
            {
                var singleRomanSymbols = romanSymbol.ToCharArray().Select(character => character.ToString()).ToArray();
                if (FromRomanToArabic[singleRomanSymbols[0]] <
                    FromRomanToArabic[singleRomanSymbols[1]])
                {
                    return true;
                }
            }

            return false;
        }
    }
}