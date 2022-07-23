//Написать программу преобразования десятичного числа в двоичное

int n=555;
System.Console.WriteLine(DecToBin(n));

string DecToBin(int n)
{
    if (n==0) return "0";
    string s="";
    while (n!=0)
    {
        s=(n%2).ToString()+s;    
        n/=2;//n=n/2
    }
    return s;
}