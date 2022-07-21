// Удалить вторую цифру С КОНЦА целого числа введенного с клавиатуры.

System.Console.Write("Введите целое число больше 9: ");

string? s=Console.ReadLine();
int k = Convert.ToInt32(s);
int a=k%10; //последняя цифра
int b=k/100;

if (k < 10 || k > 99) {
System.Console.WriteLine(Convert.ToInt32($"{b}"+$"{a}"));
}
else {
System.Console.WriteLine($"{a}");
}