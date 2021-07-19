using ConvertStringNumberToIntNumber;
using System;
using System.Collections.Generic;

namespace ConvertStringNumberToIntNumberConsole
{   /*
        Написать консольное приложение для конвертации русского текста. На вход поступает произвольный текст,
        на выходе должна получаться копия текста,
        но числа, записанные словами, должны заменятся на эквивалентные числовые представления. Пример:
        Вход: "Он заплатил двадцать миллионов за три таких автомобиля"
        Выход: "Он заплатил 20000000 за 3 таких автомобиля" - not full completed(not enought time)
     */
    class Program
    {
        static void Main(string[] args)
        {
            ConvertWordNumberToIntNumber convert = new ConvertWordNumberToIntNumber();
            Console.WriteLine(convert.ConvertTwentyMillionWordNumberToIntNumber("двадцать миллионов"));
        }
    }
}
