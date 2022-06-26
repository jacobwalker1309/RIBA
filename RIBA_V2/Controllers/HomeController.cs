using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RIBA_V2.Entities;
using RIBA_V2.Models;
using RIBA_V2.Repositories;
using RIBA_V2.Services;

namespace RIBA_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalcService _calcService;
        private readonly IRepository _repository;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, ICalcService calcService, IRepository repository)
        {
            _logger = logger;
            _calcService = calcService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [ActionName("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _context.Customers.Include(x => x.Orders).Include(y => y.Orders).ThenInclude(y => y.OrderItems).ToListAsync();

            return Ok(customers);

        }

        public string GetSerializedData()
        {
            var wrapperList = _repository.GetData();
            
            var serializedData = JsonSerializer.Serialize(wrapperList);

            return serializedData;
        }
            
    }
}
