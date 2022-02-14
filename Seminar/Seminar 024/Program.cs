// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i < N + 1)
{
              Console.WriteLine($"{i}---{i * i *i}");
              i ++;
}