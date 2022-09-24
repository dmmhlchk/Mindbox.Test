using System;
using Mindbox.Test.Interfaces;

namespace Mindbox.Test.Figures
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            if (radius == 0)
                return;
            
            Area = 3.14 * Math.Pow(radius, 2);
        }
    }
}