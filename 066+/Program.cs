// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (N > M)
    for (int i = M; i <= N; i++)
    { sum = sum + i; }

else if (M > N)
    for (int i = N; i <= M; i++)
    { sum = sum + i; }
Console.Write($"{sum}");