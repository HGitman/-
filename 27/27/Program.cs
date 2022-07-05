void Summa(int a)
{
    int temp = 0;
    for (; a > 0; a /= 10)
    {
        temp += a % 10;
    }
} 
Console.WriteLine(temp);
