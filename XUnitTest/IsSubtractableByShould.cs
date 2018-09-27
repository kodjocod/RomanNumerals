using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFluent;
using RomanNumeralsKata;
using Xunit;

namespace RomanNumeralKataUnitTest
{
    public class IsSubtractableByShould
    {
        [Fact]
        public void return_true_when_the_next_roman_symbol_value_can_be_substracted_by_the_previous_one()
        {
            string romanSymbol = "IX";
            RomanNumeral romanNumeral = new RomanNumeral();
            bool answerBeSubtracted = romanNumeral.IsSubtractableBy(romanSymbol);

            Check.That(answerBeSubtracted).IsEqualTo(true);
        }
        [Fact]
        public void return_false_when_the_next_roman_symbol_value_cannot_be_substracted_by_the_previous_one()
        {
            string romanSymbol = "IL";
            RomanNumeral romanNumeral = new RomanNumeral();
            Check.ThatCode(() => romanNumeral.IsSubtractableBy(romanSymbol)).Throws<NonSubstractableException>();
        }

    }
}
