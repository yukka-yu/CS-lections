// 56. Написать программу, которая обменивает элементы первой строки и последней строки
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

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++) 
{ 
              for (int j = 0; j < array.GetLength(1); j++) 
              {
                             array[i, j] = new Random().Next(0, 100);
                              
              } 
}

Console.WriteLine("Исходный массив");
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{  
              (array[0, j], array[array.GetLength(0)-1, j]) = (array[array.GetLength(0)-1, j], array[0, j]); 
}
Console.WriteLine("Измененный массив");
PrintArray(array); 
