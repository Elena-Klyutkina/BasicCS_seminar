// Выяснить является ли число чётным.

Console.Write("Введите число: ");
string? s=Console.ReadLine();
int a=Convert.ToInt32(s);
if (a%2==0){
    System.Console.WriteLine("Число четное");
} else {
    System.Console.WriteLine("Число нечетное");
}