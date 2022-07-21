// Вывести на экран числа от -N до N

int i=0;
int N;
string? s=Console.ReadLine();
N=Convert.ToInt32(s);
for(i=-N; i<=N; i++) {
  System.Console.Write($"{i}, ");
}