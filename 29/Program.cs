// Задача 29. Ряд чисел преобразует в массив
Console.Write("Введите ряд чисел, разделенных запятой : ");
string rangeOfNum = Console.ReadLine();

rangeOfNum = rangeOfNum + ",";    // доп запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string range)
{
    string rangeNew = "";
    for (int i = 0; i < range.Length; i++)
    {
        if (range[i] != ' ') 
        {
            rangeNew += range[i];
        }
    }
    return rangeNew;
}
// функция  создания и заполнения массива из строки
int[] ArrayOfNum(string rangeNew)
{ 
    int[] arrayOfNums = new int[1];    // инициализация массива из 1 элемента
    int j =0;
    for (int i = 0; i < rangeNew.Length; i++)
    {
        string rangeNewa = "";
        while (rangeNew[i] != ',' && i < rangeNew.Length)
        {
            rangeNewa += rangeNew[i];
            i++;
        }
        arrayOfNums[j] = Convert.ToInt32(rangeNewa);    // заполняет массив из строки
        if (i < rangeNew.Length-1)  
        {
            arrayOfNums = arrayOfNums.Concat(new int[] {0}).ToArray();    // новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNums;
}

// печать 
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)  
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
} 

string rangeNew = RemovingSpaces(rangeOfNum);

int[] arrayOfNums =  ArrayOfNum(rangeNew);

PrintArray(arrayOfNums);
