// Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int mult=1;

for (int i=1; i<=N; i++)
{
    mult = mult*i;
}
System.Console.WriteLine(mult);