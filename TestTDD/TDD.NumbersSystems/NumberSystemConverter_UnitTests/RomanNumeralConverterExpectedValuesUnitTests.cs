﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace NumberSystemConverter_UnitTests
{
    [TestClass]
    public class RomanNumeralConverterExpectedValuesUnitTests
    {
        [TestMethod]
        public void Numer_Equal_One_Expected_I()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(1);

            Assert.AreEqual(result, "I");
        }

        [TestMethod]
        public void Number_Equal_ThreeThousand_Expected_Result_MMM()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(3000);

            Assert.AreEqual(result, "MMM");
        }

        [TestMethod]
        public void Number_Equal_55_Expected_Result_LV()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(55);

            Assert.AreEqual(result, "LV");
        }

        [TestMethod]
        public void Number_Equal_100_Expected_Result_C()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(100);

            Assert.AreEqual(result, "C");
        }

        [TestMethod]
        public void Number_Equal_500_Expected_Result_D()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(500);

            Assert.AreEqual(result, "D");
        }

        [TestMethod]
        public void Number_Equal_599_Expected_Result_DLXXXXVIIII()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(599);

            Assert.AreEqual(result, "DLXXXXVIIII");
        }

        [TestMethod]
        public void Number_Equal_2013_Expected_Result_MMXIII()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(2013);

            Assert.AreEqual(result, "MMXIII");
        }
    }
}
