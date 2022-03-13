// 50. В двумерном массиве n×k заменить четные элементы на противоположные
int[,] Arr = new int [2, 3];

for (int i = 0; i < Arr.GetLength(0); i ++)
{
      for (int j = 0; j < Arr.GetLength(1); j ++)
      {
                    Arr[i, j] = new Random().Next(0, 100);
                    Console.Write(Arr[i,j] + " ") ;
      }  
      Console.WriteLine(' ');     
}

for (int i = 0; i < Arr.GetLength(0); i ++)
{
      for (int j = 0; j < Arr.GetLength(1); j ++)
      {
                    if (Arr[i, j] % 2 == 0) Arr[i,j] = -1 * Arr[i,j];
                    Console.Write(Arr[i,j] + " ") ;
      }  
      Console.WriteLine(' ');     
}
