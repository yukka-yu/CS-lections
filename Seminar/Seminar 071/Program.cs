﻿// 71. Написать программу вычисления функции Аккермана
// A(m,n) = {n+1, m=0 || A(m-1,1) m>0, n=0 || A(m,n-1), m>0, n>0

int Akkerman(int m, int n)
{
              if (m == 0) return n+1;
              else if (n == 0) return(Akkerman(m-1, 1));
              else return(Akkerman(m-1, Akkerman(m, n-1)));
}

Console.WriteLine(Akkerman(1,2));