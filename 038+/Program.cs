// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


// создаем массив от 10 до 99
int[] a=new int[90];
int j=9;
for(int i=0;i<=89;i++){
    j=j+1;
    a[i]=j;
}
System.Console.WriteLine("Массив от 10 до 99: ");
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

// создаем массив из 123 чисел
int[] b=new int[123];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<b.Length;i++)
    b[i]=random.Next(0,100);
System.Console.WriteLine("\nМассив из 123 случайных чисел: ");
for(int i=0;i<b.Length;i++)
    System.Console.Write($"{b[i],4}");

int count=0;
// цикл для массива 10-99
for(int k=0;k<b.Length;k++){
    for(int f=0;f<a.Length;f++)
        if(a[f]==b[k]) count=count+1;
    }
System.Console.WriteLine("\nКоличество элементов в массиве из 123 чисел из отрезка [10,99] равно " + $"{count}");
