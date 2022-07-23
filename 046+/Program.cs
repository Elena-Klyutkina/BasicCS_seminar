// Показать числа Фибоначчи

Console.Write("Введите конец диапазона: ");
int end=int.Parse(Console.ReadLine());
int prev = 0;
int current = 1;
int temp;
Console.Write($"{prev,4}");
Main();

void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{current,4}");
            temp = current;
            current = current + prev;
            prev = temp;
        }
    }