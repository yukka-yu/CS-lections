// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] Arr = new int[12];
int SumPositive = 0, SumNegative = 0;

for (int index = 0; index < 12; index ++)
{
              Arr[index] = new Random().Next(0, 10);
              if (Arr[index] > 0) SumPositive += Arr[index];
              else SumNegative += Arr[index];
}

Console.WriteLine($"Сумма положительных элементов массива {SumPositive}, сумма отрицательных {SumNegative}");