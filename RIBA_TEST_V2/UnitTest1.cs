using System;
using Moq;
using RIBA_V2.Entities;
using RIBA_V2.Services;
using Xunit;

namespace RIBA_TEST_V2
{
    public class UnitTest1
    {
        // ran out of time with testing
        // below is an idea of how i would move forward
        // would need to spend sometime into setting up the tests
        // would repear for each object return from test service

            [Fact]
            public void Test1()
            {
                var testRepo = new Mock<ITestService>();
            testRepo.Setup(repo => repo.getFirstOrder()).Returns(new Order());
                
                var calcMoq = new Mock<ICalcService>();
            calcMoq.Setup(serv => serv.Discount(new RIBA_V2.Entities.Order()))
                

             // var firstOrder = testRepo.getFirstOrder();
             // var orderTotal = 0;
             // orderTotal = calcMoq.Discount(firstOrder);

             // quantity is 22
             // price is 12

             // based on logic 10% discount for the total cost

             // 22 * 12 = 264
             // 264 * 0.9 = 237.6 so should be 238
             // would use decimal or money given that its
             // make sure both are casted properly

             //   Assert.Equal(orderTotal.ToString(), firstOrder.ToString());
            // }
        }
}
