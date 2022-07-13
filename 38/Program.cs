//Задача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел
double[] arrayNumbers = new double[10];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNum = arrayNumbers[0];
double minNum = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNum < arrayNumbers[i])
    {
      maxNum = arrayNumbers[i];
    }
        if (minNum > arrayNumbers[i])
    {
      minNum = arrayNumbers[i];
    }
  }

  double difference = maxNum - minNum;

  Console.WriteLine($"\nразница макс ({maxNum}) и мин({minNum}): {difference}");