﻿// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
// !(X || Y)==!X && !Y

bool x,y,f;
x=false;
y=false;
f1=!(x || y);
f2=!x and !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");