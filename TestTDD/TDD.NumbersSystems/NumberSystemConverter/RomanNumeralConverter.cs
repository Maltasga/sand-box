using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSystemConverter
{
    #region Supporting Types
    enum RomanNumeralsType
    {
        M = 1000,
        D = 500,
        C = 100,
        L = 50,
        X = 10,
        V = 5,
        I = 1
    }

    internal class RomanNumeralPair
    {
        public int NumericValue { get; set; }
        public string RomanNumeralRepresentation { get; set; }
    }
    #endregion

    public class RomanNumeralConverter
    {
        private readonly IList<RomanNumeralPair> _romanNumeralList;

        public RomanNumeralConverter()
        {
            this._romanNumeralList = new List<RomanNumeralPair>()
            {
                new RomanNumeralPair()
                {
                    //... 1000
                    NumericValue = Convert.ToInt32(RomanNumeralsType.M),
                    RomanNumeralRepresentation = RomanNumeralsType.M.ToString()
                },
                new RomanNumeralPair()
                {
                    //... 500
                    NumericValue = Convert.ToInt32(RomanNumeralsType.D),
                    RomanNumeralRepresentation = RomanNumeralsType.D.ToString()
                },
                new RomanNumeralPair()
                {
                    //... 100
                    NumericValue = Convert.ToInt32(RomanNumeralsType.C),
                    RomanNumeralRepresentation = RomanNumeralsType.C.ToString()
                },
                new RomanNumeralPair()
                {
                    //... 50
                    NumericValue = Convert.ToInt32(RomanNumeralsType.L),
                    RomanNumeralRepresentation = RomanNumeralsType.L.ToString()
                },
                new RomanNumeralPair()
                {
                    //... 10
                    NumericValue = Convert.ToInt32(RomanNumeralsType.X),
                    RomanNumeralRepresentation = RomanNumeralsType.X.ToString()
                },
                new RomanNumeralPair()
                {
                    //... 5
                    NumericValue = Convert.ToInt32(RomanNumeralsType.V),
                    RomanNumeralRepresentation = RomanNumeralsType.V.ToString()
                },
                new RomanNumeralPair()
                {
                    //... 1
                    NumericValue = Convert.ToInt32(RomanNumeralsType.I),
                    RomanNumeralRepresentation = RomanNumeralsType.I.ToString()
                }
            };
        }

        public string ConvertRomanNumeral(int number)
        {
            if (number < 1 || number > 3000)
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 2000)");

            var strBuilder = new StringBuilder();
            foreach (var item in this._romanNumeralList)
            {
                while (number >= item.NumericValue)
                {
                    strBuilder.Append(item.RomanNumeralRepresentation);
                    number -= item.NumericValue;
                }
            }
            return strBuilder.ToString();
        }
    }
}
