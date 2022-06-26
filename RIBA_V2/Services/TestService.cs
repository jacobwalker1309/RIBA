using System;
using RIBA_V2.Entities;

namespace RIBA_V2.Services
{
    public class TestService : ITestService
    {
        // test service, each case takes care of testing with the discount
        // parameters specified by the scope of the ticket

        private Customer customer;
        private Order order;
        private OrderItem orderItem1, orderItem2, orderItem3, orderItem4;

        public TestService()
        {
            customer = new Customer()
            {
                Id = 1,
                Name = "Jacob"
            };

            order = new Order()
            {
                Id = 1,
                OrderDescription = "Test Description"
            };

            orderItem1 = new OrderItem()
            {
                Id = 1,
                OrderId = 1,
                Quantity = 22,
                UnitPrice = 12
            };

            orderItem2 = new OrderItem()
            {
                Id = 2,
                OrderId = 1,
                Quantity = 15,
                UnitPrice = 765
            };

            orderItem3 = new OrderItem()
            {
                Id = 3,
                OrderId = 1,
                Quantity = 9,
                UnitPrice = 5
            };

            OrderItem orderItem4 = new OrderItem()
            {
                Id = 3,
                OrderId = 1,
                Quantity = 31,
                UnitPrice = 10
            };

            customer.Orders.Add(order);
        }

        public Order getFirstOrder()
        {
            order.OrderItems.Add(orderItem1);
            return order;
        }

        public Order getSecondOrder()
        {
            order.OrderItems.Add(orderItem2);
            return order;
        }

        public Order getThirdOrder()
        {
            order.OrderItems.Add(orderItem3);
            return order;
        }

        public Order getFourthOrder()
        {
            order.OrderItems.Add(orderItem4);
            return order;
        }

    }
}
