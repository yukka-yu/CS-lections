// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер координатной четверти, 1-4");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Для точки первой четверти x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("Для точки второй четверти x < 0, y > 0");
        break;
    //.............
    case 3:
        Console.WriteLine("Для точки третьей четверти x < 0, y < 0");
        break;
    default:
        Console.WriteLine("Для точки четвёртой четверти x > 0, y < 0");
        break;
}
