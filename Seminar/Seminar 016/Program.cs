// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели - число от 1 до 7");
int x = int.Parse(Console.ReadLine());

if (x > 5) Console.WriteLine("Ура! Сегодня выходной!");
else Console.WriteLine("Увы, сегодня будний день..");
