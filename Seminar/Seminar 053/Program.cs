// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что его нет

void FillArray(int[,] matrix)
{
              for (int i = 0; i < matrix.GetLength(0); i ++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j ++)
                            {
                                          matrix[i,j] = new Random().Next(0,30);
                            }
              }
}

void PrintArray(int[,] matrix)
{
              for (int i = 0; i < matrix.GetLength(0); i ++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j ++)
                            {
                                          Console.Write(matrix[i,j] + " ");
                            }
                            Console.WriteLine(String.Empty);

              }
}

int[,] Arr = new int[4, 5];
FillArray(Arr);
PrintArray(Arr);

Console.WriteLine("Введите число");
int Find = int.Parse(Console.ReadLine());

int flag = 0;

for (int i = 0; i < Arr.GetLength(0); i ++)
{
              for (int j = 0; j < Arr.GetLength(1); j ++)
              {
                            if (Arr[i,j] == Find)
                            {
                                          Console.Write($"Искомый элемент находится на позиции [{i},{j}]");
                                          flag ++;
                            }
              }            
}

if (flag == 0) Console.WriteLine("В массиве нет искомого элемента");