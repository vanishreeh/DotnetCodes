using CalculatorApp;
using Xunit;

namespace Demo_Xunit
{
    public class TestWithXUnit
    {
        MathCalculator _mathCalculator = new MathCalculator();
        //[Fact]
        //public void Test_To_AddTwoNumbers1()
        //{

        //    //Assign
        //    int expectedResult = 20;
        //    //Act
        //    //calling to the Dev code
        //    int actualResult = _mathCalculator.AddTwoNumbers(10, 20);
        //    //Assert
        //    Assert.Equal(expectedResult, actualResult);

        //}
        [Theory]
        [InlineData(10,10,20)]
        public void Test_To_AddTwoNumbers1(int num1,int num2,int expected)
        {

            //Assign
            //int expectedResult = 20;
            //Act
            //calling to the Dev code
            int actualResult = _mathCalculator.AddTwoNumbers(num1,num2);
            //Assert
            Assert.Equal(expected, actualResult);

        }

    }
}
