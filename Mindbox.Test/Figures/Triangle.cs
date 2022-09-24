using System;
using Mindbox.Test.Interfaces;

namespace Mindbox.Test.Figures
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
                return;
            
            if(Math.Pow(c,2) == (Math.Pow(a,2) + Math.Pow(b,2)))
                Console.WriteLine("the triangle is right angled");
            
            double p = (a + b + c) / 2;
            Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}