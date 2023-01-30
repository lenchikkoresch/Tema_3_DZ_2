/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введие трехзначное число");

int GetNumber()
{
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
return number;
}

int SecondNumber(int number)
{
int c = ((number/10)%10);
return c;
}
int number = GetNumber();
int count = number.ToString().Length;
int result = SecondNumber(number);

if (count < 3 || count > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine($"Было {number}, стало {result}.");
}
