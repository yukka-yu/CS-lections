// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

int[,] Arr = new int[,]
{
              {2, 45, 12, 51},
              {6, 7, 8, 3},
              {1, 5, 65, 78},
              {6, 3, 151, 5},
              {5, 1, 86, 95}
};

PrintArray(Arr);
Console.WriteLine(String.Empty);

double[] ArifmeticalMedium = new double[Arr.GetLength(1)];

for (int i = 0; i < Arr.GetLength(1); i++) 
{ 
              for (int j = 0; j < Arr.GetLength(0); j++) 
              { 
                            ArifmeticalMedium[i] += (double)Arr[j,i]/Arr.GetLength(0); 
              } 
              Console.WriteLine($"Среднее арифметическое столбца {i} - {ArifmeticalMedium[i]}"); 
} 