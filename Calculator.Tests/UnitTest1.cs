namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalc()
        {
            //correct data
            string expression = "8+2";
            string expected = "10";
            Util util = new();
            string actual = util.Calc(expression);
            Assert.Equal(expected, actual);

            //not correct data
            expression = "8/0";
            expected = "NOT ÷ 0";
            actual = util.Calc(expression);
            Assert.Equal(expected, actual);
            expression = "999999999+1";
            expected = "EXCEEDED";
            actual = util.Calc(expression);
            Assert.Equal(expected, actual);
            expression = "8d9";
            expected = "error";
            actual = util.Calc(expression);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiply()
        {
            string first = "2";
            string second = "3";
            string expected = "6";
            Util util = new();
            string actual = util.Multiply(first, second).ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivide()
        {
            string first = "9";
            string second = "3";
            string expected = "3";
            Util util = new();
            string actual = util.Divide(first, second).ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSum()
        {
            string first = "2";
            string second = "3";
            string expected = "5";
            Util util = new();
            string actual = util.Sum(first, second).ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinus()
        {
            string first = "8";
            string second = "3";
            string expected = "5";
            Util util = new();
            string actual = util.Minus(first, second).ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetValues()
        {
            string expression = "8+2";
            var expected = new { Item1 = "8", Item2 = "+", Item3 = "2" };
            Util util = new();
            var actual = util.GetValues(expression);
            Assert.Equal(expected.Item1, actual.Item1);
            Assert.Equal(expected.Item2, actual.Item2);
            Assert.Equal(expected.Item3, actual.Item3);
        }
    }
}