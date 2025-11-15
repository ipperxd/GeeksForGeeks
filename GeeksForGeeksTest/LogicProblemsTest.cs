using LogikBuilding;

namespace GeeksForGeeksTest
{
    public class LogicProblemsTest
    {
        LogikBuildingFacade facade = new LogikBuildingFacade();

        [Fact]
        public void OddOrEven()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            

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

            var result = facade.ReturnNaturalSum(number);

            Assert.Equal(15, result);

        }

        [Fact]
        public void SumOfSquaredNaturals()
        {
            int number = 8;
            
            int result = 0;

            result = facade.ReturnSumOfSquaredNaturals(number);

            Assert.Equal(204, result);
        }

        [Fact]
        public void SwapToNumbers()
        {
            int number1 = 2;
            int number2 = 3;

            var result = facade.SwapTwoNumbersFacade(number1, number2);

            number1 = result[0];
            number2 = result[1];

            Assert.Equal(3, number1);
            Assert.Equal(2, number2);
        }
    }
}
