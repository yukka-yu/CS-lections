// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int[] Arr = new int[20];
int SumOdd = 0, SumEven = 0;
for (int i = 0; i < 20; i ++)
{
              Arr[i] = new Random().Next(100, 1000);
              Console.Write(Arr[i] + " ");
              if (Arr[i] % 2 == 0) SumEven += Arr[i];
              else SumOdd += Arr[i];
}

Console.WriteLine($"Сумма нечётных элементов массива {SumOdd}, сумма чётных элементов {SumEven}");