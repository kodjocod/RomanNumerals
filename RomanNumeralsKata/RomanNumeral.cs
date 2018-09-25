using System;
using System.Linq;

namespace RomanNumeralsKata

{
    public class RomanNumeral
    {
        private const string ROMAN_SYMBOL_FOR_1= "I";

        public string ConvertFrom(int arabicNumeral)
        {
            if (arabicNumeral > 3)
            {
                return ConvertArabicNumber(arabicNumeral);
            }

            return MultiplyByArabicNumber(arabicNumeral);
            
        }

        private string ConvertArabicNumber(int arabicNumber)
        {
            if (arabicNumber == 4)
            {
                return "IV";
            }
            int nbOneSymbolToAdd = arabicNumber - 5;

            return  "V" + MultiplyByArabicNumber(nbOneSymbolToAdd);
            
        }

        public string MultiplyByArabicNumber(int arabicNumber)
        {
            string convertedRomanNumeral="";
            
            for (int iteratorIndex = 1; iteratorIndex <= arabicNumber; iteratorIndex++)
            {
                convertedRomanNumeral += ROMAN_SYMBOL_FOR_1;
            
            }

            return convertedRomanNumeral;

        }
    }
}