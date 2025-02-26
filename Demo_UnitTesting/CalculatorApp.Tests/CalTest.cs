using CalculatorAPP;
using NUnit.Framework;

namespace CalculatorApp.Tests
{
  
    public class CalTest
    {
        MathCalculator cal= new MathCalculator();
        [Test]
        public void Test_To_AddTwoNumbers()
        {
            //assign
            int expected = 100;
            //act---calling to dev Code
            int actualResult =cal.AddTwoNumbers(10,10);
            //Assert
            Assert.That(expected, Is.EqualTo(actualResult));

        }
        //[TestCase(20)]
        //public void Test_To_validateAge(int age)
        //{
        //    bool result = IsValidAge(age);
        //    Assert.That(result, Is.True);
           

        //}
        [TestCase(15,ExpectedResult =true)]
        
        public bool Test_To_validateAge(int age)
        {
            bool result = IsValidAge(age);
            return result;
         }

        //private int AddTwoNumbers(int n1,int n2)
        //{
        //    return n1 + n2;
        //}
        private bool IsValidAge(int age)
        {
            if (age > 18)
            {
                return true;
            }
            return false;
        }
    }
}
