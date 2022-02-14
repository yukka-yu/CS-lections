// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координату х");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату у");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в первой четверти");
else if (x < 0 && y > 0) Console.WriteLine($"Точка с координатами ({x}, {y}) лежит во второй четверти");
else if (x < 0 && y < 0) Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в третьей четверти");
else Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в четвёртой четверти");

