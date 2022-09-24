using System;

namespace Mindbox.Test.Interfaces
{
    public abstract class Figure
    {
        public double Area { get; set; }
        public void Show()
        {
            if (Area == 0)
            {
                Console.WriteLine("Error: value is equal zero");
                return;
            }

            Console.WriteLine(Area);
        }
    }
}