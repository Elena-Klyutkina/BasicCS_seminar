// С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)


// Целый тип данных
int a;
int b;
string? s=Console.ReadLine();//ввод данных
a=Convert.ToInt32(s);
b=a*a; //обработка данных

//вывод результата
System.Console.WriteLine("{0}^2={1}",a,b); // строка форматирования
System.Console.WriteLine($"{a}^2={b}"); // строка интерполяции


//Дробный тип данных
double a1;
double b1;
string? s1=Console.ReadLine();//ввод данных
a1=Convert.ToDouble(s1);
b1=a1*a1; //обработка данных

//вывод результата
// System.Console.WriteLine("{0}^2={1}",a,b); // строка форматирования
System.Console.WriteLine($"{a1}^2={b1}"); // строка интерполяции

/*string? s;
s=Console.ReadLine();

System.Console.WriteLine(s);
*/

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine(11%3);
// int a=0;
// double d=3.14;
// string s="Hello"+"World"; //конкатенация даных (склеивание)
// System.Int32 a;
// char c='a';
// System.Console.WriteLine(int.MaxValue);