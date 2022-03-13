// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());

if (k1 == k2) Console.WriteLine("Прямые параллельны и не имеют точки пересечения");
else 
Console.WriteLine($"Координаты точки пересечения х0 = {(b2-b1)/(k1-k2)}, y0 = {k1*(b2-b1)/(k1-k2) + b1}");