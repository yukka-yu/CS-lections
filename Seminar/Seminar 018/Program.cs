// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// Поскольку утверждение симметрично, проверить нужно три случая: 0,1; 1,1; 0,0

int flag = 0;
bool x = true, y = true;
if (!(x | y) == ((!x) & (!y))) flag++;
bool a = true, b = false;
if (!(a | b) == (!a & !b)) flag ++;
bool c = false, d = false;
if (!(c | d) == (!c & !d)) flag ++;

if (flag == 3) Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно");
else Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ложно");
