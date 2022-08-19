// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int N = InputNumbers("Введите N: ");
int M = InputNumbers("Введите M: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] a = new int[N, M];
Init2(N, M, out a);
Print(a);
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(a);
Print(a);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
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

void OrderArrayLines(int[,] new_a)
{
    for (int i = 0; i < new_a.GetLength(0); i++)
    {
        for (int j = 0; j < new_a.GetLength(1); j++)
        {
            for (int k = 0; k < new_a.GetLength(1) - 1; k++)
            {
                if (new_a[i, k] > new_a[i, k + 1])
                {
                    int temp = new_a[i, k + 1];
                    new_a[i, k + 1] = new_a[i, k];
                    new_a[i, k] = temp;
                }
            }
        }
    }
}