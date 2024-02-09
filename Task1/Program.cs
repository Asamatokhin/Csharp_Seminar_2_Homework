// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Примеры:

// a=50 => нет
// a=7 => нет
// a=322 => да


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv1 = number % 7;
int remDiv2 = number % 23;

if(remDiv1 == 0 && remDiv2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}