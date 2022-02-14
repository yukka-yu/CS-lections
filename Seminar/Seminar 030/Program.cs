// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

for (int i = 2; i < N + 1; i+=2)
{
              Console.Write(Math.Pow(i, 3) + " ");
}