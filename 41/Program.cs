//Задача 41. Cколько чисел больше 0 ввёл пользователь 
Console.Write($"Введи число М(количество чисел): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massNumbers = new int[M];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massNumbers)
{
  int count = 0;
  for (int i = 0; i < massNumbers.Length; i++)
  {
    if(massNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);
Console.WriteLine($"Введено чисел больше 0: {Comparison(massNumbers)} ");
