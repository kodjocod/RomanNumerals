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
    }
}
