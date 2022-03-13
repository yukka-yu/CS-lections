// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен min
void FillArray(int[,] matrix) 
{ 
              for (int i = 0; i < matrix.GetLength(0); i++) 
              { 
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          matrix[i,j] = new Random().Next(0,100);
                            }
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

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

int aMin = array[0,0]; 
int iMin = 0; 
int jMin = 0;

for (int i = 0; i < array.GetLength(0); i++) 
{ 
              for (int j = 0; j < array.GetLength(1); j++)

              {
                            if (array[i, j] < aMin)
                            {
                                          aMin = array[i, j];
                                          iMin = i;
                                          jMin = j;
                            } 
              } 
}

Console.WriteLine(iMin + ", " + jMin);

for (int i = 0; i < array.GetLength(0); i++) 
{ 
              if (i != iMin)
              {            
                            for (int j = 0; j < array.GetLength(1); j++)

                            {
                                          if (j != jMin)
                                          {
                                                        Console.Write(array[i,j] + " ");
                                          } 
                            } 
              }
              Console.WriteLine("");
}