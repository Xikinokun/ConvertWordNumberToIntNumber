using System;
using System.Collections.Generic;
using Xunit;

namespace ConvertStringNumberToIntNumber
{
    /*
     * ones - check
     * teens - check
     * hundreds - check
     * thousands
     * hundred trousands
     * millions - check
     * 
     */
    public class ConvertWordNumberToIntNumberUnitTest
    {
        public ConvertWordNumberToIntNumber convert = new ConvertWordNumberToIntNumber();

        [Fact]
        public void TestWordsOnesOne()
        {
            string text = "îäèí";
            Assert.Equal(1, convert.ConvertOnesWordNumberToOnesIntNumber(text));
        }
        
        [Fact]
        public void TestWordsOnesTwo()
        {
            string text = "äâà";
            Assert.Equal(2, convert.ConvertOnesWordNumberToOnesIntNumber(text));
        }

        [Fact]
        public void TestWordsTeensEleven()
        {
            string text = "îäèííàäöàòü";
            Assert.Equal(11, convert.ConvertTeensWordNumberToTeensIntNumber(text));
        }
        
        [Fact]
        public void TestWordsTeensTwelve()
        {
            string text = "äâåíàäöàòü";
            Assert.Equal(12, convert.ConvertTeensWordNumberToTeensIntNumber(text));
        }

        [Fact]
        public void TestWordsTensTen()
        {
            string text = "äåñÿòü";
            Assert.Equal(10, convert.ConvertTensWordNumberToTensIntNumber(text));
        }
        
        [Fact]
        public void TestWordsTensTwenty()
        {
            string text = "äâàäöàòü";
            Assert.Equal(20, convert.ConvertTensWordNumberToTensIntNumber(text));
        }

        [Fact]
        public void TestWordsHundredsHundred()
        {
            string text = "ñòî";
            Assert.Equal(100, convert.ConvertHundredsWordNumberToHundredsIntNumber(text));
        }

        [Fact]
        public void TestWordsHundredsTwoHundred()
        {
            string text = "äâåñòè";
            Assert.Equal(200, convert.ConvertHundredsWordNumberToHundredsIntNumber(text));
        }

        [Fact]
        public void TestWordsOneMillion()
        {
            string text = "ìèëëèîí";
            Assert.Equal(1000000, convert.ConvertMillionsWordNumberToMillionsIntNumber(text));
        }

        [Fact]
        public void TestWordTwentyMillion()
        {
            string text = "äâàäöàòü ìèëëèîíîâ";
            Assert.Equal(20000000, convert.ConvertTwentyMillionWordNumberToIntNumber(text));
        }
    }
}
