//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число:");
string chislo = Console.ReadLine();

if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
{ System.Console.WriteLine("yes polindrom"); }
else
{ System.Console.WriteLine("no not polindrom"); }