﻿// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// 568 => 8,6,5
// 8 => 8
// 9542 => 2,4,5,9


Console.WriteLine("Введите натуральное  число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10)
{
    System.Console.WriteLine(number);
}
else
{
    while (number > 0)
    {
        int value = number % 10;
        number /= 10;
        if (number > 0)
        {
            System.Console.Write(value + ",");
        }
        else
        {
           System.Console.WriteLine(value); 
        }
    }
}