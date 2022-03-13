// 61. Найти произведение двух матриц
// Произведение двух матриц возможно только если они выглядят как A[m,n] и B[n,k]

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

int[,] A = new int[,]
{
              {1, 2, 3},
              {4, 5, 6},
};

int[,] B = new int[,]
{
              {1, 2, 3, 4},
              {4, 5, 6, 7},
              {1, 2, 3, 4}           
};


if (A.GetLength(1) != B.GetLength(0)) Console.WriteLine("Эти матрицы невозможно перемножить");
else
{
              int[,] C = new int[A.GetLength(0),B.GetLength(1)];
              for (int k = 0; k < A.GetLength(0); k++)
              {              
                            for (int l = 0; l < B.GetLength(1); l++)
                            {
                                          for (int i = 0; i < A.GetLength(1); i++)
                                          {              
                                                        for(int j = 0; j < B.GetLength(0); j++)
                                                        {
                                                                      C[k,l] += A[k,i] * B[j,l]; 
                                                        }
                                          }
                            }
              }
              PrintArray(C);
}