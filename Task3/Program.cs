// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 99)
{
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    int newNumber = leftDigit > rightDigit ? leftDigit : rightDigit;
    System.Console.WriteLine(newNumber);
}
else 
{
    System.Console.WriteLine("Вы ввели неверное число");
}