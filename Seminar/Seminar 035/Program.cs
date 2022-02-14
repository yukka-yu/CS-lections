// 35. Определить, присутствует ли в заданном массиве некоторое число
Console.WriteLine("Введите элементы массива через пробел");
int[] Arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Console.WriteLine("Какое число ищем?");
int find = int.Parse(Console.ReadLine());

int flag = 0;
for (int i = 0; i < Arr.Length; i++)
{
              if (Arr[i] == find) 
              {
                            flag += 1;
                            break;
              }
}

if (flag == 0) Console.WriteLine($"Числа {find} нет в массиве");
else Console.WriteLine($"Число {find} есть в массиве");