
using NUnit.Framework;
using CalculatorApp;
namespace Calculator.Tests
{
    public class CalTest
    {
        MathCalculator _mathCalculator;
        
        [SetUp]
        public void Setup()
        {
            _mathCalculator= new MathCalculator();
        }

        [Test]
        public void Test_To_AddTwoNumbers1()
        {

            //Assign
            int expectedResult = 20;
            //Act
            //calling to the Dev code
            int actualResult = _mathCalculator.AddTwoNumbers(10, 20);
            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));

        }
            //}
        [TestCase(10,10)]
        [TestCase(20, 10)]
        [Ignore("not completed")]
        public void Test_To_AddTwoNumbers(int num1,int num2)
        {

            //Assign
            int expectedResult = 20;
            //Act
            //calling to the Dev code
            int actualResult = _mathCalculator.AddTwoNumbers(num1,num2);
            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));


        }


    }
}
