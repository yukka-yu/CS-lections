// Написать программу масштабирования фигуры
//вершины фигуры списком (одной строкой): "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
int k = 2;
string coord = "(0,0) (2,0) (2,2) (0,2)";
var data = coord.Replace("(", "")
                .Replace(")", "")
                .Split(" ")
                .Select(item => item.Split(","))
                .ToArray();

for (int i = 0; i < data.Length; i ++)
{
              for (int j = 0; j < data[i].Length; j ++)
              {
                            data[i][j] = (k * int.Parse(data[i][j])).ToString();
              }
}
for (int i = 0; i < data.Length; i++)
{
              Console.Write($"({data[i][0]}, {data[i][1]}) ");
}


