// Написать программу замены элементов массива на противоположные

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] t;
Init(out t,n,1,100);
Print(t);
Change(t);
PrintNegativ(t);

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

void Change(int[] t)
{
    for (int i=0;i<t.Length;i++)
    if (t[i]>0) t[i] = -t[i];
}

void PrintNegativ(int[] t)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{t[i],7}");
}