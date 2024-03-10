using System;

class Program 
{
  public static void Main (string[] args)
  {
    Console.WriteLine("Введите первое число: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int n = int.Parse(Console.ReadLine());
    Numbers(m, n);

    void Numbers (int a, int b)
    {
      if (a == b)
      {
        Console.Write($"{a} ");
        return; 
      }
      Console.Write($"{a} ");
      Numbers(a + 1, b);
      //для вывода в обратном порядке меняем местами 20 и 21 строки
    }
  }
}