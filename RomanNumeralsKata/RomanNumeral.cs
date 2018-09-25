using System;

namespace RomanNumeralsKata

{
    public class RomanNumeral
    {
        private const string ROMAN_SYMBOL_FOR_1= "I";

        public string ConvertFrom(int arabicNumeral)
        {
            if (arabicNumeral == 4)
            {
                return "IV";
            }

            if (arabicNumeral == 5)
            {
                return "V";
            }
            if (arabicNumeral == 6)
            {
                return "VI";
            }

            return MultiplyByArabicNumber(arabicNumeral);
            
        }
        public string MultiplyByArabicNumber(int arabicNumber)
        {
            string convertedRomanNumeral="";
            
            for (int nb = 1; nb <= arabicNumber; nb++)
            {
                convertedRomanNumeral += ROMAN_SYMBOL_FOR_1;
            
            }
            return convertedRomanNumeral;
           
        }
    }
}