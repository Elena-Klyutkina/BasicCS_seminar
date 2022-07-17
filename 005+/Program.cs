/// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a, b, c;
string? s1 = Console.ReadLine();
string? s2 = Console.ReadLine();
string? s3 = Console.ReadLine();
a = Convert.ToInt32(s1);
b = Convert.ToInt32(s2);
c = Convert.ToInt32(s3);
int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
System.Console.WriteLine("Максимальное число " + $"{max}");