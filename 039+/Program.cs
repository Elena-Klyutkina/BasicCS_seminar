//39. Найти сумму чисел одномерного массива, стоящих на нечетной позиции

//инициализация массива
int[] a=new int[12];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,10);

//вывод массива (до обработки)
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

//решение задачи
int s=0;
for(int i=0;i<a.Length;i++)
    if (i%2!=0)
        s=s+a[i];

System.Console.WriteLine($"{s}");