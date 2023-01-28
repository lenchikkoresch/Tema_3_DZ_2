﻿/* Напишите программу. которая выводит случайные цифры из отрезка 
и показывает наибольшую цифру из числа:
Например:
78 -> 8
12 -> 2
85 -> 8 */


/*
1. метод, который получает случайное число
2. метод, который получает максимальную цифру числа
*/

//метод, который получает случайное число
int GetRandomNumber(int leftBound, int rightBound)
{
int result = 0;
Random rnd = new Random();

result = rnd.Next(leftBound, rightBound + 1);// [leftBoung, rightBound)
return result;
}

//метод, который получает максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
int firstDigit = number / 10;// 96 / 10 = 9,6 деление нацело на 10, первая цифра
int secondDigit = number % 10;

if(firstDigit > secondDigit)
return firstDigit;
else
return secondDigit;
}

int number = GetRandomNumber(10, 99);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");
