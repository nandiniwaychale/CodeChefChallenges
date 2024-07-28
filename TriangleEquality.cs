using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class TriangleEquality
    {
        public  void checkFun()
        { 
             Console.WriteLine("Enter the length of side 1:");
             double side1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter the length of side 2:");
             double side2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter the length of side 3:");
             double side3 = Convert.ToDouble(Console.ReadLine());

              if (IsTriangle(side1, side2, side3))
              {
                      double perimeter = side1 + side2 + side3;
                        if (side1 == side2 && side2 == side3)
                        {
                            Console.WriteLine("It is an equilateral triangle.");
                        }
                        else if (side1 == side2 || side1 == side3 || side2 == side3)
                        {
                                 Console.WriteLine("It is an isosceles triangle.");
                        }
                        else
                         {
                               Console.WriteLine("It is a scalene triangle.");
                         }
                       Console.WriteLine("Perimeter of the triangle is: " + perimeter);
              }
              else
              {
                      Console.WriteLine("Invalid sides! These sides do not form a triangle.");
              }
        }
       public  bool IsTriangle(double side1, double side2, double side3)
       {
              return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
       }
    }
}
