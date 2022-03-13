// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
int[,] Arr = new int[4, 5];
for (int i = 0; i < Arr.GetLength(0); i++) 
{ 
              for (int j = 0; j < Arr.GetLength(1); j++) 
              { 
                            Arr[i, j] = i + j;
                            Console.Write(Arr[i, j] + " "); 
              } 
              Console.WriteLine(); 
} 