using System;
using EASV_D20s_SDM_XP_Calculater;
using NUnit.Framework;

namespace UnitTestProject
{
    
    public class Tests
    {
        [Test]
        public void AddValidNumber()
        {
            //Arrange
            IFIntCalculator c = new IntCalculator();
            int x = 12;
            int oldResult = c.Result;
            int expected = oldResult + x;
            
            //act
            c.Add(x);
            
            //Assert
            Assert.AreEqual(expected, c.Result);
        }

        [Test]
        public void AddNumberWithOverFlow()
        {
            IFIntCalculator c = new IntCalculator();
            c.Add(int.MaxValue);
            int oldResult = c.Result;
             var ex = Assert.Throws<InvalidOperationException>((() => c.Add(1)));
             Assert.AreEqual("OverFlow Boy", ex.Message);
             Assert.AreEqual(oldResult,c.Result);
             
           
        }
        [Test]
        public void AddNumberWithOverFlowMin()
        {
            IFIntCalculator c = new IntCalculator();
            c.Add(int.MinValue);
            int oldResult = c.Result;
            var ex = Assert.Throws<InvalidOperationException>((() => c.Add(-1)));
            Assert.AreEqual("UnderFlow Boy", ex.Message); 
            Assert.AreEqual(oldResult,c.Result);
        }
        
        [Test]
        public void SubtractTest()
        {
            //Arrange
            IFIntCalculator c = new IntCalculator();
            int x = 12;
            int oldResult = c.Result;
            int expected = oldResult - x;
            
            //act
            c.Subtract(x);
            
            //Assert
            Assert.AreEqual(expected, c.Result);
        }
        
        [Test]
        public void MultiplyTest()
        {
            //Arrange
            IFIntCalculator c = new IntCalculator();
            int x = 2;
            int oldResult = c.Result;
            int expected = oldResult * x;
            
            //act
            c.Multiply(x);
            
            //Assert
            Assert.AreEqual(expected, c.Result);
        }
        
        [Test]
        public void DivideTest()
        {
            //Arrange
            IFIntCalculator c = new IntCalculator();
            int x = 3;
            int oldResult = c.Result;
            int expected = oldResult/x;
            
            //act
            c.Divide(x);
            
            //Assert
            Assert.AreEqual(expected, c.Result);
        }
        
        [Test]
        public void DivideTestCanNotBeNull()
        {
            
            IFIntCalculator c = new IntCalculator();
            c.Divide(int.MinValue);
            int oldResult = c.Result;
            var ex = Assert.Throws<InvalidOperationException>((() => c.Divide(1)));
            Assert.AreEqual("Value Can not be 0", ex.Message);
            Assert.AreEqual(oldResult,c.Result);
            
        }

        [Test]
        public void ResetTest()
        {
            IFIntCalculator c = new IntCalculator();
            int x = 4;
            int oldResut = x;
            int expected = 0;
            
            //act
            c.Reset();
            
            Assert.AreEqual(expected, c.Result);
        }
    }
}