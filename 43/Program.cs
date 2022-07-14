//Задача 43.  Найти точку пересечения двух прямых 

double[,] kof = new double[2, 2];
double[] treck = new double[2];

void InputKof(){
  for (int i = 0; i < kof.GetLength(0); i++)
  {
    Console.WriteLine($"Введите kof {i+1}");
    for (int j = 0; j < kof.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите kof k: ");
      else Console.Write($"Введите kof b: ");
      kof[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Select(double[,] kof)
{
  treck[0] = (kof[1,1] - kof[0,1]) / (kof[0,0] - kof[1,0]);
  treck[1] = treck[0] * kof[0,0] + kof[0,1];
  return treck;
}
void Solution(double[,] kof)
{
  if (kof[0,0] == kof[1,0] && kof[0,1] == kof[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (kof[0,0] == kof[1,0] && kof[0,1] != kof[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Solution(kof);
    Console.Write($"\nТочка пересечения прямых: ({treck[0]}, {treck[1]})");
  }
}

InputKof();
Solution(kof);