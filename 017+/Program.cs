// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a=6;
int[] day;
day=new int[7];
day[0]=1;
day[1]=2;
day[2]=3;
day[3]=4;
day[4]=5;
day[5]=6;
day[6]=7;
// if (a==6 || a==7)
if(a==day[5] || a==day[6]){
    System.Console.WriteLine("День недели является выходным");
} 
else{
    System.Console.WriteLine("День недели не является выходным");
}