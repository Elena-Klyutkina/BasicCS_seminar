// Вывести на экран четные числа от 1 до N

/*
int i=2;
int N=20;
while(i<=N){
    System.Console.Write($"{i} ");
    i=i+2;
}
*/

int i=1;
int N;
string? s=Console.ReadLine();
N=Convert.ToInt32(s);
while(i<=N){
    if (i%2==0)
    {
        System.Console.Write($"{i} ");
    }
    i=i+1;
}