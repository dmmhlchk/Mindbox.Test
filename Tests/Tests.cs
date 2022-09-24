using System;
using Mindbox.Test;
using Mindbox.Test.Figures;
using Mindbox.Test.Interfaces;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleSuccess()
        {
            var circle = new Circle(5);
            Assert.AreEqual(78.5, circle.Area);
        }
        
        // [Test]
        // public void CircleFail()
        // {
        //     var circle = new Circle(5);
        //     Assert.AreEqual(78, circle.Area);
        // }
        
        [Test]
        public void TriangleSuccess()
        {
            var triangle = new Triangle(3,4,5);
            Assert.AreEqual(6, triangle.Area);
        }
        
        // [Test]
        // public void  TriangleFail()
        // {
        //     var triangle = new Triangle(3,4,5);
        //     Assert.AreEqual(7, triangle.Area);
        // }
        
    }
}