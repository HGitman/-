Console.Write("Add number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int SumNum(int numN)
{
    int advance = 0;
    int result = 0;
    int counter = Convert.ToString(numN).Length;
    for (int i = 0; i < counter; i++)   
    {
        advance = numN - numN % 10;
        result = result + (numN - advance);
        numN = numN / 10;
    }
    return result;
}

int sumNum = SumNum(numN);
Console.WriteLine("sum  digits in number: " + sumNum);