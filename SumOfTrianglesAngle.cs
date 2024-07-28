using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class SumOfTrianglesAngle
    {
          public void sumFunction()
        {
            Console.WriteLine("Enter the first angle of the triangle:");
            double angle1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second angle of the triangle:");
            double angle2 = Convert.ToDouble(Console.ReadLine());

            double angle3 = 180 - angle1 - angle2;
            Console.WriteLine("The sum of all angles in the triangle is: " + (angle1 + angle2 + angle3) + " degrees");
        }
    }
}