// 34. Написать программу замену элементов массива на противоположные

void ArrSignChange(int[] Arr)
{
              for (int index = 0; index < Arr.Length; index ++)
              {
                            Arr[index] = -Arr[index];
                            Console.Write(Arr[index] + " ");
              }
}

Console.WriteLine("Введите элементы массива через пробел");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
ArrSignChange(array);