// Найти максимальное из трех чисел
int a = 3,  b = 5, c = 9;
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Наибольшее из трёх число " + max);