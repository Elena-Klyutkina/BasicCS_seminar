// Программа проверяет пятизначное число на палиндромом.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int numberReversed = 0;

while (number > 0)
{
    var n = number % 10;
    numberReversed = numberReversed * 10 + n;
    number = number/10;
}

System.Console.WriteLine($"{numberReversed}");

if(temp==numberReversed){
    System.Console.WriteLine("Число является палиндромом");
}
else {
    System.Console.WriteLine("Число не является палиндромом");
}