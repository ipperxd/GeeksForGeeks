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

            var facade = new LogikBuilding.LogikBuildingFacade();

            // act
            string result1 = facade.OddEven(number1);
            string result2 = facade.OddEven(number2);

            // assert
            Assert.Equal("Odd", result1);
            Assert.Equal("Even", result2);
        }

        [Fact]
        public void MultilicationTable()
        {
            //arrange
            int number1 = 4;

            var facade = new LogikBuilding.LogikBuildingFacade();

            // act
            var result1 = facade.MutiplicationTable(number1);

            // assert
            Assert.Contains("4 * 1 = 4", result1);
            Assert.Contains("4 * 3 = 12", result1);
        }

        [Fact]
        public void SumOfNaturalNumbers()
        {
            int number = 5;

            var facade = new LogikBuilding.LogikBuildingFacade();

            var result = facade.ReturnNaturalSum(number);

            Assert.Equal(15, result);

        }
    }
}
