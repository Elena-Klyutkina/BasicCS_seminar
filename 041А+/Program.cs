// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.

int N = 3;
int M = 3;
int[,] a; //описываем массив  

a = new int[N, M]; //создаем массив 

//Инициализация случайными числами 
Random random = new Random();

//Создали объект типа Random  
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(0, 2);
    }
}

//Вывод массива на экран
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
        System.Console.Write($"{a[i, j]} ");
    System.Console.WriteLine();
}

// Решение
bool flag = true;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if (a[i, j] != a[j, i])
        {
            flag = false;
            break;
        }
    }
}

if (flag)
{
    System.Console.Write("Матрица симметрична");
}
else System.Console.Write("Матрица несимметрична");