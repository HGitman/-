int a = 2;
int b = 4;
int c = 2;

if (a < b+c && b < a+c && c < b+a)
{
    Console.WriteLine("Это не треугольник");
}
else
{
    Console.WriteLine("Это треугольник");
}