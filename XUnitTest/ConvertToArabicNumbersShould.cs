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

            int convertedNumber= romanNumeral.ConvertToArabicNumber(romanSymbol);

            Check.That(convertedNumber).IsEqualTo(1);
        }
        [Fact]
        public void return_3_when_the_given_roman_symbol_is_III()
        {
            string romanSymbol = "III";
            RomanNumeral romanNumeral = new RomanNumeral();
      
            int convertedNumber = romanNumeral.ConvertToArabicNumber(romanSymbol); 

            Check.That(convertedNumber).IsEqualTo(3);
        }
        [Fact]
        public void return_4_when_the_given_roman_symbol_is_IV()
        {
            string romanSymbol = "IV";
            RomanNumeral romanNumeral = new RomanNumeral();

           
            int convertedNumber = romanNumeral.ConvertToArabicNumber(romanSymbol); ;

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

        [Fact]
        public void return_43_when_the_given_roman_symbol_is_XLIII()
        {
            string romanSymbol = "XLIII";
            RomanNumeral romanNumeral = new RomanNumeral();

            int convertedNumber = romanNumeral.ConvertToArabicNumber(romanSymbol);

            Check.That(convertedNumber).IsEqualTo(43);
        }

    }
}
