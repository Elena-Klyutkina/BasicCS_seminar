/* Даны две квадратные таблицы чисел. Требуется построить третью, 
каждый элемент которой равен сумме элементов, стоящих на том же месте
в 1-й и 2-й таблицах.

Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее - вторая. Элементы таблиц - числа от 0 до 100.
100>=N>=1.
*/

int N = 3;
int M = N;
int[,] arr1;
int[,] arr2;
int[,] arr3;
arr3 = new int[N, M];

Init(N, M, out arr1);
Print(arr1);
System.Console.WriteLine();
Init(N, M, out arr2);
Print(arr2);
System.Console.WriteLine();

// Решение
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        arr3[i, j] = arr1[i, j] + arr2[i, j];
    }
}
Print(arr3);


void Init(int N, int M, out int[,] a)
{
    a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(1, 101);
        }
    }
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j]} ");
        System.Console.WriteLine();
    }
}