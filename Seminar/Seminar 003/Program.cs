//По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = int.Parse(Console.ReadLine());
string [] Week = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.WriteLine("Это " + Week[number - 1]);
