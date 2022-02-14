// Найти расстояние между точками в пространстве 2D/3D (делаю для 3Д)
Console.WriteLine("Введите координаты точки A (три числа через запятую)");
int[] A = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
Console.WriteLine("Введите координаты точки B (три числа через запятую");
int[] B = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

double AB = Math.Pow(Math.Pow(A[0]-B[0], 2) + Math.Pow(A[1]-B[1], 2) + Math.Pow(A[2]-B[2], 2), 0.5);
Console.WriteLine("Расстояние между точками А и В " + AB);
