using System;

namespace RomanNumeralsKata

{
    public class RomanNumeral
    {

        public string ConvertFrom(int arabicNumeral)
        {
            return MultiplyByArabicNumber(arabicNumeral);
            
        }
        public string MultiplyByArabicNumber(int arabicNumber)
        {
            string convertedRomanNumeral="";
            
            for (int nb = 1; nb <= arabicNumber; nb++)
            {
                convertedRomanNumeral += "I";
            }

            return convertedRomanNumeral;
           
        }
    }
}