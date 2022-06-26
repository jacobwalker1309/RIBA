using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RIBA_V2.Entities;
using RIBA_V2.Models;

namespace RIBA_V2.Services
{
    public class CalcService : ICalcService
    {
        private readonly DataContext _context;

        public CalcService(DataContext context)
        {
            _context = context;
        }

        // not really should have get here is a repository pattern, then inject the interface into here
        // because of small scope of the ticket, kept it here, however improvements would be so
        // would also have generic repository as well potentially
        // outline of funcs and delegate trees would allow to manipulate the queries for any gets for orders and items potentially
        // ispecification pattern with generic would accomplish the same
        // done both in personal learning time

        public int Discount(Order order)
        {
            // method changed slightly given the layout of order having a list of items in each order, trying to more replicate a real world delivery with lots of different items and quantites

            // having a discount on each bulk of items, rather than the total cost here
            // then total cost will be an aggregate of all discounted item sets added together

            // ifs can be replaced by switch with delegates for first improvement
            // will have to look into design patterns for best use of delegates here, use linq and place delegate in Where function

            var items = order.OrderItems;
            var totalCost = 0.0;

            foreach (var item in items)
            {
                // could have a switch here
                // replace the numbers with an enum - IOptions pattern would be there too
                // if wanted to just change the numbers in config
                // the Linq query stuff could be replaced by delegates
                if (item.Quantity <= 10)
                {
                    var itemBulkCost = (item.Quantity * item.UnitPrice);
                    totalCost += itemBulkCost;
                }

                if (item.Quantity > 10 && item.Quantity < 20)
                {
                    var itemBulkCost = (item.Quantity * item.UnitPrice) * 0.95;
                    totalCost += itemBulkCost;
                }

                if (item.Quantity > 20 && item.Quantity < 30)
                {
                    var itemBulkCost = (item.Quantity * item.UnitPrice) * 0.90;
                    totalCost += itemBulkCost;
                }

                if (item.Quantity > 30)
                {
                    // if this wasn't per orderItem then could just use the linq take and skip methods to get cost.
                    var initialQuantity = 30 * item.UnitPrice * 0.85;
                    totalCost += initialQuantity;

                    var secondQuantity = item.Quantity - 30;
                    totalCost += (secondQuantity * item.UnitPrice * 0.8);
                }
            }

            return (int)totalCost;
        }
    }
}
