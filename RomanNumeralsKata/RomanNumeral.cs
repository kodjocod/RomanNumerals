using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            int convertedNumber = 0;
            while (romanSymbol.Length != 0)
            {
                var positionOfRomanSymbolToDelete = 0;

                if (romanSymbol.Contains("X"))
                {
                    convertedNumber += 10;
                    positionOfRomanSymbolToDelete = romanSymbol.IndexOf("X");
                    romanSymbol = romanSymbol.Remove(positionOfRomanSymbolToDelete, 1);
                }
                if (romanSymbol.Contains("IV"))
                {
                    convertedNumber += 4;
                    positionOfRomanSymbolToDelete = romanSymbol.IndexOf("IV");
                    romanSymbol = romanSymbol.Remove(positionOfRomanSymbolToDelete, 2);
                }
                if (romanSymbol.Contains("V"))
                {
                    convertedNumber += 5;
                    positionOfRomanSymbolToDelete = romanSymbol.IndexOf("V");
                    romanSymbol= romanSymbol.Remove(positionOfRomanSymbolToDelete,1);
                }


                if (romanSymbol.Contains("I"))
                {
                    convertedNumber += 1;
                    positionOfRomanSymbolToDelete = romanSymbol.IndexOf("I");
                    romanSymbol = romanSymbol.Remove(positionOfRomanSymbolToDelete, 1);
                }
            }

            return convertedNumber;
            //if (romanSymbol == "IV")
            //{
            //    return 4;
            //}
            //if (romanSymbol == "I")
            //{
            //    return 1;
            //}

            //if (romanSymbol == "III")
            //{
            //    return 3;
            //}

            //return 0;
        }
    }
}
