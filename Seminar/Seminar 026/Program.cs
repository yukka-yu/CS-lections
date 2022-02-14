// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

int i = 1;
int S = A;

while (i < B)
{
              S = S * A;
              i ++;
}

Console.WriteLine($"{A} в степени {B} равняется {S}");