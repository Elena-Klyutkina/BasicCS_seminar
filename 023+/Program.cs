// Найти расстояние между точками в пространстве 2D

System.Console.Write("x1=");
Double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("x2=");
Double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y1=");
Double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y2=");
Double y2 = Convert.ToDouble(Console.ReadLine());
Double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine("Расстояние между точками в проастранстве равно " + Math.Round(distance,2));