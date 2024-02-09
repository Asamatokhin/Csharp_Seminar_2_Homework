// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

System.Console.WriteLine("Введите координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Координаты лежат в плоскости 1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Координаты лежат в плоскости 2");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Координаты лежат в плоскости 3");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Координаты лежат в плоскости 4");
}
else
{
    System.Console.WriteLine("Вы ввели неверные координаты");
}