// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

System.Console.WriteLine("Введите целое число: ");
string? s=Console.ReadLine();
int a=Convert.ToInt32(s);
    
if(a>99){
    System.Console.WriteLine($"{a}".ToString()[2]);
}
else {
    System.Console.WriteLine("Третьей цифры числа нет");
}