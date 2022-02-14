// 38. Найти сумму чисел одномерного массива, стоящих на нечетной позиции
int SumOddPos(int[] array)
{
              int SumOddPos = 0;
              for (int i = 1;  i < array.Length; i += 2)
              {
                            SumOddPos += array[i];
              }
              return SumOddPos;
}

int[] Arr = new int[23];
for (int i = 0; i < 23; i++)
{
              Arr[i] = new Random().Next(1, 100);
              Console.Write(Arr[i] + " ");
}
int Res = SumOddPos(Arr);
Console.WriteLine("");
Console.WriteLine("Сумма элементов массива с нечётным индексом " + Res);

// Тут следует оговорить, что автор задачи понимает под нечётными позициями: 
// начинает он нумерацию с единицы или с нуля. Впрочем, это легко поправить.