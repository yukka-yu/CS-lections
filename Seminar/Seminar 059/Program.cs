// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,] matrix) 
{ 
              for (int i = 0; i < matrix.GetLength(0); i++) 
              { 
                            for (int j = 0; j < matrix.GetLength(1); j++)
              
                            {
                                          matrix[i, j] = new Random().Next(0, 100); 
                            }
                            Console.WriteLine(); 
              }
}

void PrintArray(int[,] matrix) 
{ 
              for (int i = 0; i < matrix.GetLength(0); i++) 
              { 
                            for (int j = 0; j < matrix.GetLength(1); j++)
              
                            {
                                          Console.Write(matrix[i, j] + " "); 
                            }
                            Console.WriteLine(); 
              }
}

int[,] Arr = new int[4, 5];
FillArray(Arr);
Console.WriteLine("Массив");
PrintArray(Arr);

int[] SumStr = new int[Arr.GetLength(0)];

for (int i = 0; i < Arr.GetLength(0); i ++)
{
              for (int j = 0; j < Arr.GetLength(1); j ++)
              {
                            SumStr[i] += Arr[i,j];
              }
}

int iMin = 0;
int min = SumStr[0];
for (int i = 0; i < SumStr.Length; i ++)
{
              if (SumStr[i] < min) 
              {
                            min = SumStr[i];
                            iMin = i;
              }
}

Console.WriteLine($"Минимальная сумма строки {min} достигается в {iMin} строке");