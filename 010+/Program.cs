// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 


System.Console.Write("Введите целое число: ");
string? s = Console.ReadLine();
int d=Convert.ToInt32(s);
int a=d%10;
System.Console.WriteLine("Последняя цифра введенного числа: " + $"{a}");