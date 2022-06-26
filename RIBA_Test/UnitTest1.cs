using System;
using Moq;
using RIBA_V2.Services;
using Xunit;

namespace RIBA_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<ITestService>();
            var _testRepo = mock.Object;

            var calcMoq = new Mock<ICalcService>();
            var _calcService = calcMoq.Object;

            var firstOrder = _testRepo.getFirstOrder();
            var orderTotal = 0;
            orderTotal = _calcService.Discount(firstOrder);

            // quantity is 22
            // price is 12

            // based on logic 10% discount for the total cost

            // 22 * 12 = 264
            // 264 * 0.9 = 237.6 so should be 238
            // would use decimal or money given that its
            // make sure both are casted properly

            Assert.Equal(orderTotal.ToString(), firstOrder.ToString());
        }
    }
}
