// 42. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите числа через пробел");
double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

int count = 0;
for (int i = 0; i < array.Length; i ++)
{
              if (array[i] > 0) count ++;
}
Console.WriteLine($"Среди введённых чисел {count} положительных");