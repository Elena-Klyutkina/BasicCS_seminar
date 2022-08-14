// 70. Найти сумму цифр числа - 2

{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма цифр числа:" + Sum(num));
}
static int Sum(int num)
{
    if (num < 10) return num;
    else return num % 10 + Sum(num / 10);
}