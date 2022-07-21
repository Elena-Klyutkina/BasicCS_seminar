// Возведите число А в натуральную степень B, используя цикл

System.Console.Write("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень, в которую нужно возвести указанное выше число: ");
int B=Convert.ToInt32(Console.ReadLine());
int numberInPower=1;
for(int i = 1; i <= B; i++){
    numberInPower = numberInPower*A;
};
Console.WriteLine(numberInPower);