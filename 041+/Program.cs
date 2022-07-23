// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

System.Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// создаем массив из n чисел
int[] a=new int[n];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
   a[i]=random.Next(0,10);
System.Console.Write("Массив случайных чисел: ");
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

int max=0;
for(int i=0;i<a.Length;i++)
    if(a[i]>max) max=a[i];

int min=max;
for(int i=0;i<a.Length;i++)
    if(a[i]<min) min=a[i];

int diff = max-min;
System.Console.WriteLine("\nМаксимальное число: " + max);
System.Console.WriteLine("Минимальное число: " + min);
System.Console.WriteLine("Разница между максимальным и минимальным числом: " + diff);