// Дано число больше 9. Вывести на экран вторую цифру числа с конца


System.Console.Write("Введите целое число больше 9: ");
string? s = Console.ReadLine();
int d=Convert.ToInt32(s);
int a=d/10%10;
System.Console.WriteLine("Вторая цифра введенного числа с конца: " + $"{a}");


/*
int a=1987659;
int b=a/10;
// int c=a%10;
int d=a/10%10;
// System.Console.WriteLine(b);
// System.Console.WriteLine(c);
System.Console.WriteLine(d);
*/