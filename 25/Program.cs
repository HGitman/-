﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine($"Возведене числа A в степень B");

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for(int i=1; i <= numberB; i++)
    {
    result = result * numberA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numA, numB);
Console.WriteLine("result " + exponentiation);