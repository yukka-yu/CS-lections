// 40. В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементами
Console.WriteLine("Введите элементы массива через пробел");
int[] Arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int max = Arr[0], min = Arr[0];

for (int i = 1; i < Arr.Length; i ++)
{
              if (Arr[i] > max) max = Arr[i];
              else if (Arr[i] < min) min = Arr[i];
}
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + (max - min));