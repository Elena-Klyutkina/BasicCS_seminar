﻿// Задать массив из 8 элементов и вывести их на экран

/*
int[] t; // объявляем массив
t=new int[8];
// t[0]=10;
// t[1]=12;
// t[2]=15; //присваиваем значение ячейке под индексом
for(int i=0;i<t.Length;i++)
    t[i]=i*10;
for(int i=0;i<t.Length;i++)
System.Console.Write($"a[{i}]={t[i]} ");
*/

int[] t;//объявление
//инициализация
Init(out t,8,max:100);
//решение задачи
//вывод результатов на экран
Print(t,"t");


void Init(out int[] t, int Length,int min=0,int max=10)
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1);
}

void Print(int[] t, string variableName)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{variableName}[{i}]={t[i]} ");
}