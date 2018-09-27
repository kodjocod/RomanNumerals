using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace RomanNumeralsKata
{
    public class RomanNumeral
    {
        private const int NB_ROMAN_SYMBOL_TO_DELETE = 2;
        private const int STARTING_POSITION_OF_ROMAN_SYMBOL = 0;
        private readonly Dictionary<int, string> FromArabicToRoman = new Dictionary<int, string>
        {

            {100,"C"},
            {50,"L"},
            {40,"XL"},
            { 10,"X"},
            {9,"IX" },
            {5,"V"},
            {4,"IV"},
            {1, "I"}

        };
        private readonly Dictionary<string, int> FromRomanToArabic = new Dictionary<string, int>
        {
     
            {"C",100 },
            {"L",50 },
            {"XL",40 },
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        };

        private readonly List<string> NonSubtractableSymbols = new List<string>
        {
           ("L")
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

            while (romanSymbol.Length != 0)
            {
                foreach (var romanNumeral in FromRomanToArabic.Keys)
                {
                    if(romanSymbol.Contains(romanNumeral))
                    {
                        if (IsSubtractableBy(romanSymbol))
                        {
                            var singleRomanSymbols = romanSymbol.ToCharArray().Select(character => character.ToString()).ToArray();
                            convertedNumber += FromRomanToArabic[singleRomanSymbols[1]] - FromRomanToArabic[singleRomanSymbols[0]];
                            romanSymbol= RemoveRomanNumeralsFrom(romanSymbol,romanNumeral,STARTING_POSITION_OF_ROMAN_SYMBOL,NB_ROMAN_SYMBOL_TO_DELETE);
                        }
                        else
                        {
                            convertedNumber += FromRomanToArabic[romanNumeral];
                            var posRomanSymbolToDelete = romanSymbol.IndexOf(romanNumeral, StringComparison.Ordinal);
                            romanSymbol = RemoveRomanNumeralsFrom(romanSymbol, romanNumeral, posRomanSymbolToDelete,
                                romanNumeral.Length);
                        }
                    }

                }
            }
            return convertedNumber;
        }

        public string RemoveRomanNumeralsFrom(string romanSymbol,string romanNumeral,int startPosition,int nbSymbolsToDelete)
        {
            var posRomanSymbolToDelete = romanSymbol.IndexOf(romanNumeral, StringComparison.Ordinal);
            return romanSymbol.Remove(startPosition, nbSymbolsToDelete);
        }

        public bool IsSubtractableBy(string romanSymbol)
        {

            if (romanSymbol.Length > 1)
            {
               var singleRomanSymbols = romanSymbol.ToCharArray().Select(character => character.ToString()).ToArray();

                if (FromRomanToArabic[singleRomanSymbols[1]] >
                    FromRomanToArabic[singleRomanSymbols[0]] && 
                    FromRomanToArabic[singleRomanSymbols[0]] % 10!=0 
                   && NonSubtractableSymbols.Contains(singleRomanSymbols[1]))
                {
                  throw  new NonSubstractableException();
                }
                if (FromRomanToArabic[singleRomanSymbols[0]] <
                    FromRomanToArabic[singleRomanSymbols[1]])
                {
                    return true;
                }

            }
            return false;
        }
    }

    public class NonSubstractableException : Exception
    {
        public NonSubstractableException() : base() { }

        public NonSubstractableException(string message)
            : base(message) { }


    }
}
