// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.WriteLine("Введите два числа: ");
string? s=Console.ReadLine();
int a=Convert.ToInt32(s);
string? k=Console.ReadLine();
int b=Convert.ToInt32(k);

if(a%b==0){
    System.Console.WriteLine("Число a кратно числу b");
} else {
    System.Console.WriteLine($"{a%b}");
}