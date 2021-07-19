using System;
using System.Collections.Generic;
using Xunit;

namespace ConvertStringNumberToIntNumber
{
    /*
     * �������������� ������ - check
     * �������������� �������� - check
     * ����� - check
     * �����
     * ����� �����
     * ��������� - check
     * 
     */
    public class ConvertWordNumberToIntNumberUnitTest
    {
        public ConvertWordNumberToIntNumber convert = new ConvertWordNumberToIntNumber();

        [Fact]
        public void TestWordsOnesOne()
        {
            string text = "����";
            Assert.Equal(1, convert.ConvertOnesWordNumberToOnesIntNumber(text));
        }
        
        [Fact]
        public void TestWordsOnesTwo()
        {
            string text = "���";
            Assert.Equal(2, convert.ConvertOnesWordNumberToOnesIntNumber(text));
        }

        [Fact]
        public void TestWordsTeensEleven()
        {
            string text = "�����������";
            Assert.Equal(11, convert.ConvertTeensWordNumberToTeensIntNumber(text));
        }
        
        [Fact]
        public void TestWordsTeensTwelve()
        {
            string text = "����������";
            Assert.Equal(12, convert.ConvertTeensWordNumberToTeensIntNumber(text));
        }

        [Fact]
        public void TestWordsTensTen()
        {
            string text = "������";
            Assert.Equal(10, convert.ConvertTensWordNumberToTensIntNumber(text));
        }
        
        [Fact]
        public void TestWordsTensTwenty()
        {
            string text = "��������";
            Assert.Equal(20, convert.ConvertTensWordNumberToTensIntNumber(text));
        }

        [Fact]
        public void TestWordsHundredsHundred()
        {
            string text = "���";
            Assert.Equal(100, convert.ConvertHundredsWordNumberToHundredsIntNumber(text));
        }

        [Fact]
        public void TestWordsHundredsTwoHundred()
        {
            string text = "������";
            Assert.Equal(200, convert.ConvertHundredsWordNumberToHundredsIntNumber(text));
        }

        [Fact]
        public void TestWordsOneMillion()
        {
            string text = "�������";
            Assert.Equal(1000000, convert.ConvertMillionsWordNumberToMillionsIntNumber(text));
        }

        [Fact]
        public void TestWordTwentyMillion()
        {
            string text = "�������� ���������";
            Assert.Equal(20000000, convert.ConvertTwentyMillionWordNumberToIntNumber(text));
        }
    }
}
