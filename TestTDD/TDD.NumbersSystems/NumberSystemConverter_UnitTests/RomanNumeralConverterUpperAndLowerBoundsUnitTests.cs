using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace NumberSystemConverter_UnitTests
{
    [TestClass]
    public class RomanNumeralConverterUpperAndLowerBoundsUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Zero_Throws_IndexOutOfRageException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(0);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Grater_Than_ThreeThousand_Throws_IndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(3001);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Less_Then_One_Throws_IndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(-1);
        }
    }
}
