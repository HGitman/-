//Задача 25.Возведене числа A в степень B

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for(int i=1; i <= numB; i++)
    {
    result = result * numA;
    }
    return result;
}
Console.Write("add A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("add B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(numA, numB);
Console.WriteLine("result " + exponentiation);