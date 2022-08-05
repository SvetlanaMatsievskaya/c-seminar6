double b1 = 0;
double k1 = 0;
double b2= 0;
double k2 = 0;
Console.WriteLine("Введите b1: ");
double.TryParse(Console.ReadLine(), out b1);
Console.WriteLine("Введите k1: ");
double.TryParse(Console.ReadLine(), out k1);
Console.WriteLine("Введите b2: ");
double.TryParse(Console.ReadLine(), out b2);
Console.WriteLine("Введите k2: ");
double.TryParse(Console.ReadLine(), out k2);
void FindCrossPoint(double b1, double k1, double b2, double k2)
{
  double x = (b2-b1)/(k1-k2);
  double y = k1*x + b1;
  Console.Write($"({x};{y})");
}
FindCrossPoint( b1,  k1,  b2,  k2);