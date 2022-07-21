// Задать номер четверти, показать диапазоны для возможных координат

System.Console.WriteLine("Введите номер координатной четверти: ");
int quarterNumber = Convert.ToInt32(System.Console.ReadLine());
if (quarterNumber==2 || quarterNumber==3) {
    System.Console.WriteLine("x<0");
}
if (quarterNumber==1 || quarterNumber==4) {
    System.Console.WriteLine("x>0");
}
if (quarterNumber==1 || quarterNumber==2) {
    System.Console.WriteLine("y>0");
}
if (quarterNumber==3 || quarterNumber==4) {
    System.Console.WriteLine("y<0");
} else {
System.Console.WriteLine("Введите число от 1 до 4");
}