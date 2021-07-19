using System;
using System.Collections.Generic;
using Xunit;

namespace ConvertStringNumberToIntNumber
{
    /*
     * преобразование единиц - check
     * преобразование десятков - check
     * сотен - check
     * тысяч
     * сотни тысяч
     * миллионов - check
     * 
     */
    public class ConvertWordNumberToIntNumberUnitTest
    {
        public ConvertWordNumberToIntNumber convert = new ConvertWordNumberToIntNumber();

        [Fact]
        public void TestWordsOnesOne()
        {
            string text = "один";
            Assert.Equal(1, convert.ConvertOnesWordNumberToOnesIntNumber(text));
        }
        
        [Fact]
        public void TestWordsOnesTwo()
        {
            string text = "два";
            Assert.Equal(2, convert.ConvertOnesWordNumberToOnesIntNumber(text));
        }

        [Fact]
        public void TestWordsTeensEleven()
        {
            string text = "одиннадцать";
            Assert.Equal(11, convert.ConvertTeensWordNumberToTeensIntNumber(text));
        }
        
        [Fact]
        public void TestWordsTeensTwelve()
        {
            string text = "двенадцать";
            Assert.Equal(12, convert.ConvertTeensWordNumberToTeensIntNumber(text));
        }

        [Fact]
        public void TestWordsTensTen()
        {
            string text = "десять";
            Assert.Equal(10, convert.ConvertTensWordNumberToTensIntNumber(text));
        }
        
        [Fact]
        public void TestWordsTensTwenty()
        {
            string text = "двадцать";
            Assert.Equal(20, convert.ConvertTensWordNumberToTensIntNumber(text));
        }

        [Fact]
        public void TestWordsHundredsHundred()
        {
            string text = "сто";
            Assert.Equal(100, convert.ConvertHundredsWordNumberToHundredsIntNumber(text));
        }

        [Fact]
        public void TestWordsHundredsTwoHundred()
        {
            string text = "двести";
            Assert.Equal(200, convert.ConvertHundredsWordNumberToHundredsIntNumber(text));
        }

        [Fact]
        public void TestWordsOneMillion()
        {
            string text = "миллион";
            Assert.Equal(1000000, convert.ConvertMillionsWordNumberToMillionsIntNumber(text));
        }

        [Fact]
        public void TestWordTwentyMillion()
        {
            string text = "двадцать миллионов";
            Assert.Equal(20000000, convert.ConvertTwentyMillionWordNumberToIntNumber(text));
        }
    }
}
