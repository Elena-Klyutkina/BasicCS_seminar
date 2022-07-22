// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] t;
Init(out t,n,100,999);
Print(t);

int count_even=0, count_uneven=0;
for(int i=0;i<t.Length;i++)
    { 
        if(t[i]%2==0) {
            count_even=count_even+1;
            } else {
                count_uneven=count_uneven+1;
            }
    }
System.Console.WriteLine("Количество четных чисел: " + $"{count_even}");
System.Console.WriteLine("Количество нечетных чисел: " + $"{count_uneven}");


void Init(out int[] t, int Length,int min,int max)
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1);
}

void Print(int[] t)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{t[i],7}");
  System.Console.WriteLine();
}