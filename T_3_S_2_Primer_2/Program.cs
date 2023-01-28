/*Напишите программу, которая выводит случайное трехзначное число и 
удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
// Метод, который выводит случайное трехзначное число

int GetRandomNumber (int leftBound, int rightBound)
{
    int result = 0;
    Random rnd = new Random ();
    result = rnd.Next (leftBound, rightBound);
    return result;  

}

// Метод, который удаляет вторую цифру

int DeleteSecondNumber (int number)
{
int deletesecond = number /100*10 + number%10;
return deletesecond;
}

int number = GetRandomNumber (100,1000);
int deletesecond = DeleteSecondNumber(number);
Console.WriteLine($"Было {number} стало {deletesecond}");
