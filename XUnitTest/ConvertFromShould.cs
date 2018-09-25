using NFluent;
using RomanNumeralsKata;
using Xunit;

namespace RomanNumeralKataUnitTest
{
    public class ConvertFromShould
    {
        [Fact]
        public void return_I_when_the_arabic_number_is_1()
        {
            int arabicNumeral = 1;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber= romanNumeral.ConvertFrom(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("I");
        }
        [Fact]
        public void return_II_when_the_arabic_number_is_2()
        {
            int arabicNumeral = 2;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber= romanNumeral.ConvertFrom(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("II");
        }
        [Fact]
        public void return_III_when_the_arabic_number_is_3()
        {
            int arabicNumeral = 3;
            RomanNumeral romanNumeral = new RomanNumeral();

            string convertedNumber = romanNumeral.ConvertFrom(arabicNumeral);

            Check.That(convertedNumber).IsEqualTo("III");
        }

    }
}
