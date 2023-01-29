/*Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет 
*/
Console.WriteLine("Введите два числа");
int GetNumber()
{
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);
return a;
}

 int a1 = GetNumber();
 int a2 = GetNumber();

 if (a1 * a1 == a2 || a2 * a2 == a1)
 {
    Console.WriteLine("Да");
 }
 else
 {
    Console.WriteLine("Нет");
 }
 
