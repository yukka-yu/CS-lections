// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

int Res = 1;

for (int i = 1; i < N + 1; i++)
{
              Res *= i;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равняется {Res}");