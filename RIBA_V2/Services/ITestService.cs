using System;
using RIBA_V2.Entities;

namespace RIBA_V2.Services
{
    public interface ITestService
    {
        Order getFirstOrder();
        Order getSecondOrder();
        Order getThirdOrder();
        Order getFourthOrder();
    }
}
