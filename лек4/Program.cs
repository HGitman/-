int SumNumbersParametric(int[] array, bool findPositiveNumbers = true)
{
    int sum = 0;
    foreach(var element in array)
    {
        if (findPositiveNumbers)
        {
            sum += element > 0 ? element : 0;
        }
        else
        {
            sum += element < 0 ? element : 0;
        }        
    }
    return sum;
}
int SumNumbersParametric(int[] array, bool findPositiveNumbers = true);
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] Array =new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(minValue, maxvalue+1);
    }
    return Array;
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(string.Join(",",array));
    }
}
int[] array = GetArray(12,-9,9);
PrintArray(array);
Console.WriteLine($"Sum pos :{ SumNumbersParametric(array)}");
Console.WriteLine($"Sum pos :{ SumNumbersParametric(array,false)}");
//Console.WriteLine(SumNumbersParametric(array,false));