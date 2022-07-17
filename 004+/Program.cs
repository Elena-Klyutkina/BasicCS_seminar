// По заданному с клавиатуры номеру дня недели вывести его название

Console.WriteLine("Введите день недели: ");
string? s=Console.ReadLine();
int k=Convert.ToInt32(s);
switch (k)
{
    case 1:Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Номер дня недели введенн некорректно");
        break;
}