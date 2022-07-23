// Определить сколько чисел больше 0 введено с клавиатуры

Main();

void Main()
    {
        try
        {
            Console.Write("Введите элементы(через пробел): ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Кол-во элементов больше 0: {count}");
        }
        catch (SystemException)
        {
             Console.WriteLine("Во время выполнения программы произошла ошибка, вероятно, были введены некорректные данные!");
        }
    }