using System;
using System.Collections.Generic;

namespace ConvertStringNumberToIntNumber
{
    public class ConvertWordNumberToIntNumber
    {

        public int ConvertHundredsWordNumberToHundredsIntNumber(string text)
        {
            var splittedText = text.Split(" ");
            var hundred = new Dictionary<string, int>() { { "сто", 100 }, { "двести", 200 } };
            var resultNumber = 1;
            foreach (var item in splittedText)
            {
                if (hundred.ContainsKey(item))
                {
                    resultNumber *= hundred[item];
                }
            }
            return resultNumber;
        }

        public int ConvertMillionsWordNumberToMillionsIntNumber(string text)
        {
            var splittedText = text.Split(" ");
            var millions = new Dictionary<string, int>() { { "миллион", 1000000 }, { "миллионов", 1000000 } };
            var resultNumber = 1;
            foreach (var item in splittedText)
            {
                if (millions.ContainsKey(item))
                {
                    resultNumber *= millions[item];
                }
            }
            return resultNumber;
        }

        public int ConvertOnesWordNumberToOnesIntNumber(string text)
        {
            var splittedText = text.Split(" ");
            var ones = new string[] { "один", "два", "три" };
            var resultNumber = 0;
            foreach (var item in splittedText)
            {
                int number = Array.IndexOf(ones, item) + 1;
                if (number > 0)
                {
                    resultNumber = number;
                }
            }
            return resultNumber;
        }

        public int ConvertTeensWordNumberToTeensIntNumber(string text)
        {
            var splittedText = text.Split(" ");
            var ones = new string[] { "одиннадцать", "двенадцать" };
            var resultNumber = 0;
            foreach (var item in splittedText)
            {
                int number = Array.IndexOf(ones, item) + 1;
                if (number > 0)
                {
                    resultNumber = number + 10;
                }
            }
            return resultNumber;
        }

        public int ConvertTensWordNumberToTensIntNumber(string text)
        {
            var splittedText = text.Split(" ");
            var ones = new string[] { "десять", "двадцать" };
            var resultNumber = 0;
            foreach (var item in splittedText)
            {
                int number = Array.IndexOf(ones, item) + 1;
                if (number > 0)
                {
                    resultNumber = number * 10;
                }
            }
            return resultNumber;
        }

        public int ConvertTwentyMillionWordNumberToIntNumber(string text)
        {
            var splittedText = text.Split(" ");
            var resultTens = 0;
            var resultMillions = 1;
            foreach (var item in splittedText)
            {
                resultTens += ConvertTensWordNumberToTensIntNumber(item);
                resultMillions *= ConvertMillionsWordNumberToMillionsIntNumber(item);
            }

            return resultTens * resultMillions;
        }
    }
}