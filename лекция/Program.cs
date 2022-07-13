//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
int[] array = {1,2,3,-1,-2};
Console.WriteLine(SumNumbersParametric(array,false));













  