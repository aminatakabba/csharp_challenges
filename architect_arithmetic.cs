using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Console.WriteLine(Circle(5));
      double totalArea = React(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);
      double costArea = Math.Round(totalArea * 180);
      Console.WriteLine($"{costArea} is the total cost to build this structure in Mexican pesos");
    }
    static double React(double length, double width) 
      {
        return length * width;
      }
      static double Circle(double radius)
      {
        return Math.PI * Math.Pow(radius, 2);
      }
      static double Triangle(double height, double bottom) 
      {
        return 0.5 * bottom * height;
      }

  }
}
