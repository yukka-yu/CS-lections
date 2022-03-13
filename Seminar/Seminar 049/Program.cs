// 49. Показать двумерный массив размером m×n заполненный вещественными числами
double[,] Arr = new double [2, 3];

for (int i = 0; i < Arr.GetLength(0); i ++)
{
      for (int j = 0; j < Arr.GetLength(1); j ++)
      {
                    Arr[i, j] = new Random.NextDouble();
                    Console.Write(Arr[i,j] + " ") ;
      }  
      Console.WriteLine(' ');     
}