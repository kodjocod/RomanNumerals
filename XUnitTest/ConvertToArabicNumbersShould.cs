using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using RomanNumeralsKata;
using Xunit;

namespace RomanNumeralKataUnitTest
{
    public class ConvertToArabicNumbersShould
    {
        [Fact]
        public void return_1_when_the_given_roman_symbol_is_I()
        {
            string romanSymbol="I";
            RomanNumeral romanNumeral = new RomanNumeral();
            string romanSymbol1 = romanSymbol;
            int convertedNumber1 = 0;
            while (romanSymbol1.Length != 0)
            {
                var positionOfRomanSymbolToDelete = 0;

                if (romanSymbol1.Contains("X"))
                {
                    convertedNumber1 += 10;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("X");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 1);
                }
                if (romanSymbol1.Contains("IV"))
                {
                    convertedNumber1 += 4;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("IV");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 2);
                }
                if (romanSymbol1.Contains("V"))
                {
                    convertedNumber1 += 5;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("V");
                    romanSymbol1= romanSymbol1.Remove(positionOfRomanSymbolToDelete,1);
                }


                if (romanSymbol1.Contains("I"))
                {
                    convertedNumber1 += 1;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("I");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 1);
                }
            }

            romanNumeral.ConvertToArabicNumber(romanSymbol1);
            int convertedNumber= convertedNumber1;
            Check.That(convertedNumber).IsEqualTo(1);
        }
        [Fact]
        public void return_3_when_the_given_roman_symbol_is_III()
        {
            string romanSymbol = "III";
            RomanNumeral romanNumeral = new RomanNumeral();
            string romanSymbol1 = romanSymbol;
            int convertedNumber1 = 0;
            while (romanSymbol1.Length != 0)
            {
                var positionOfRomanSymbolToDelete = 0;

                if (romanSymbol1.Contains("X"))
                {
                    convertedNumber1 += 10;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("X");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 1);
                }
                if (romanSymbol1.Contains("IV"))
                {
                    convertedNumber1 += 4;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("IV");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 2);
                }
                if (romanSymbol1.Contains("V"))
                {
                    convertedNumber1 += 5;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("V");
                    romanSymbol1= romanSymbol1.Remove(positionOfRomanSymbolToDelete,1);
                }


                if (romanSymbol1.Contains("I"))
                {
                    convertedNumber1 += 1;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("I");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 1);
                }
            }

            romanNumeral.ConvertToArabicNumber(romanSymbol1);
            int convertedNumber = convertedNumber1;
            Check.That(convertedNumber).IsEqualTo(3);
        }
        [Fact]
        public void return_4_when_the_given_roman_symbol_is_IV()
        {
            string romanSymbol = "IV";
            RomanNumeral romanNumeral = new RomanNumeral();

            string romanSymbol1 = romanSymbol;
            int convertedNumber1 = 0;
            while (romanSymbol1.Length != 0)
            {
                var positionOfRomanSymbolToDelete = 0;

                if (romanSymbol1.Contains("X"))
                {
                    convertedNumber1 += 10;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("X");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 1);
                }
                if (romanSymbol1.Contains("IV"))
                {
                    convertedNumber1 += 4;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("IV");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 2);
                }
                if (romanSymbol1.Contains("V"))
                {
                    convertedNumber1 += 5;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("V");
                    romanSymbol1= romanSymbol1.Remove(positionOfRomanSymbolToDelete,1);
                }


                if (romanSymbol1.Contains("I"))
                {
                    convertedNumber1 += 1;
                    positionOfRomanSymbolToDelete = romanSymbol1.IndexOf("I");
                    romanSymbol1 = romanSymbol1.Remove(positionOfRomanSymbolToDelete, 1);
                }
            }

            romanNumeral.ConvertToArabicNumber(romanSymbol1);
            int convertedNumber = convertedNumber1;

            Check.That(convertedNumber).IsEqualTo(4);
        }
        [Fact]
        public void return_22_when_the_given_roman_symbol_is_XXII()
        {
            string romanSymbol = "XXII";
            RomanNumeral romanNumeral = new RomanNumeral();

            int convertedNumber =romanNumeral.ConvertToArabicNumber(romanSymbol);
            Check.That(convertedNumber).IsEqualTo(22);
        }

        [Fact]
        public void return_39_when_the_given_roman_symbol_is_XXXIX()
        {
            string romanSymbol = "XXXIX";
            RomanNumeral romanNumeral = new RomanNumeral();

            int convertedNumber = romanNumeral.ConvertToArabicNumber(romanSymbol);

            Check.That(convertedNumber).IsEqualTo(39);
        }

        //[Fact]
        //public void return_43_when_the_given_roman_symbol_is_XLIII()
        //{
        //    string romanSymbol = "XLIII";
        //    RomanNumeral romanNumeral = new RomanNumeral();

        //    int convertedNumber = romanNumeral.ConvertToArabicNumber(romanSymbol);

        //    Check.That(convertedNumber).IsEqualTo(43);
        //}

    }
}
