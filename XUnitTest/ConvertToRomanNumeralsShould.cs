using System.Linq;
using NFluent;
using RomanNumeralsKata;
using Xunit;

namespace RomanNumeralKataUnitTest
{
    public class ConvertToRomanNumeralsShould
    {
        [Fact]
        public void return_I_when_the_arabic_number_is_1()
        {
            int arabicNumeral = 1;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber= romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("I");
        }
        [Fact]
        public void return_II_when_the_arabic_number_is_2()
        {
            int arabicNumeral = 2;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber= romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("II");
        }
        [Fact]
        public void return_III_when_the_arabic_number_is_3()
        {
            int arabicNumeral = 3;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("III");
        }

        [Fact]
        public void return_IV_when_the_arabic_number_is_4()
        {
            int arabicNumeral = 4;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("IV");
        }
        [Fact]
        public void return_V_when_the_arabic_number_is_5()
        {
            int arabicNumeral = 5;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("V");
        }

        [Fact]
        public void return_VI_when_the_arabic_number_is_6()
        {
            int arabicNumeral = 6;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("VI");
        }
        [Fact]
        public void return_IX_when_the_arabic_number_is_9()
        {
            int arabicNumeral = 9;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("IX");
        }
        [Fact]
        public void return_X_when_the_arabic_number_is_10()
        {
            int arabicNumeral = 10;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("X");
        }
        [Fact]
        public void return_XIII_when_the_arabic_number_is_13()
        {
            int arabicNumeral = 13;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("XIII");
        }
        [Fact]
        public void return_XXIV_when_the_arabic_number_is_24()
        {
            int arabicNumeral =24;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertToRomanNumerals(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("XXIV");
        }
    }


}
