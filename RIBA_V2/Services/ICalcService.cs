using System;
using System.Collections.Generic;
using RIBA_V2.Entities;
using RIBA_V2.Models;

namespace RIBA_V2.Services
{
    public interface ICalcService
    {
        int Discount(Order order);
    }
}
