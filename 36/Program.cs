 //Задача 36. Сумма элементов, стоящих на нечётных позициях
Console.Write($"Введи количество элементов массива: ");
int numElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numElements, int min, int max)
  {
  int[] randomNumbers = new int[numElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");


