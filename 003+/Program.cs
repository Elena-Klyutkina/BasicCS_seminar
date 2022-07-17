// С клавиатуры вводятся два числа a и b. Найти максимальное из них.


// Ввод целых чисел
int a,b;
string? c=Console.ReadLine();
string? d=Console.ReadLine();
a=Convert.ToInt32(c);
b=Convert.ToInt32(d);

if (a>b) {
    System.Console.WriteLine("Максимальное число "+$"{a}");
} else {
    System.Console.WriteLine("Максимальное число "+$"{b}");
}

// Ввод дробных чисел
double a1,b1;
string? c1=Console.ReadLine();
string? d1=Console.ReadLine();
a1=Convert.ToDouble(c1);
b1=Convert.ToDouble(d1);

if (a1>b1) {
    System.Console.WriteLine("Максимальное число "+$"{a1}");
} else {
    System.Console.WriteLine("Максимальное число "+$"{b1}");
}