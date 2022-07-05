//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("add a(,)");
string A = Console.ReadLine();
var a1 = A.Split(',').Select(int.Parse).ToArray();

System.Console.WriteLine("add B (,)");
string B = Console.ReadLine();
var b1 = B.Split(',').Select(int.Parse).ToArray();

double d = Math.Sqrt(Math.Pow(b1[0]-a1[0],2) + Math.Pow(b1[1]-a1[1],2) + Math.Pow(b1[2]-a1[2],2));
System.Console.WriteLine($"Расстояние между точками: {d}");

