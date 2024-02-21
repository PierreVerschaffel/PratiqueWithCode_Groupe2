namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(1,1,0)]
        [DataRow(10,2,8)]
        public void Substract_WithTwoNumbers_ReturnSubstraction(int numberOne, int numberTwo, int expectedResult)
        {
            var actualResult = _mathOperations.Subtract(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(1500)]
        [DataRow(500000)]
        public void Substract_WithSecondNumberHigherThan1200_ThrowArgumentException(int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(()=> _mathOperations.Subtract(100000,numberTwo));
        }

        [TestMethod]
        [DataRow(1,2)]
        [DataRow(10,20)]
        public void Substract_WithSecondNumberHigherThanFirstNumber_ThrowArgumentException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(10)]
        public void GetColorFromOddsNumber_WithOddNumber_ReturnString(int number)
        {
            var result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.IsTrue(result.Contains("Red"));
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(11)]
        public void GetColorFromOddsNumber_WithEvenNumber_ReturnString(int number)
        {
            var result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.IsTrue(result.Contains("Blue"));
        }

        [TestMethod]
        [DataRow(-10)]
        [DataRow(-1)]
        public void GetColorFromOddsNumber_WithNumberUnderZero_ThrowArgumentException(int number)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(number));
        }
    }
}