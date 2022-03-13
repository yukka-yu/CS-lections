// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
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

Console.WriteLine("Исходный массив");
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

if (array.GetLength(0) != array.GetLength(1)) Console.Write("Задача невыполнима");
else 
{
              for (int i = 0; i < array.GetLength(0); i++)
              {
                            for (int j = i+1; j < array.GetLength(1); j++)
                            {
                                          (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
                            }
              }
              
              Console.WriteLine("Измененный массив");
              PrintArray(array);
} 