// 60. Составить частотный словарь элементов двумерного массива.

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

int[,] Arr = new int[3,4];
FillArray(Arr);
Console.WriteLine("Исходный массив");
PrintArray(Arr);

int count = 0;

for (int k = 0; k < Arr.GetLength(0); k++) 
{ 
              for (int l = 0; l < Arr.GetLength(1); l++)
              {
                            for (int i = 0; i < Arr.GetLength(0); i++) 
                            { 
                                          for (int j = 0; j < Arr.GetLength(1); j++)
                                          {
                                                        if (Arr[i,j] == Arr[k,l])
                                                        {
                                                                      count++;
                                                        } 
                                          }
                            }
Console.WriteLine(Arr[k,l] + " " + count);
count = 0;
              }
}