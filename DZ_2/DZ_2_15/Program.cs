/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число, обозначающее день недели");

int GetNumber()
{
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
return number;
}

int SundayNumber (int number)
{
    if ((number < 1) || (number > 7))
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if ((number == 6) || (number == 7))
    {
      Console.WriteLine("Да");
    }
    else
    {
    Console.WriteLine("Нет");
    }
}
return number; 
}

int number = GetNumber();
Console.Write(SundayNumber(number));

