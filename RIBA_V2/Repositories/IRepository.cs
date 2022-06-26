using System;
using System.Collections.Generic;
using RIBA_V2.Models;

namespace RIBA_V2.Repositories
{
    public interface IRepository 
    {
        List<OrderEncapsulationDto> GetData();
    }
}
