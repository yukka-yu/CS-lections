// 41. Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine("Введите сторону a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону c");
int c = int.Parse(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a) Console.WriteLine('Треугольник с такими сторонами существует')ж
else Console.WriteLine('Треугольник с такими сторонами не может существовать');