// С клавиатуры вводится целое число из диапазона [10, 99]. Показать наибольшую цифру числа.

System.Console.Write("Введите целое число из диапазона [10, 99]: ");
string? s=Console.ReadLine();
int k = Convert.ToInt32(s);
int a=k/10%10;
int b=k%10;
if (a>b) {
    System.Console.WriteLine("Наибольшая цифра числа " + $"{a}");
} 
if (b>a) {
    System.Console.WriteLine("Наибольшая цифра числа " + $"{b}");
}
if (a==b) {
    System.Console.WriteLine("Цифры введенного числа равны");
}