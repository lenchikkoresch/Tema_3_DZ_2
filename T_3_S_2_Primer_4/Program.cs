/*Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число");
int GetNumber()
{string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);
return a;
}

int firsta = GetNumber();

if (firsta % 7 == 0 && firsta % 23 == 0 )
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("нет");
}


