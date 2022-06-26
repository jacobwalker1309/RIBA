using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RIBA_V2.Models;
using RIBA_V2.Services;

namespace RIBA_V2.Repositories
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        private readonly ICalcService _calcService;

        public Repository(DataContext context, ICalcService calcService)
        {
            _context = context;
            _calcService = calcService;
        }

        public List<OrderEncapsulationDto> GetData()
        {
            var customers = _context.Customers.Include(x => x.Orders).Include(y => y.Orders).ThenInclude(y => y.OrderItems).ToList();

            var orders = _context.Orders.Include(x => x.OrderItems).ToList();

            for (int i = 0; i < orders.Count(); i++)
            {
                orders[i].TotalCost = _calcService.Discount(orders[i]);
            }

            var wrapperList = new List<OrderEncapsulationDto>();

            foreach (var customer in customers)
            {
                var ordersByCustomer = orders.Where(x => x.CustomerId == customer.Id);
                foreach (var order in ordersByCustomer)
                {
                    var item = new OrderEncapsulationDto()
                    {
                        CustomerId = customer.Id,
                        CustomerName = customer.Name,
                        OrderId = order.Id,
                        OrderDescription = order.OrderDescription,
                        OrderTime = order.DateTime.ToString("dd/MM/yy"),
                        TotalCost = order.TotalCost
                    };

                    wrapperList.Add(item);
                }
            }

            return wrapperList;
        }
    }
}
