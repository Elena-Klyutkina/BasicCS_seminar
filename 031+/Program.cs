// Показать кубы чисел, заканчивающихся на четную цифру


System.Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int cube=1;
if(N%2==0 && N!=0){
    for(int i=0; i<=N; i++){
        cube=i*i*i;
    }
    Console.WriteLine("Куб числа равен " + cube);
}
else {
    System.Console.WriteLine("Введите четное число");
}