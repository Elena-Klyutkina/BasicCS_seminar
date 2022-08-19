// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int N = InputNumbers("Введите N: ");
int M = InputNumbers("Введите M: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] a = new int[N, M];
Init2(N, M, out a);
Print(a);
Console.WriteLine($"\nОтсортированный массив: ");
Print(a);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int minSumLine = 0;
int sumLine = SumLineElements(a, 0);
for (int i = 1; i < a.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(a, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} строкa с наименьшей суммой элементов: {sumLine}");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void Init2(int N, int M, out int[,] a)
{
    a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(1, range + 1);
        }
    }
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) System.Console.Write($"{a[i, j],4} ");
        System.Console.WriteLine();
    }
}