// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. При нечётном количестве элементов средний элемент возводится в квадрат.

Console.WriteLine("Введите количество элемментов массива");
int L = int.Parse(Console.ReadLine());

int[] Array = new int[L];
int[] Res = new int[(L + 1) / 2];

for(int i = 0; i < L; i++)
{
              Array[i] = new Random().Next(1, 20);
              Console.Write(Array[i] + " ");
}

Console.WriteLine("");

for(int i = 0; i < (L + 1) / 2; i ++)
{
              Res[i]= Array[i] * Array[^ (i + 1)];
              Console.Write(Res[i] + " ");
}