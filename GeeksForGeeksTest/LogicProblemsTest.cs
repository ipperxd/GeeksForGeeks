namespace GeeksForGeeksTest
{
    public class LogicProblemsTest
    {
        [Fact]
        public void OddOrEven()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            var facade = new LogikBuilding.EasyProblems.LogikBuildingFacade();

            // act
            string result1 = facade.OddEven(number1);
            string result2 = facade.OddEven(number2);

            // assert
            Assert.Equal("Odd", result1);
            Assert.Equal("Even", result2);
        }
    }
}
