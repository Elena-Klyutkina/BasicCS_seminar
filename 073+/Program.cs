// 73 Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1

int n;
Console.Write("Введите число N: ");
string? s=Console.ReadLine();
n=Convert.ToInt32(s);
int fibonacchi(int n)

{
    if (n==1 || n==2) return 1;
    else return fibonacchi(n-1) + fibonacchi(n-2);
}

for (int i=1; i<=n; i++)
{
    System.Console.WriteLine(fibonacchi(i));
}