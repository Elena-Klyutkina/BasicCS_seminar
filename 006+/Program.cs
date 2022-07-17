// Написать программу вычисления значения функции y = sin(a). (Класс Math)

double x,y;
// x=3.14;
x=Math.PI;
y=Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");

/*
//тип возвращаемого значения Имя_функции (аргументы функции)
double Sin(double x) // методы
{
    return Math.Sin(x);
}


double Sum(double a,double b) // методы
{
    return a+b;
}

double Sum(int a,int b) // методы
{
    return a+b;
}


void Pause() //метод. void означает, что функция ничего не возвращает
{
    System.Console.WriteLine("Press any key");
}


double y=Sin(3.14);
System.Console.WriteLine(y);
Pause();
*/