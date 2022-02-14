// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] Arr = new int[123];
int Count = 0;
for (int i = 0; i < 123; i ++)
{
              Arr[i] = new Random().Next(0, 1000);
              Console.Write(Arr[i] + " ");
              if (9 < Arr[i] && Arr[i] < 100) Count ++;
}
Console.WriteLine($"В отрезок [10,99] попадают {Count} из 123 элементов массива");