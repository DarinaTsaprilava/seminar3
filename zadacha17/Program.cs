/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.WriteLine("Введите координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x < 0 && y < 0)
Console.WriteLine("Эта точка находится в плоскости 3");
if (x > 0 && y > 0)
Console.WriteLine("Эта точка находится в плоскости 1");
if (x < 0 && y > 0)
Console.WriteLine("Эта точка находится в плоскости 2");
if (x > 0 && y < 0)
Console.WriteLine("Эта точка находится в плоскости 4");



    