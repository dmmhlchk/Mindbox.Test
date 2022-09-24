using System;
using Mindbox.Test.Figures;
using Mindbox.Test.Interfaces;

namespace Mindbox.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Figure circle = new Circle(5);
            Figure triangle = new Triangle(3,4,5);
            
            triangle.Show();
        }
    }
}